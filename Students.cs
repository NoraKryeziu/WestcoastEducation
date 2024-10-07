namespace WestcoastEducation;

public class Students : PersonalData
{
    public List<Students> students = [];
   

    /* METHODS */
    public void AddStudent(Students student)
    {
        students.Add(student);
    }
    public void ListAllStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n";
    }
    public void FindStudent(string socialSecurityNumber)
    {
        if(socialSecurityNumber == "19980731-1223")
        {
            SocialSecurityNumber = "19980731-1223";
            FirstName = "Amanda";
            Surname = "Gustavsson";
            Phone = "073-1556780";
            Address = "Långgatan 38";
            PostalCode = "411 07";
            City = "Göteborg";

        } else if(socialSecurityNumber == "19920519-2374")
        {
            SocialSecurityNumber = "19920519-2374";
            FirstName = "Theodor";
            Surname = "Ivanov";
            Phone = "072-3554880";
            Address = "Storgatan 3";
            PostalCode = "411 02";
            City = "Göteborg";

        } else if (socialSecurityNumber == "19950109-2664")
        {
            SocialSecurityNumber = "19950109-2664";
            FirstName = "Evelina";
            Surname = "Billsten";
            Phone = "072-0505840";
            Address = "Nobelgatan 3";
            PostalCode = "411 22";
            City = "Göteborg";

        } else if(socialSecurityNumber == "19990421-2772")
        {
            SocialSecurityNumber = "19990421-2772";
            FirstName = "Adrian";
            Surname = "Istrefi";
            Phone = "072-1005844";
            Address = "Östra storgatan 21";
            PostalCode = "411 03";
            City = "Göteborg";

        } else if (socialSecurityNumber == "20000121-3165")
        {
            SocialSecurityNumber = "20000121-3165";
            FirstName = "Tova";
            Surname = "Ekström";
            Phone = "076-9687807";
            Address = "Farmvägen 17";
            PostalCode = "417 21 ";
            City = "Göteborg";

        } else 
        {
            Console.WriteLine("Kunde inte hitta eleven.");
        }
    }
}
