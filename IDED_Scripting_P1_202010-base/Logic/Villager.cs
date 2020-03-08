using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    class Villager : Human
    {
        public Villager(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange,float _potential) 
            : base(_unitClass, _atk, _def, _spd, _moveRange, _potential)
        {
            this.AtkRange = 1;
            this.BaseAtkAdd = 0;
            this.BaseDefAdd = 0;
            this.BaseSpdAdd = 0;
        }
        public override bool Interact(EUnitClass eUnit)
        {
            return false;
        }
        public override bool ChangeClass(EUnitClass newClass)
        {
            return false;
        }
    }
}
