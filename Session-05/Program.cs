using Session_05;

//ActionEnum aE = ActionEnum.Convert;

//var mes1 = new Message
//{
//    Text = "This is the first message!"
//};

//var mes2 = new Message
//{
//    Text = "This is the second message!!"
//};

//var mesLogger = new MessageLogger();

//mesLogger.Write(mes1);
//mesLogger.Write(mes2);

//Console.WriteLine(mesLogger.ReadAll());


var resolver = new ActionResolver();
var response = new ActionResponse();
var request1 = new ActionRequest() {
    Input = null,
    Action =ActionEnum.Uppercase
};var request2 = new ActionRequest()
{
    Input = "",
    Action = ActionEnum.Reverse
};var request3 = new ActionRequest()
{
    Input = "",
    Action = ActionEnum.Convert
};var request0 = new ActionRequest()
{
    Input = "",
    Action = ActionEnum.Bad
};response = resolver.Excecute(request1);response = resolver.Excecute(request2);response = resolver.Excecute(request3);response = resolver.Excecute(request0);Console.Write(resolver.Logger.ReadAll());