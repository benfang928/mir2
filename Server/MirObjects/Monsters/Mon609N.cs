﻿using System.Drawing;
using Server.MirDatabase;
using Server.MirEnvir;
using S = ServerPackets;

namespace Server.MirObjects.Monsters
{
    public class Mon609N : MonsterObject
    {
        protected internal Mon609N(MonsterInfo info)
            : base(info)
        {
        }

        protected override bool InAttackRange()
        {
            if (Target.CurrentMap != CurrentMap) return false;
            return CurrentMap == Target.CurrentMap && Functions.InRange(CurrentLocation, Target.CurrentLocation, Info.ViewRange);
        }

        protected override void Attack()
        {
            if (!Target.IsAttackTarget(this))
            {
                Target = null;
                return;
            }

            ActionTime = Envir.Time + 300;
            AttackTime = Envir.Time + AttackSpeed;
            ShockTime = 0;

            Direction = Functions.DirectionFromPoint(CurrentLocation, Target.CurrentLocation);
            bool ranged1 = CurrentLocation == Target.CurrentLocation || !Functions.InRange(CurrentLocation, Target.CurrentLocation, 1);
            bool ranged2 = CurrentLocation == Target.CurrentLocation || !Functions.InRange(CurrentLocation, Target.CurrentLocation, 2);

            if (!ranged1)
            {
                switch (Envir.Random.Next(3))
                {
                    case 0:
                        {
                            Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 0 });

                            int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击]);
                            if (damage == 0) return;
                            HalfmoonAttack(damage);

                            DelayedAction action = new(DelayedType.Damage, Envir.Time + 300, Target, damage, DefenceType.AC, false);
                            ActionList.Add(action);
                        }
                        break;
                    case 1:
                        {
                            Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 0 });

                            int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击] * 2);
                            if (damage == 0) return;
                            FullmoonAttack(damage, 600, DefenceType.ACAgility, 1, 2);

                            DelayedAction action = new(DelayedType.Damage, Envir.Time + 300, Target, damage, DefenceType.ACAgility, false);
                            ActionList.Add(action);
                        }
                        break;
                    case 2:
                        {
                            Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 1 });

                            int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击]);
                            if (damage == 0) return;
                            WideLineAttack(damage, 2, 300, DefenceType.ACAgility, true, 3);

                            DelayedAction action = new(DelayedType.Damage, Envir.Time + 300, Target, damage, DefenceType.ACAgility, false);
                            ActionList.Add(action);
                        }
                        break;

                }
            }

            else if (!ranged2)
            {
                switch (Envir.Random.Next(2))
                {
                    case 0:
                        {
                            Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 1 });

                            int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击]);
                            if (damage == 0) return;
                            WideLineAttack(damage, 4, 500, DefenceType.ACAgility, false, 3);

                            DelayedAction action = new(DelayedType.Damage, Envir.Time + 300, Target, damage, DefenceType.ACAgility, false);
                            ActionList.Add(action);
                        }
                        break;
                    case 1:
                        {
                            Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 1 });

                            int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击] * 2);
                            if (damage == 0) return;
                            WideLineAttack(damage, 3, 500, DefenceType.AC, false, 3);

                            DelayedAction action = new(DelayedType.Damage, Envir.Time + 300, Target, damage, DefenceType.AC, false);
                            ActionList.Add(action);
                        }
                        break;

                }
            }
            else

                switch (Envir.Random.Next(3))
                {
                    case 0:
                        {
                            Broadcast(new S.ObjectRangeAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, TargetID = Target.ObjectID });

                                int damage = GetAttackPower(Stats[Stat.最小魔法], Stats[Stat.最大魔法]);
                                if (damage == 0) return;

                            DelayedAction action = new(DelayedType.RangeDamage, Envir.Time + 500, Target, damage, DefenceType.MAC, true);
                            ActionList.Add(action);
                        }
                        break;
                    case 1:
                        {
                            Broadcast(new S.ObjectRangeAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, TargetID = Target.ObjectID, Type = 1 });

                            ExplosionBall();
                        }
                        break;

                }
        }
        private void ExplosionBall()
        {
            List<MapObject> targets = FindAllTargets(Info.ViewRange, CurrentLocation);

            var count = targets.Count;

            if (count == 0) return;

            var target = targets[Envir.Random.Next(count)];

            var location = target.CurrentLocation;

            for (int y = location.Y - 1; y <= location.Y + 1; y++)
            {
                if (y < 0) continue;
                if (y >= CurrentMap.Height) break;

                for (int x = location.X - 1; x <= location.X + 1; x++)
                {
                    if (x < 0) continue;
                    if (x >= CurrentMap.Width) break;

                    if (x == CurrentLocation.X && y == CurrentLocation.Y) continue;

                    var cell = CurrentMap.GetCell(x, y);

                    if (!cell.Valid) continue;

                    int damage = GetAttackPower(Stats[Stat.最小魔法], Stats[Stat.最大魔法]);

                    var start = 500;

                    var time = Settings.Second * 15;

                    SpellObject ob = new()
                    {
                        Spell = Spell.Mon609NBomb,
                        Value = damage,
                        ExpireTime = Envir.Time + time + start,
                        TickSpeed = 3000,
                        CurrentLocation = new Point(x, y),
                        CastLocation = location,
                        Show = location.X == x && location.Y == y,
                        CurrentMap = CurrentMap,
                        Caster = this
                    };

                    DelayedAction action = new(DelayedType.Spawn, Envir.Time + start, ob);
                    CurrentMap.ActionList.Add(action);
                }
            }
        }
        public override void Die()
        {
            base.Die();
        }
    }
}