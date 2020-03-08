using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDED_Scripting_P1_202010_base.Logic
{
    class Dragon : Unit
    {
        public Dragon(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange) 
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            this.AtkRange = 5;
            this.BaseAtkAdd = 5;
            this.BaseDefAdd = 3;
            this.BaseSpdAdd = 2;
        }
        public override bool Interact(EUnitClass eUnit)
        {
            return true;
        }
    }
}
