using System;
using System.Collections.Generic;

namespace WebAPICRUD.Models;

public partial class Student
{
    public decimal? Id { get; set; }

    public string? StudentName { get; set; }

    public string? StudentGender { get; set; }

    public decimal? Age { get; set; }

    public decimal? Standard { get; set; }

    public string? FatherName { get; set; }
}
