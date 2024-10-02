namespace WestcoastEducation;

class Program
{
    static void Main(string[] args)
    {
        Courses courses = new Courses();
        Students students = new Students();
        Educators educators = new Educators();

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
        educator.FindEducator("19720814-1113");
        educators.AddEducator(educator);

        //Lägg till kurser till listan med kurser
        Courses course;

        course = new Courses();
        course.FindCourse(121);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);

        //Lägg till lärare i listan för lärare
        educator = new Educators();
        educator.FindEducator("19681201-2279");
        educators.AddEducator(educator);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.FindCourse(122);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);

        //Lägg till kurser till listan med kurser
        course = new Courses();
        course.FindCourse(123);
        courses.AddCourse(course);

        //Lägg till kursen till ansvarig lärare...
        educator.AddResponsibleCourse(course);

        Console.WriteLine("");

        Console.WriteLine("Alla kurser: ");
        courses.ListAllCourses();

        Console.WriteLine("");
    
        Console.WriteLine("Lärare: ");
        educators.ListAllEducators();
    }
}
