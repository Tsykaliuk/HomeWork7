using FactoryMethod;

MessageFactory emailFactory = new EmailFactory();
MessageFactory smsFactory = new SMSFactory();
MessageFactory viberFactory = new ViberFactory();

Message email = emailFactory.CreateMessage();
email.Send();

Message sms = smsFactory.CreateMessage();
sms.Send();

Message push = viberFactory.CreateMessage();
push.Send();

Console.ReadKey();
