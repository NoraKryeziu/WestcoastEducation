namespace WestcoastEducation;

public class Educators : Employees 
{


    /* METHODS */
    public override void Find(string socialSecurityNumber)
    {
        if(socialSecurityNumber == "19720814-1113")
        {
            SocialSecurityNumber = "19720814-1113";
            FirstName = "Thomas";
            Surname = "Andersson";
            Phone = "070-1138880";
            Address = "Brogatan 38";
            PostalCode = "412 12";
            City = "Göteborg";
            FieldOfStudy = "Organisation och ledarskap";

        } else if(socialSecurityNumber == "19681201-2279")
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
    public override string ToString()
    {
        return $"{base.ToString()}\n";
    }

}

