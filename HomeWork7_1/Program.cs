﻿using System;
using AbstractFactory;

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