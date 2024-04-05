
using Behavioral.ChainOfResponsibility.CheckUsers.UserInfoCheck;

var chain = new CheckUserName(new CheckPassword(new CheckUserNameAndPassword()));

var response = await chain.HandleAsync(new RequestMessage("mehrdad","123456"));

Console.Write(response.Message);