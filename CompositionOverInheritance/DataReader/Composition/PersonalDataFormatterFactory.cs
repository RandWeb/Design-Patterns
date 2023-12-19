using CompositionOverInheritance.DataReader.Enums;

namespace CompositionOverInheritance.DataReader.Composition;

public class PersonalDataFormatterFactory
{

    public PersonalDataFormatter Create(TypeOfSource typeOfSource)
    {
        return typeOfSource switch
        {
            TypeOfSource.Excel => new PersonalDataFormatter(new ExcelSourcedPersonelData()),
            TypeOfSource.Database => new PersonalDataFormatter(new DatabaseSoursedPersonalData()),
            _ => throw new ArgumentException(),
        };
    }
}
