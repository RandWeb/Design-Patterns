using CompositionOverInheritance.DataReader.Enums;
using CompositionOverInheritance.DataReader.Inheritance;

namespace CompositionOverInheritance;

public class Samples
{

    public static void DataReader()
    {
        // inheritance
        /*Console.WriteLine("Inheritance");
         PersonalDataFormatterFactory factory = new();

          var excelFormater = factory.Create(TypeOfSource.Excel);
          Console.WriteLine(excelFormater.Format());
          Console.WriteLine();
          var databaseFormater = factory.Create(TypeOfSource.Database);
          Console.WriteLine(databaseFormater.Format());*/

        // Composition
        Console.WriteLine("Composition");
        DataReader.Composition.PersonalDataFormatterFactory factory = new();
        var excelFormater = factory.Create(TypeOfSource.Excel);
        Console.WriteLine(excelFormater.Format());
        Console.WriteLine();
        var databaseFormater = factory.Create(TypeOfSource.Database);
        Console.WriteLine(databaseFormater.Format());
        Console.ReadKey();
    }
}
