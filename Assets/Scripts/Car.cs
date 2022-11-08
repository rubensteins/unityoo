namespace DefaultNamespace
{
    // INHERITANCE
    public class Car : Vehicle, IDriver
    {
        public Car()
        {
            this.MaxSpeed = 200.0f;  // obvi a gross oversimplification.
        }

        public override void Move()
        {
            // this is where car movement logic would go.
        }

        public void Drive()
        {
            // and cars can obviously drive
        }
    }
}