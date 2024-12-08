using System;
using System.Runtime.ConstrainedExecution;

using HomeWork7.1;

ICarFactory carFactory = new ToyotaFactory();
Car myCar = carFactory.CreateCar();
myCar.Info();

        Engine myEngine = carFactory.CreateEngine();
myEngine.GetPower();

        carFactory = new FordFactory();
myCar = carFactory.CreateCar();
        myCar.Info();

        myEngine = carFactory.CreateEngine();
        myEngine.GetPower();

        carFactory = new MersedesFactory();
myCar = carFactory.CreateCar();
        myCar.Info();

        myEngine = carFactory.CreateEngine();
        myEngine.GetPower();

        Console.ReadKey();