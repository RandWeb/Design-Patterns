namespace UserSearch.common;

public interface ISpecification<T>
{
   bool IsSatisfiedBy(T entity);
}