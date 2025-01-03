﻿using SeedData;
using UserSearch.common;

namespace UserSearch.Specifications;

public class NameStudentFilterSpecification(string name) : ISpecification<Student>
{
    public bool IsSatisfiedBy(Student entity) => entity.FirstName.StartsWith(name, StringComparison.OrdinalIgnoreCase);
}