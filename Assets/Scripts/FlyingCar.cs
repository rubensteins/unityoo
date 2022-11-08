namespace DefaultNamespace
{

    public class FlyingCar : Vehicle, IDriver, IFlyer
    {
        public FlyingCar()
        {
            this.MaxSpeed = 500;
        }

        public override void Move()
        {
            CalculateSpeed();
            // it can move
            Drive();
            Fly();
        }

        public void Drive()
        {
            // it can drive
        }

        public void Fly()
        {
            // it can fly
        }

        // ENCAPSULATION
        private float CalculateSpeed()
        {
            return MaxSpeed - 10; // warning: top-secret algorith!
        }
    }
}