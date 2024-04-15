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
        protected string MarkModel { set; get; } = "Лада Веста";
        protected override double Speed { set; get; } = 150;
        protected override double LiftCapacity { get; set; } = 100;
        protected override double DistanceRange { set; get; } = 450;
        override public double GetSpeed() { return Speed; }
        public override double GetLiftCapacity() { return LiftCapacity; }
        public override double GetDistanceRange() { return DistanceRange; }
    }
    abstract class Airplane : Transport
    {
        protected string Model { set; get; } = "ИЛ-52";
        protected override double Speed { set; get; } = 200;
        protected override double LiftCapacity { get; set; } = 1500;
        protected override double DistanceRange { set; get; } = 25000;
        override public double GetSpeed() { return Speed; }
        public override double GetLiftCapacity() { return LiftCapacity; }
        public override double GetDistanceRange() { return DistanceRange; }
    }
    abstract class Ship : Transport
    {
        protected string Name { set; get; } = "Непотопляемый";
        protected override double Speed { set; get; } = 100;
        protected override double LiftCapacity { get; set; } = 1500000;
        protected override double DistanceRange { set; get; } = 10000000;
        override public double GetSpeed() { return this.Speed; }
        public override double GetLiftCapacity() { return this.LiftCapacity; }
        public override double GetDistanceRange() { return this.DistanceRange; }
    }
    class RealShip : Ship
    {
        public string GetAllInfo()
        {
            return $"Корабль \"{Name}\" со скоростью {GetSpeed()} км/ч, с грузоподъемностью {GetLiftCapacity()} кг и с дальностью расстояния {GetDistanceRange()} км";
        }
    }
    class RealPlane : Airplane
    {
        public string GetAllInfo()
        {
            return $"Самолет \"{Model}\" со скоростью {GetSpeed()} км/ч, с грузоподъемностью {GetLiftCapacity()} кг и с дальностью расстояния {GetDistanceRange()} км";
        }
    }
    class RealAuto : Automobile
    {
        public string GetAllInfo()
        {
            return $"Автомобиль \"{MarkModel}\" со скоростью {GetSpeed()} км/ч, с грузоподъемностью {GetLiftCapacity()} кг и с дальностью расстояния {GetDistanceRange()} км";
        }
    }
}
