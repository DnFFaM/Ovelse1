Student Alexander = new Student(1);
Person Alexander1 = new Person("Alexander", "K. H. Runge", new DateTime(2010, 10, 19));
Student Amanda = new Student(2);
Person Amanda1 = new Person("Amanda", "V. Gudmand", new DateTime(1999, 9, 19));
Student Dennis = new Student(3);
Person Dennis1 = new Person("Dennis", "D. B. Paaske", new DateTime(1971, 4, 29));
Student Ozan = new Student(4);
Person Ozan1 = new Person("Ozan", "Korkmaz", new DateTime(1998, 6, 1));
Student Camilla = new Student(5);
Person Camilla1 = new Person("Camilla", "Kløjgaard", new DateTime(1990, 12, 10));

Lærer Niels = new Lærer("IT");
Person Niels1 = new Person("Niels", "Olesen", new DateTime(1980, 1, 1));

Course OOP = new Course("OOP", Niels);
Course Grundl = new Course("Grundlæggende programmering", Niels);
Course StudieTeknik = new Course("Studieteknik", Niels);

List<Enrollment> _enrollments = new List<Enrollment>()
{
    new Enrollment(Alexander,Alexander1, OOP),
    new Enrollment(Alexander,Alexander1, Grundl),
    new Enrollment(Alexander,Alexander1,StudieTeknik),
    new Enrollment(Amanda,Amanda1, OOP),
    new Enrollment(Amanda,Amanda1, Grundl),
    new Enrollment(Amanda,Amanda1, StudieTeknik),
    new Enrollment(Dennis,Dennis1, OOP),
    new Enrollment(Dennis,Dennis1, Grundl),
    new Enrollment(Dennis,Dennis1, StudieTeknik),
    new Enrollment(Ozan,Ozan1, OOP),
    new Enrollment(Ozan,Ozan1, Grundl),
    new Enrollment(Camilla,Camilla1, OOP),
    new Enrollment(Camilla,Camilla1, Grundl)

};

foreach (var item in _enrollments)
{
    Console.WriteLine(item.StudentInfo.FirstName + " " + item.StudentInfo.LastName + " i " + item.CourseInfo.CourseName + " by " + item.CourseInfo.TeacherInfo.FirstName + " " + item.CourseInfo.TeacherInfo.LastName);
}
{

}




Console.WriteLine();