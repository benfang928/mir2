﻿using Server.MirDatabase;

namespace Server.MirObjects.Monsters
{
    public class Trainer : MonsterObject
    {
        private HumanObject _currentAttacker = null;
        private int _hitCount = 0, _totalDamage = 0;
        private long _lastAttackTime = 0, _StartTime = 0;
        private bool Poisoned = false;

        protected override bool CanAttack { get { return false; } }
        protected override bool CanMove { get { return false; } }
        //protected override bool CanRegen { get { return false; } }
        protected override bool DropItem(UserItem item) { throw new NotSupportedException(); }
        protected override bool DropGold(uint gold) { throw new NotSupportedException(); }

        protected override void Attack() { }
        //protected override void ProcessRegen() { }
        protected override void ProcessRoam() { }

        public override bool Blocking { get { return true; } }
        public override bool IsAttackTarget(HumanObject attacker) { return true; }
        public override bool IsAttackTarget(MonsterObject attacker) 
        {
            if (attacker.Master == null) return false;

            return true; 
        }

        public override void Die() { }
        public override void ReceiveChat(string text, ChatType type) { }

        protected internal Trainer(MonsterInfo info)
            : base(info) { }

        public override void Spawned()
        {
            PoisonStopRegen = false;
            if (Respawn != null && Respawn.Info.Direction < 8)
                Direction = (MirDirection)Respawn.Info.Direction;

            base.Spawned();
        }

        public override void Process()
        {
            base.Process();

            if (_currentAttacker != null && _lastAttackTime + 5000 < Envir.Time)
            {
                OutputAverage();
                ResetStats();
            }
        }

        // Player attacking trainer.
        public override int Attacked(HumanObject attacker, int damage, DefenceType type = DefenceType.ACAgility, bool damageWeapon = false)
        {
            if (attacker == null) return 0;

            if (_currentAttacker != null && _currentAttacker != attacker)
            {
                OutputAverage();
                ResetStats();
            }

            damage += attacker.Stats[Stat.功力];

            int armour = 0;
            //deal with trainers defense
            switch (type)
            {
                case DefenceType.AC:
                case DefenceType.ACAgility:
                    armour = GetAttackPower(Stats[Stat.最小防御], Stats[Stat.最大防御]);
                    break;
                case DefenceType.MAC:
                case DefenceType.MACAgility:
                    armour = GetAttackPower(Stats[Stat.最小魔御], Stats[Stat.最大魔御]);
                    break;
            }
            if (armour >= damage)
            {
                BroadcastDamageIndicator(DamageType.Miss);
                return 0;
            }

            damage -= armour;

            attacker.GatherElement();

            if (_currentAttacker == null)
                _StartTime = Envir.Time;
            _currentAttacker = attacker;
            _hitCount++;
            _totalDamage += damage;
            _lastAttackTime = Envir.Time;
            
            ReportDamage(damage, type, false);
            return 1;
        }

        // Pet attacking trainer.
        public override int Attacked(MonsterObject attacker, int damage, DefenceType type = DefenceType.ACAgility)
        {
            if (attacker == null || attacker.Master == null) return 0;
            
            if (_currentAttacker != null && _currentAttacker != attacker.Master)
            {
                OutputAverage();
                ResetStats();
            }



            int armour = 0;
            //deal with trainers defense
            switch (type)
            {
                case DefenceType.AC:
                case DefenceType.ACAgility:
                    armour = GetAttackPower(Stats[Stat.最小防御], Stats[Stat.最大防御]);
                    break;
                case DefenceType.MAC:
                case DefenceType.MACAgility:
                    armour = GetAttackPower(Stats[Stat.最小魔御], Stats[Stat.最大魔御]);
                    break;
            }
            if (armour >= damage)
            {
                BroadcastDamageIndicator(DamageType.Miss);
                return 0;
            }
            damage -= armour;

            if (_currentAttacker == null)
                _StartTime = Envir.Time;


            MapObject tmpAttacker = attacker.Master;

            while(true)
            {
                if(tmpAttacker.Master != null)
                {
                    tmpAttacker = tmpAttacker.Master;
                    continue;
                }
                break;
            }

            _currentAttacker = (PlayerObject)tmpAttacker;

            _hitCount++;
            _totalDamage += damage;
            _lastAttackTime = Envir.Time;

            ReportDamage(damage, type, true);
            return 1;
        }

