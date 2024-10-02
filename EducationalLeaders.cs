namespace WestcoastEducation;

public class EducationalLeaders : Educators 
{
    /* PROPERTIES */
    public DateTime EmploymentDate { get; set; }

    /* CONSTRUCTOR */
    public EducationalLeaders(Courses courses) : base(courses)
    {
        
    }

    /* METHODS */
    public override string ToString()
    {
        return $"Anställningsdatum: {EmploymentDate}";
    }
}
