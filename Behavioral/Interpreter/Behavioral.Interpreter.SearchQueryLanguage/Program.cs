
List<string> context = ["hello","world","elephand","help"];

var wordExpression = new WordExpression(word:"hello");
var notExpression = new NotExpression(word:"hello");
var containsExpression = new ContainsExpression(str:"el");

var andExpression = new AndExpression(
    notExpression,
    containsExpression
    );
var result = andExpression.Interpret(context);

Console.ReadKey();
