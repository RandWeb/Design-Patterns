using SeedData;
using SeedData.Helper;
using UserSearch.Spacifications;

var students = SampleCollections.Students;
NameStudentFilterSpecification filter = new("mehr");
var result = students.Where(p => filter.IsSatisfiedBy(p));

result.Print();