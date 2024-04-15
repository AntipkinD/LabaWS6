using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS6
{
    abstract class Transport
    {
        abstract protected double Speed { set; get; }
        abstract protected double LiftCapacity { set; get; }
        abstract protected double DistanceRange { set; get; }
        public abstract double GetSpeed();
        public abstract double GetLiftCapacity();
        public abstract double GetDistanceRange();
    }
    abstract class Automobile : Transport
    {
        protected override double Speed { set { Speed = 300; } }
        protected override double LiftCapacity { set => LiftCapacity = 200; }
        protected override double DistanceRange { set => DistanceRange = 1000; }
        override public double GetSpeed() { return this.Speed; }
        public override double GetLiftCapacity() { return this.LiftCapacity; }
        public override double GetDistanceRange() { return this.DistanceRange; }
    }
    abstract class Airplane : Transport
    {
        protected override double Speed { set { Speed = 111; } }
        protected override double LiftCapacity { set => LiftCapacity = 200; }
        protected override double DistanceRange { set => DistanceRange = 1000000; }
        override public double GetSpeed() { return this.Speed; }
        public override double GetLiftCapacity() { return this.LiftCapacity; }
        public override double GetDistanceRange() { return this.DistanceRange; }
    }
    abstract class Ship : Transport
    {
        protected override double Speed { set { Speed = 111; } }
        protected override double LiftCapacity { set => LiftCapacity = 1500; }
        protected override double DistanceRange { set => DistanceRange = 100000000; }
        override public double GetSpeed() { return this.Speed; }
        public override double GetLiftCapacity() { return this.LiftCapacity; }
        public override double GetDistanceRange() { return this.DistanceRange; }
    }
    class RealShip : Ship
    {
        protected override double Speed { set { Speed = 111; } get { return this.Speed; }
}
        protected override double LiftCapacity { set => LiftCapacity = 1500; }
        protected override double DistanceRange { set => DistanceRange = 100000000; }
    }
}
