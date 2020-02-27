namespace IDED_Scripting_P1_202010_base.Logic
{
    public class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential, int _atkRange)
            : base(_unitClass, _atk, _def, _spd, _moveRange, _atkRange)
        {
            Potential = _potential;
        }


        public virtual bool ChangeClass(EUnitClass newClass)
        {
            return false;
        }


        public EUnitClass PlayerType
        {
            get => PlayerType;
            protected set
            {
                if (!value.Equals(EUnitClass.Villager))
                {
                    PlayerType= value;
                }
            }
        }


    }
}