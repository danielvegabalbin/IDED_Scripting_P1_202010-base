namespace IDED_Scripting_P1_202010_base.Logic
{
    public abstract class Human : Unit
    {
        public float Potential { get; set; }

        public Human(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange, float _potential)
            : base(_unitClass, _atk, _def, _spd, _moveRange)
        {
            if (_potential <= (_atk * 0.1) && _potential <= (_def * 0.1))
            {
                Potential = _potential;
            }
            else
            {
                Potential = 0;
            }
        }
        public virtual bool Interact(Prop prop) => true;
        
        public override bool Interact(EUnitClass eUnit)
        {
            throw new System.NotImplementedException();
        }

        public abstract bool ChangeClass(EUnitClass newClass);

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