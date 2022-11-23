Student Alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(2010, 10, 19));
Student Amanda = new Student(2, "Amanda", "V. Gudmand", new DateTime(1999, 9, 19));
Student Dennis = new Student(3, "Dennis", "D. B. Paaske", new DateTime(1971, 4, 29));
Student Ozan = new Student(4, "Ozan", "Korkmaz", new DateTime(1998, 6, 1));
Student Camilla = new Student(5, "Camilla", "Kløjgaard", new DateTime(1990, 12, 10));

Lærer Niels = new Lærer("IT", "Niels", "Olesen", new DateTime(1980, 1, 1));

Course OOP = new Course("OOP", Niels);
Course Grundl = new Course("Grundlæggende programmering", Niels);
Course StudieTeknik = new Course("Studieteknik", Niels);

List<Enrollment> enrollments = new List<Enrollment>()
{
    new Enrollment(Alexander, OOP),
    new Enrollment(Alexander, Grundl),
    new Enrollment(Alexander,StudieTeknik),
    new Enrollment(Amanda, OOP),
    new Enrollment(Amanda, Grundl),
    new Enrollment(Amanda, StudieTeknik),
    new Enrollment(Dennis, OOP),
    new Enrollment(Dennis, Grundl),
    new Enrollment(Dennis, StudieTeknik),
    new Enrollment(Ozan, OOP),
    new Enrollment(Ozan, Grundl),
    new Enrollment(Camilla, OOP),
    new Enrollment(Camilla, Grundl)

};

foreach (var item in enrollments)
{
    Console.WriteLine(item.StudentInfo.FirstName + " " + item.StudentInfo.LastName + " i " + item.CourseInfo.CourseName + " by " + item.CourseInfo.TeacherInfo.FirstName + " " + item.CourseInfo.TeacherInfo.LastName);
}
{

}




Console.WriteLine();