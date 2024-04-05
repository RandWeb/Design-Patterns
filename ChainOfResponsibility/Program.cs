
using ChainOfResponsiblity.UserInfoCheck;

var chain = new CheckUserName(new CheckPassword(new CheckUserNameAndPassword()));

var response = await chain.Handle(new RequestMessage("mehrdad","123456"));

Console.Write(response.Message);