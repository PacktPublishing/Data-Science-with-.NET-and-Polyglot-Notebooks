public class FootballPlayer
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string FullName => $"{FirstName} {LastName}";

    public string Position {get; set;}
    public int Number {get; set;}

    public string CurrentClub {get; set;}
    public string Nationality {get; set;}
    public bool IsRightFooted {get; set;} = true;
    public int HeightInCm {get; set;}
    public int RookieYear {get; set;}
}