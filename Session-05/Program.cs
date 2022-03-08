using Session_05;

//ActionEnum aE = ActionEnum.Convert;

var mes1 = new Message
{
    Text = "This is the first message!"
};

var mes2 = new Message
{
    Text = "This is the second message!!"
};

var mesLogger = new MessageLogger();

mesLogger.Write(mes1);
mesLogger.Write(mes2);

Console.WriteLine(mesLogger.ReadAll());