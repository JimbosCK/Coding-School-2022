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
var request1 = new ActionRequest(){
    Input ="This is a great day to go outside my friend! ",
    Action =ActionEnum.Uppercase
};var request2 = new ActionRequest()
{
    Input = "This is a great day to go outside my friend! ",
    Action = ActionEnum.Reverse
};var request3 = new ActionRequest()
{
    Input = "5",
    Action = ActionEnum.Convert
};response = resolver.Excecute(request1);response = resolver.Excecute(request2);response = resolver.Excecute(request3);Console.Write(resolver.Logger.ReadAll());