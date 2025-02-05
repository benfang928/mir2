﻿using Server.MirDatabase;
using Server.MirEnvir;
using S = ServerPackets;

namespace Server.MirObjects.Monsters
{
    public class ArmadilloElder : Armadillo
    {
        protected internal ArmadilloElder(MonsterInfo info)
            : base(info)
        {
        }

        protected override void Attack()
        {
            if (!Target.IsAttackTarget(this))
            {
                Target = null;
                return;
            }

            ShockTime = 0;

            Direction = Functions.DirectionFromPoint(CurrentLocation, Target.CurrentLocation);

            ActionTime = Envir.Time + 300;
            AttackTime = Envir.Time + AttackSpeed;

            switch (Envir.Random.Next(0, 6))
            {
                case 0:
                    {
                        Retreat();
                        _runAway = true;
                    }
                    break;
                case 1:
                    {
                        Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation, Type = 1 });
                        int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击]);
                        if (damage == 0) return;

                        Target.Pushed(this, Direction, 2);
                    }
                    break;
                default:
                    {
                        Broadcast(new S.ObjectAttack { ObjectID = ObjectID, Direction = Direction, Location = CurrentLocation });
                        int damage = GetAttackPower(Stats[Stat.最小攻击], Stats[Stat.最大攻击]) * 2;
                        if (damage == 0) return;

                        DelayedAction action = new DelayedAction(DelayedType.Damage, Envir.Time + 400, Target, damage, DefenceType.ACAgility);
                        ActionList.Add(action);
                    }
                    break;
            }
        }

        protected override void CompleteRangeAttack(IList<object> data)
        {

        }
    }
}
