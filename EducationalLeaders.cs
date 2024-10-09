namespace WestcoastEducation;

public class EducationalLeaders : Educators , IManage
{
    /* PROPERTIES */
    public DateTime EmploymentDate { get; set; } 
    public List<EducationalLeaders> educationalLeaders = [];



    /* METHODS */

    public void Add(EducationalLeaders educationalLeader)
    {
        educationalLeaders.Add(educationalLeader);
    }

    public override void Find(string socialSecurityNumber)
    {
        if(socialSecurityNumber == "19750630-3124")
        {
            SocialSecurityNumber = "19750630-3124";
            FirstName = "Maria";
            Surname = "Arvidsson";
            Phone = "072-1335560";
            Address = "Saltvägen 21";
            PostalCode = "420 12";
            City = "Göteborg";
            FieldOfStudy = "Utbildningsledare";
            EmploymentDate = DateTime.Now.AddYears(-5).AddMonths(-4).AddDays(10);

        } else if(socialSecurityNumber == "19820313-5449")
        {
            SocialSecurityNumber = "19820313-5449";
            FirstName = "Annika";
            Surname = "Svensson";
            Phone = "073-1422410";
            Address = "Branteviksvägen 31";
            PostalCode = "414 41";
            City = "Göteborg";
            FieldOfStudy = "Utbildningsledare";
            EmploymentDate = DateTime.Now.AddYears(-2).AddMonths(-9);
            
        } else 
        {
            Console.WriteLine("Kunde inte hitta utbildningsledare.");
        }
    }
    public override void ListAll()
    {
        foreach (var educationalLeader in educationalLeaders)
        {
            Console.WriteLine(educationalLeader.ToString());
        }
    }
     public override string ToString()
    {
        return $"{base.ToString()}Anställningsdatum: {EmploymentDate}\n";
    } 
}
