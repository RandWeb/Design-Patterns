




public sealed class ContainsExpression(string str) : ExpressionBase
{
    private readonly string _str = str;

    public override List<string> Interpret(List<string> words) => words.Where(w=> w.Contains(_str, StringComparison.OrdinalIgnoreCase)).ToList();
}
