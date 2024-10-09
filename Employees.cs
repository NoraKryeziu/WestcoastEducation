namespace WestcoastEducation;

public class Employees : PersonalData , IManage
{
    /* PROPERTIES */
    public string? FieldOfStudy { get; set; } 
    
    //Aggregation...
    public List<Courses>ResponsibleCourses = [];

    /* METHODS */
    
    public void AddResponsibleCourse(Courses course)
    {
        ResponsibleCourses.Add(course);
    }
    public virtual void Find(string socialSecurityNumber){}

    public virtual void ListAll(){}
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
