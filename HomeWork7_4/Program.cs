using Decorator;

var christmasTree = new ChristmasTree();

var ornamentDecorator = new OrnamentDecorator();
ornamentDecorator.SetTree(christmasTree);

var garlandDecorator = new GarlandDecorator();
garlandDecorator.SetTree(ornamentDecorator);

var starDecorator = new StarDecorator();
starDecorator.SetTree(garlandDecorator);

starDecorator.Display();

Console.ReadKey();
