using System.Security.Cryptography.X509Certificates;

namespace WestcoastEducation;

public class Employees : PersonalData
{
    /* PROPERTIES */
    public string? FieldOfStudy { get; set; } 
    public List<Educators> educators = [];
    public List<EducationalLeaders> educationalLeaders = [];
    public List<Administrators> administrators = [];
    
    //Aggregation...
    public List<Courses>ResponsibleCourses = [];

    /* METHODS */

    public void AddEducators(Educators educator)
    {
        educators.Add(educator);
    }
    public void AddEducationalLeader(EducationalLeaders educationalLeader)
    {
        educationalLeaders.Add(educationalLeader);
    }
    public void AddAdministrator(Administrators administrator)
    {
        administrators.Add(administrator);
    }

    
    public void AddResponsibleCourse(Courses course)
    {
        ResponsibleCourses.Add(course);
    }
    public virtual void Find(string socialSecurityNumber){}

    public void ListAllEducators()
    {
        foreach (var educator in educators)
        {
            Console.WriteLine(educator.ToString());
        }
    }
    public void ListAllEducationalLeaders()
    {
        foreach (var educationalLeader in educationalLeaders)
        {
            Console.WriteLine(educationalLeader.ToString());
        }
    }
    public void ListAllAdministrators(){
        foreach (var administrator in administrators)
        {
            Console.WriteLine(administrator.ToString());
        }
    }
        public override string ToString()
    {
        string responsibleCourses = ""; 
        foreach(var course in ResponsibleCourses)
        {
            if (responsibleCourses != "")
            {
                responsibleCourses += ", ";
            }
            responsibleCourses += course.Title;
        }
        return $"{base.ToString()} Kunskapsområde: {FieldOfStudy}, Ansvarig för kurserna: {responsibleCourses}";
    }

}
