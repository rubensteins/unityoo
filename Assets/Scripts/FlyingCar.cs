namespace DefaultNamespace
{
    // POLYMORPHISM
    public class FlyingCar : Vehicle, IDriver, IFlyer
    {
        public FlyingCar()
        {
            this.MaxSpeed = 500;
        }

        public override void Move()
        {
            // it can move
        }

        public void Drive()
        {
            // it can drive
        }

        public void Fly()
        {
            // it can fly
        }
    }
}