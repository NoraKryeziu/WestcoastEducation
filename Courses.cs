﻿namespace WestcoastEducation;

public class Courses
{
    /* PROPERTIES */
    public int Number { get; set; }
    public string Title { get; set; } = "";
    public int Length { get; set; } 
    public DateTime StartDate { get; set; } 
    public DateTime EndDate { get; set; }
    public bool Classroom { get; set; }

    public List<Courses> courseList = new List<Courses>();


    /* CONSTRUCTOR */
    public Courses(){}

    /* METHODS */
    public void AddCourse (Courses course)
    {
        courseList.Add(course);
    }
    public void FindCourse (int number)
    {
       
        if (number == 121)
        {
            Number = 121;
            Title = "Självledarskap grund";
            StartDate = DateTime.Now;
            Length = 7;
            EndDate = StartDate.AddDays(Length);
            Classroom = true;
            
        }
        else if(number == 122)
        {
            Number = 122;
            Title = "Programmering C#/.NET, grund";
            StartDate = DateTime.Now.AddDays(7);
            Length = 56;
            EndDate = StartDate.AddDays(Length);
            Classroom = false;
        }
        else if(number == 123)
        {
            Number = 123;
            Title = "Databasteknik";
            StartDate = DateTime.Now.AddDays(7+56);
            Length = 56;
            EndDate = StartDate.AddDays(Length);
            Classroom = true;
        }
        else 
        {
            Console.WriteLine("Kunde inte hitta kursen.");
        }
    }
    public void ListAllCourses()
    {
        foreach (var courses in courseList)
        {
            Console.WriteLine(courses.ToString());
        }
    }
    public override string ToString()
    {
        string location = Classroom == true? "Klassrum" : "Distans";
        return $"{Title} {Number}: Start datum: {StartDate} Slut datum: {EndDate} Antal dagar: {Length} Plats: {location} ";
    }

}
