using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    class Orc : Unit
    {
        public Orc(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) 
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            this.AtkRange = 1;
            this.BaseAtkAdd = 4;
            this.BaseDefAdd = 2;
            this.BaseSpdAdd = -2;
        }
        public override bool Interact(EUnitClass eUnit)
        {
            bool interaction = false;
            switch (eUnit)
            {
                case EUnitClass.Villager:
                    interaction = true;
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
                    interaction = false;
                    break;
            }
            return interaction;
        }
    }
}
