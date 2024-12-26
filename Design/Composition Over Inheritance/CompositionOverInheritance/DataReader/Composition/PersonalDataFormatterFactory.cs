using CompositionOverInheritance.DataReader.Enums;

namespace CompositionOverInheritance.DataReader.Composition;

public class PersonalDataFormatterFactory
{

    public PersonalDataFormatter Create(TypeOfSource typeOfSource)
    {
        return typeOfSource switch
        {
            TypeOfSource.Excel => new PersonalDataFormatter(new ExcelSourcedPersonalData()),
            TypeOfSource.Database => new PersonalDataFormatter(new DatabaseSourcedPersonalData()),
            _ => throw new ArgumentException(),
        };
    }
}
