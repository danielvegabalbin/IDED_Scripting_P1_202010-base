﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    class Squire : Human
    {
        public Squire(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange,float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange, _potential)
        {
            this.AtkRange = 1;
            this.BaseAtkAdd = 2;
            this.BaseDefAdd = 1;
            this.BaseSpdAdd = 0;
        }
        public override bool Interact(EUnitClass eUnit)
        {
            bool interaction=false;
            switch (eUnit)
            {
                case EUnitClass.Villager:
                    interaction = false;
                    break;
                case EUnitClass.Squire:
                    interaction = true;
                    break;
                case EUnitClass.Soldier:
                    interaction = true;
                    break;
                case EUnitClass.Ranger:
                    interaction = true;
                    break;
                case EUnitClass.Mage:
                    interaction = true;
                    break;
                case EUnitClass.Imp:
                    interaction = true;
                    break;
                case EUnitClass.Orc:
                    interaction = true;
                    break;
                case EUnitClass.Dragon:
                    interaction = true;
                    break;
            }
            return interaction;
        }
        public override bool ChangeClass(EUnitClass newClass)
        {
            if (newClass == EUnitClass.Soldier)
            {
                this.UnitClass = newClass;
                return true;
            }
            return false;
        }
    }
}
