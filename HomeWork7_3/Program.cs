using Mediator;

var mediator = new ConcreteMediator();

var colleague1 = new ConcreteColleague1(mediator);
var colleague2 = new ConcreteColleague2(mediator);
var colleague3 = new ConcreteColleague3(mediator);

mediator.Colleague1 = colleague1;
mediator.Colleague2 = colleague2;
mediator.Colleague3 = colleague3;

mediator.Send("How are you?", colleague1);
mediator.Send("Fine, thanks", colleague2);
mediator.Send("Hello!", colleague3);

Console.ReadKey();
