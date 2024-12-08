﻿using System;

namespace HomeWork7_1;
public class AbstractFactory
{
    // AbstractProductA
    abstract class Car
    {
        public abstract void Info();
    }
    // ConcreteProductA1
    class Ford : Car
    {
        public override void Info()
        {
            Console.WriteLine("Ford");
        }
    }
    //ConcreteProductA2
    class Toyota : Car
    {
        public override void Info()
        {
            Console.WriteLine("Toyota");
        }
    }
    //ConcreteProductA3
    class Mersedes : Car
    {
        public override void Info()
        {
            Console.WriteLine("Mersedes");
        }
    }
    // AbstractProductB
    abstract class Engine
    {
        public virtual void GetPower()
        {
        }
    }
    // ConcreteProductB1
    class FordEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Ford Engine 4.4");
        }
    }
    //ConcreteProductB2
    class ToyotaEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Toyota Engine 3.2");
        }
    }
    //ConcreteProductB3
    class MersedesEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Mersedes Engine 5.0");
        }
    }
    // Mersedes
    interface ICarFactory
    {
        Car CreateCar();
        Engine CreateEngine();
    }
    // ConcreteFactory1
    class FordFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Ford();
        }
        Engine ICarFactory.CreateEngine()
        {
            return new FordEngine();
        }
    }
    // ConcreteFactory2
    class ToyotaFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Toyota();
        }
        Engine ICarFactory.CreateEngine()
        {
            return new ToyotaEngine();
        }
    }
    // ConcreteFactory3
    class MersedesFactory : ICarFactory
    {
        // from CarFactory
        Car ICarFactory.CreateCar()
        {
            return new Mersedes();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new MersedesEngine();
        }
    }
}