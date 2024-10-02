namespace WestcoastEducation;

public class PersonalData
{
    /* PROPERTIES */
    public string FirstName { get; set; } = ""; 
    public string Surname { get; set; } = "";   
    public string Phone { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public string Address { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";

    /* METHODS  */
    public override string ToString()
    {
        return $"Namn: {FirstName} {Surname} Telefon: {Phone} Adress: {Address}, {PostalCode} {City}";
    }
}
