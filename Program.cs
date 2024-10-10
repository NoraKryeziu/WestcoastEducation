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
    
        //Lägg till elever i listan med elever
        Students student;

        student = new Students();
        student.Find("19980731-1223");
        students.Add(student);

        student = new Students();
        student.Find("19920519-2374");
        students.Add(student);

        student = new Students();
        student.Find("19950109-2664");
        students.Add(student);

        student = new Students();
        student.Find("19990421-2772");
        students.Add(student);

        student = new Students();
        student.Find("20000121-3165");
        students.Add(student);
        
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Studenter: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        students.ListAll();

        //Lägg till lärare i listan för lärare
        Educators educator;
        educator = new Educators();
        educator.Find("19720814-1113");
        educators.Add(educator);
        
        //Lägg till utbildningsledare i listan för utbildningsledare...
        EducationalLeaders educationalLeader;
        educationalLeader = new EducationalLeaders();
        educationalLeader.Find("19750630-3124");
        educationalLeaders.Add(educationalLeader);

        //Lägg till administratör i listan för administratör... 
        Administrators administrator;
        administrator = new Administrators();
        administrator.Find("19700222-6221");
        administrators.Add(administrator);

        //Lägg till kurser till listan med kurser
        Courses course;

        course = new Courses();
        course.Find(121);
        courses.Add(course);

        //Lägg till kursen till ansvarig lärare , utbildningsledare  och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);

        //Lägg till lärare i listan för lärare
        educator = new Educators();
        educator.Find("19681201-2279");
        educators.Add(educator);

        //Lägg till utbildningsledare i listan för utbildningsledare...
        educationalLeader = new EducationalLeaders();
        educationalLeader.Find("19820313-5449");
        educationalLeaders.Add(educationalLeader);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.Find(122);
        courses.Add(course);


        //Lägg till kursen till ansvarig lärare, utbildningsledare och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.Find(123);
        courses.Add(course);


        //Lägg till kursen till ansvarig lärare, utbildningsledare och administratör...
        educator.AddResponsibleCourse(course);
        educationalLeader.AddResponsibleCourse(course);
        administrator.AddResponsibleCourse(course);
    
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\nKurser: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        courses.ListAll();

        /* Json utskrift */
        var path = string.Concat(Environment.CurrentDirectory + "/Data/courses.json");
        Json.WriteJson(path,courses.courseList);

        var coursesFromFile = Json.ReadJson(path);            
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("***************************");
        Console.WriteLine("JSON");
        Console.WriteLine("Kurser:");

        foreach(var jsonCourses in coursesFromFile)
        {
            Console.WriteLine("");
            Console.WriteLine(jsonCourses);

        }
        Console.WriteLine("*****************************");
        /* ***************************** */


        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nLärare: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        educators.ListAll();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\nUtbildningsledare: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        educationalLeaders.ListAll();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nAdministratör:: ");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
        administrators.ListAll();

    }
}






        