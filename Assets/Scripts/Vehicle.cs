namespace DefaultNamespace
{
    public abstract class Vehicle
    {
        public float MaxSpeed { get; set; }

        /// <summary>
        /// Each vehicle can move (somehow) or it's not much of a vehicle.
        /// </summary>
        public abstract void Move();
    }
}