        public override int Struck(int damage, DefenceType type = DefenceType.ACAgility)
        {
            return 0;
        }

        public override void PoisonDamage(int damage, MapObject attacker)
        {
            damage *= (-1); //damage = damage * (-1);
            if (attacker == null || (attacker is MonsterObject && attacker.Master == null)) return;

            if (_currentAttacker != null && (_currentAttacker != attacker || _currentAttacker != attacker.Master))
            {
                OutputAverage();
            }
            
            if (_currentAttacker == null)
                _StartTime = Envir.Time;
            _currentAttacker = attacker is MonsterObject ? (PlayerObject)attacker.Master : (PlayerObject)attacker;
            _hitCount++;
            _totalDamage += damage;
            _lastAttackTime = Envir.Time;

            long timespend = Math.Max(1000, (Envir.Time - _StartTime));//avoid division by 0
            if (_StartTime == 0)
                timespend = 1000;
            double Dps = _totalDamage / (timespend * 0.001);
            _currentAttacker.ReceiveChat(string.Format("{1}造成伤害 {0} , -持续每秒伤害输出: {2:#.00}", damage, attacker is MonsterObject ? "属下毒攻击" : "毒攻击", Dps), ChatType.Trainer);
            Poisoned = true;
        }

        protected override void ProcessRegen()
        {
            if (Dead) return;

            int healthRegen = 0;

            if (CanRegen)
            {
                RegenTime = Envir.Time + RegenDelay;
                healthRegen += (int)(Stats[Stat.HP] * 0.022F) + 1;
            }
            if (healthRegen > 0) ChangeHP(healthRegen);
        }

        public override void ChangeHP(int amount)
        {
            if (!Poisoned) return;
            if (_currentAttacker == null) return;
            _totalDamage += amount;
            long timespend = Math.Max(1000, (Envir.Time - _StartTime));//avoid division by 0
            if (_StartTime == 0)
                timespend = 1000;
            double Dps = _totalDamage / (timespend * 0.001);
            _currentAttacker.ReceiveChat(string.Format("持续伤害值: {0} -持续每秒伤害输出: {1:#.00}", amount, Dps), ChatType.Trainer);
        }


        private void ReportDamage(int damage, DefenceType type, bool Pet)
        {
            string output = "";
            switch (type)
            {
                case DefenceType.ACAgility:
                    output = "物理";
                    break;
                case DefenceType.AC:
                    output = "无视物理防御";
                    break;
                case DefenceType.MACAgility:
                    output = "无视魔法防御";
                    break;
                case DefenceType.MAC:
                    output = "魔法";
                    break;
                case DefenceType.Agility:
                    output = "无视敏捷";
                    break;
            }
            long timespend = Math.Max(1000,(Envir.Time - _StartTime));//avoid division by 0
            if (_StartTime == 0)
                timespend = 1000;
            double Dps = _totalDamage / (timespend * 0.001);
            _currentAttacker.ReceiveChat(string.Format("{3}造成 {0} {1}伤害, -持续每秒伤害输出: {2:#.00}", damage, output, Dps, Pet? "属下攻击": "攻击"), ChatType.Trainer);
        }

        private void ResetStats()
        {
            _currentAttacker = null;
            _hitCount = 0;
            _totalDamage = 0;
            _lastAttackTime = 0;
            _StartTime = 0;
            Poisoned = false;
            PoisonList.Clear();
        }

        private void OutputAverage()
        {
            if (_currentAttacker == null) return;
            long timespend = Math.Max(1000, (_lastAttackTime - _StartTime));//avoid division by 0
            if (_StartTime == 0)
                timespend = 1000;
            double Dps = _totalDamage / (timespend * 0.001);
            _currentAttacker.ReceiveChat(string.Format("攻击平均伤害值: {0} -持续每秒伤害输出: {1:#.00}", (int)(_totalDamage / _hitCount),Dps), ChatType.Trainer);
        }
    }
}
