





public sealed class AndExpression(ExpressionBase left, ExpressionBase right) : ExpressionBase
{
    private ExpressionBase _left = left;
    private ExpressionBase _right = right;
    public override List<string> Interpret(List<string> words)=> _left.Interpret(words).Intersect(_right.Interpret(words)).ToList();
}
