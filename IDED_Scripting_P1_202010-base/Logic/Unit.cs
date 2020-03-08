namespace IDED_Scripting_P1_202010_base.Logic
{
    public abstract class Unit      
    {
       
       
        public float BaseAtk { get; protected set; }
        public float BaseDef { get; protected set; }
        public float BaseSpd { get; protected set; }
        public float BaseAtkAdd { get; protected set; }
        public float BaseDefAdd { get; protected set; }
        public float BaseSpdAdd { get; protected set; }
        public int MoveRange { get; protected set; }
        public int AtkRange { get; protected set; }
        public float Attack { get; protected set; }
        public float Defense { get; protected set; }
        public float Speed { get; protected set; }

        protected Position CurrentPosition;

        public EUnitClass UnitClass { get; protected set; }

        public Unit(EUnitClass _unitClass, int _atk, int _def, int _spd, int _moveRange)
        {
            UnitClass = _unitClass;
            BaseAtk = _atk;
            BaseDef = _def;
            BaseSpd = _spd;
            MoveRange = _moveRange;
        }
        public abstract bool Interact(EUnitClass eUnit);

        public bool Move(Position targetPosition)
        {
            if (targetPosition.positionX - this.CurrentPosition.positionX <= MoveRange)
            {
                if (targetPosition.positionY - this.CurrentPosition.positionY <= MoveRange)
                {
                    this.CurrentPosition.positionX = targetPosition.positionX;
                    this.CurrentPosition.positionY = targetPosition.positionY;
                    return true;
                }
            }
            return false;
        }

        public void AtkAdd()
        {
            this.Attack = this.BaseAtk + (this.BaseAtk * (BaseAtkAdd / 100));
            if (this.Attack <= 250) {
                this.BaseAtk = this.Attack;
            }
            else
            {
                this.Attack= this.BaseAtk;
            }
            
        }
        public void DefAdd()
        {
            this.Defense = this.BaseDef + (this.BaseDef * (BaseDef / 100));
            if (this.Defense <= 250)
            {
                this.BaseDef = this.Defense;
            }
            else
            {
                this.Defense = this.BaseDef;
            }
        }
        public void SpdAdd()
        {
            this.Speed = this.BaseSpd + (this.BaseSpd * (BaseSpd / 100));
            if (this.Defense <= 250)
            {
                this.BaseSpd = this.Speed;
            }
            else
            {
                this.Speed = this.BaseSpd;
            }

        }
    }
}