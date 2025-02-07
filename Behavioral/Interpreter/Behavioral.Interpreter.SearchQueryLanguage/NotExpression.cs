



public sealed class NotExpression(string word) : ExpressionBase
{
    private readonly string _word = word;

    public override List<string> Interpret(List<string> words)=> words.Where(w=>!w.Equals(_word,StringComparison.OrdinalIgnoreCase)).ToList();
}
