using Session_05;

var resolver = new ActionResolver();
var response = new ActionResponse();
var request1 = new ActionRequest() {
    Input = "there is a light that never goes out ",
    Action = ActionEnum.Uppercase
};var request2 = new ActionRequest() {
    Input = "There is a house in New Orleans",
    Action = ActionEnum.Reverse
};var request3 = new ActionRequest() {
    Input = "64",
    Action = ActionEnum.Convert
};response = resolver.Excecute(request1);response = resolver.Excecute(request2);response = resolver.Excecute(request3);Console.Write(resolver.Logger.ReadAll());string s = null;