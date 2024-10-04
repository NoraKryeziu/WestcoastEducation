namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Courses courses = new Courses();
        Students students = new Students();
        Educators educators = new Educators();
        EducationalLeaders educationalLeaders = new EducationalLeaders();

        //Lägg till elever i listan med elever
        Students student;

        student = new Students();
        student.FindStudent("19980731-1223");
        students.AddStudent(student);

        student = new Students();
        student.FindStudent("19920519-2374");
        students.AddStudent(student);

        student = new Students();
        student.FindStudent("19950109-2664");
        students.AddStudent(student);

        student = new Students();
        student.FindStudent("19990421-2772");
        students.AddStudent(student);

        student = new Students();
        student.FindStudent("20000121-3165");
        students.AddStudent(student);
    
        Console.WriteLine("");
        
        Console.WriteLine("Studenter: ");
        students.ListAllStudents();

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

        //Lägg till kurser till listan med kurser
        Courses course;

        course = new Courses();
        course.FindCourse(121);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);
        //Lägg till kursen till ansvarig utbildningsledare...
        educationalLeader.AddResponsibleCourse(course);

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
        course.FindCourse(122);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);
        //Lägg till kursen till ansvarig utbildningsledare...
        educationalLeader.AddResponsibleCourse(course);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.FindCourse(123);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);
        //Lägg till kursen till ansvarig utbildningsledare...
        educationalLeader.AddResponsibleCourse(course);

        Console.WriteLine("");

        Console.WriteLine("Kurser: ");
        courses.ListAllCourses();

        Console.WriteLine("");
    
        Console.WriteLine("Lärare: ");
        educators.ListAll();

        Console.WriteLine("");

        Console.WriteLine("Utbildningsledare: ");
        educationalLeaders.ListAll();
    }
}






        