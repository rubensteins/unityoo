namespace DefaultNamespace
{
    public class Airplane : Vehicle, IFlyer
    {
        public Airplane()
        {
            this.MaxSpeed = 1000.0f;
        }

        public override void Move()
        {
            // this is where plane movement logic would go.
        }

        public void Fly()
        {
            // planes can fly!!
        }
    }
}