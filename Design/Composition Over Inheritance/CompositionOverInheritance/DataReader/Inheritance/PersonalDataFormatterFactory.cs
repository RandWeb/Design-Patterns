using CompositionOverInheritance.DataReader.Enums;

namespace CompositionOverInheritance.DataReader.Inheritance;

public class PersonalDataFormatterFactory
{
    public PersonalDataFormatter Create(TypeOfSource typeOfSource)
    {
        return typeOfSource switch
        {
            TypeOfSource.Excel => new ExcelSourcedPersonalData(),
            TypeOfSource.Database => new DatabaseSourcedPersonalData(),
            _ => throw new ArgumentException()
        };
    }
}
