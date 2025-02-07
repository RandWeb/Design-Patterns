public sealed class NumberExpression(int number) : ExpressionBase
{
    private readonly int _number = number;

    public override int Interpret() => _number;
}
