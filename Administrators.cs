namespace WestcoastEducation;

public class Administrators : EducationalLeaders , IManage
{
   /* PROPERTIES */
  public List<Administrators> administrators = [];

   /* METHODS */
   public void Add(Administrators administrator)
    {
        administrators.Add(administrator);
    }

   public override void Find(string socialSecurityNumber)
   {
      if (socialSecurityNumber == "19700222-6221")
      {
         SocialSecurityNumber = "19700222-6221";
         FirstName = "Emma";
         Surname = "Nilsson";
         Phone = "070-0151510";
         Address = "Stenvägen 2";
         PostalCode = "421 14";
         City = "Göteborg";
         FieldOfStudy = "Administratör";
         EmploymentDate = DateTime.Now.AddYears(-7).AddMonths(-2).AddDays(20);

      }
      else
      {
         Console.WriteLine("Kunde inte hitta administratör.");
      }
   }
   public override void ListAll(){
        foreach (var administrator in administrators)
        {
            Console.WriteLine(administrator.ToString());
        }
    }
        public override string ToString()
    {
        return $"{base.ToString()}";
    }
}



