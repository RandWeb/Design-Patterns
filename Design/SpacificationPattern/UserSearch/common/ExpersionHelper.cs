using System.Linq.Expressions;

namespace UserSearch.common;

public class ExpressionHelper
{
    private static Expression<Func<T, bool>> And<T>(Expression<Func<T, bool>> expression1,
        Expression<Func<T, bool>> expression2)
    {
        var parameterExpr = Expression.Parameter(typeof(T));
        var expr = Expression.AndAlso(expression1.Body, expression2.Body);
        expr = (BinaryExpression) new ParamReplacer(parameterExpr).Visit(expr);
        var expression = Expression.Lambda<Func<T, bool>>(expr, parameterExpr);
        return expression;
    }  
    
    private static Expression<Func<T, bool>> Or<T>(Expression<Func<T, bool>> expression1,
        Expression<Func<T, bool>> expression2)
    {
        var parameterExpr = Expression.Parameter(typeof(T));
        var expr = Expression.Or(expression1.Body, expression2.Body);
        expr = (BinaryExpression) new ParamReplacer(parameterExpr).Visit(expr);
        var expression = Expression.Lambda<Func<T, bool>>(expr, parameterExpr);
        return expression;
    }
    
    public static Expression<Func<T, bool>> Expressions<T>(params KeyValuePair<TypeOfExpression,Expression<Func<T, bool>>>[] expressions)
    {
        Expression<Func<T, bool>> expression = s => true;
        foreach (var item in expressions)
        {
            if (item.Value == null) continue;
            expression = item.Key is TypeOfExpression ? Or(expression,item.Value):And(expression, item.Value);
        }

        return expression;
    }
}

public class ParamReplacer : ExpressionVisitor
{
    private ParameterExpression ParameterExpression;

    public ParamReplacer(ParameterExpression parameterExpression)
    {
        ParameterExpression = parameterExpression;
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        return base.VisitParameter(ParameterExpression);
    }
}

public enum TypeOfExpression{
    AND,
    OR
}