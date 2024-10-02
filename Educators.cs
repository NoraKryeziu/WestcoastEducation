namespace WestcoastEducation;

public class Educators : PersonalData 
{
    /* PROPERTIES */
    public string FieldOfStudy { get; set; } = ""; 

    public List<Educators> educators = [];

    public List<Courses>ResponsibleCourses { get; set; } = new List<Courses>();
    

    /* CONSTRUCTOR */
    public Educators()
    {
    }

    public Educators(Courses courses)
    {
        Courses Courses = courses;
    }
   

    /* METHODS */
    public void FindEducator(string SocialSecurityNumber)
    {
        if(SocialSecurityNumber == "19720814-1113")
        {
            SocialSecurityNumber = "19720814-1113";
            FirstName = "Thomas";
            Surname = "Andersson";
            Phone = "070-1138880";
            Address = "Brogatan 38";
            PostalCode = "412 12";
            City = "Göteborg";
            FieldOfStudy = "Organisation och ledarskap";

        } else if(SocialSecurityNumber == "19681201-2279")
        {
            SocialSecurityNumber = "19681201-2279";
            FirstName = "Martin";
            Surname = "Olofsson";
            Phone = "072-3114770";
            Address = "Västra Långatan 19";
            PostalCode = "411 18";
            City = "Göteborg";
            FieldOfStudy = "Systemutveckling";
            

        }
    }
    public void AddEducator(Educators educator)
    {
        educators.Add(educator);
    }
    public void ListAllEducators()
    {
        foreach (var educator in educators)
        {
            Console.WriteLine(educator.ToString());
        }
    }

    public void AddResponsibleCourse(Courses course)
    {
        ResponsibleCourses.Add(course);
    }
    public override string ToString()
    {
        string responsibleCoursesString = ""; 
        foreach(var course in ResponsibleCourses)
        {
            if (responsibleCoursesString != "")
            {
                responsibleCoursesString += ", ";
            }
            responsibleCoursesString += course.Title;
        }
        return $"{base.ToString()} Kunskapsområde: {FieldOfStudy}, Ansvarig för kurserna: {responsibleCoursesString}";
    }
}

