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
var request = new ActionRequest(){
    Input ="This is a great day to go outside my friend! ",
    Action =ActionEnum.Uppercase
};response = resolver.Excecute(request);Console.Write(resolver.Logger.ReadAll());