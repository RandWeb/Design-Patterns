namespace Design.DependencyInjection.Data;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FullName { get; set; } = default!;

    public static bool operator ==(User left, User right) => left.Id.Equals(right.Id) && right.FullName.Equals(left.FullName);
    public static bool operator !=(User left, User right) => !left.Id.Equals(right.Id) || !right.FullName.Equals(left.FullName);
}