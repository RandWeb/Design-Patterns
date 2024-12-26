using SeedData;
using SeedData.Helper;
using UserSearch.Specifications;

var students = SampleCollections.Students;
NameStudentFilterSpecification filter = new("mehr");
var result = students.Where(p => filter.IsSatisfiedBy(p));

result.Print();