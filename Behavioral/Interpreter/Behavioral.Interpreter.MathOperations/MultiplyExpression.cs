public sealed class MultiplyExpression(ExpressionBase left, ExpressionBase right) : ExpressionBase
{
    private readonly ExpressionBase _left = left;
    private readonly ExpressionBase _right = right;

    public override int Interpret() =>
        _left.Interpret() * _right.Interpret();

}
