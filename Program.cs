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

//foreach (var item in enrollments)
//{
//    Console.WriteLine(item.StudentInfo.FirstName + " " + item.StudentInfo.LastName + " i " + item.CourseInfo.CourseName + " by " + item.CourseInfo.TeacherInfo.FirstName + " " + item.CourseInfo.TeacherInfo.LastName);
//}
//{

//}

List<Enrollment> enrollments2 = new List<Enrollment>()
{
    new Enrollment(Amanda, OOP),
    new Enrollment(Amanda, Grundl),
    new Enrollment(Amanda, StudieTeknik),
    new Enrollment(Alexander, OOP),
    new Enrollment(Alexander, Grundl),
    new Enrollment(Alexander, StudieTeknik)
};

Console.WriteLine("Poly\n-------------");
foreach (var item in enrollments2)
{
    Console.WriteLine(item);
}






string? firstName;
string? lastName;
string? dateOfBirth;
string? course;
bool moreCourses = true;
string? addStudent;
int studentID;
bool Input = true;

do
{
    while (Input)
    {
        Console.WriteLine("1) Add a student to a Course");
        Console.Write("\nChoose 1: ");

        string? userInput = Console.ReadLine();
        if (userInput != "1")
        {
            Console.WriteLine("Please choose one of the Options.");
            Console.ReadKey();
            Console.Clear();
        }
        else
            Input = false;
    }

    Console.Clear();
    Console.Write("Give Student ID: ");
    while (!int.TryParse(Console.ReadLine(), out studentID))
    {

        Console.WriteLine("Error: Write a number not a letter.");
        Console.ReadKey();
        Console.Clear();
        Console.Write("Give Student ID: ");

    }
    Console.Write("Student First Name: ");
    firstName = Console.ReadLine();

    Console.Write("Student Last Name: ");
    lastName = Console.ReadLine();

    Console.Write("Student Date of Birth: ");
    dateOfBirth = Console.ReadLine();

};