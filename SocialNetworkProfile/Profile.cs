// See https://aka.ms/new-console-template for more information


public record Profile(string Name, string Email, TypeOfGender Gender)
{
    public override string ToString()
    {
        return $"name : {Name}, email : {Email}, Gender:{(Gender is TypeOfGender.Male ? "Male" : "Female")}";
    }
}

