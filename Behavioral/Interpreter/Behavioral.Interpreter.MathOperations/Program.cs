
// 1 + 2 * 3

var expression = new SumExpression(
    new NumberExpression(1),
    new MultiplyExpression(
        new NumberExpression(2),
        new NumberExpression(3)
        )
    );

var result = expression.Interpret();
Console.ReadKey();
