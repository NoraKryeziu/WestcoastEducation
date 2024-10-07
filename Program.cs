namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Courses courses = new Courses();
        Students students = new Students();
        Educators educators = new Educators();
        EducationalLeaders educationalLeaders = new EducationalLeaders();
        Administrators administrators = new Administrators();
        Employees employees = new Employees();

        //Lägg till elever i listan med elever
        Students student;

        student = new Students();
        student.Find("19980731-1223");
        students.AddStudent(student);

        student = new Students();
        student.Find("19920519-2374");
        students.AddStudent(student);

        student = new Students();
        student.Find("19950109-2664");
        students.AddStudent(student);

        student = new Students();
        student.Find("19990421-2772");
        students.AddStudent(student);

        student = new Students();
        student.Find("20000121-3165");
        students.AddStudent(student);
        
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Studenter: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        students.ListAllStudents();

        //Lägg till lärare i listan för lärare
        Educators educator;
        educator = new Educators();
        educator.Find("19720814-1113");
        employees.AddEducators(educator);
        
        //Lägg till utbildningsledare i listan för utbildningsledare...
        EducationalLeaders educationalLeader;
        educationalLeader = new EducationalLeaders();
        educationalLeader.Find("19750630-3124");
        employees.AddEducationalLeader(educationalLeader);

        //Lägg till administratör i listan för administratör... 
        Administrators administrator;
        administrator = new Administrators();
        administrator.Find("19700222-6221");
        employees.AddAdministrator(administrator);

        //Lägg till kurser till listan med kurser
        Courses course;

        course = new Courses();
        course.Find(121);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare , utbildningsledare  och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);

        //Lägg till lärare i listan för lärare
        educator = new Educators();
        educator.Find("19681201-2279");
        employees.AddEducators(educator);

        //Lägg till utbildningsledare i listan för utbildningsledare...
        educationalLeader = new EducationalLeaders();
        educationalLeader.Find("19820313-5449");
        employees.AddEducationalLeader(educationalLeader);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.Find(122);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare, utbildningsledare och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.Find(123);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare, utbildningsledare och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nKurser: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        courses.ListAllCourses();


        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nLärare: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        employees.ListAllEducators();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\nUtbildningsledare: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        employees.ListAllEducationalLeaders();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nAdministratör:: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        employees.ListAllAdministrators();

    }
}






        