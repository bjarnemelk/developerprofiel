int monthsOfExperience = 0;
Console.WriteLine("name?");
 string name = Console.ReadLine(); // Console.readline geeft de data terug als string

 Console.WriteLine("School Class?");
 string schoolClass = Console.ReadLine(); 

 Console.WriteLine("age?");
 int age = Convert.ToInt32(Console.ReadLine()); // Voor leeftijd wordt een int gebruikt omdat dit een getal is en geen tekst

 Console.WriteLine("city?");
 string city = Console.ReadLine();

 Console.WriteLine("favorite programming language?");
 string favoriteProgrammingLanguage = Console.ReadLine(); // Handig om te weten wat de developer leuk vindt om te gebruiken

 Console.WriteLine("Screentime in hours?");
 int screentime = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("laptop budget?");
 decimal laptopbudget = Convert.ToDecimal(Console.ReadLine()); // Decimal is geschikt voor een laptop budget omdat het een prijs is in euro's en dat decimalen kan bevatten

 Console.WriteLine("Programming experience? (true/false)");
 bool programmingExperience = Convert.ToBoolean(Console.ReadLine()); // In een bool kan je true of false typen
 if (programmingExperience == true)
{
    Console.WriteLine("How many months of experience do you have?");
    monthsOfExperience = Convert.ToInt32(Console.ReadLine()); // Handig om meer info te krijgen over de ervaring van de developer
    
}
else monthsOfExperience = 0;
 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("");

Console.WriteLine("DEVELOPER PROFILE");
Console.WriteLine("");
 Console.WriteLine($"Name : {name}");
 Console.WriteLine($"School Class : {schoolClass}");
 Console.WriteLine($"Age : {age}");
 Console.WriteLine($"City : {city}");
 Console.WriteLine($"Screentime : {screentime} hours");
 Console.WriteLine($"Laptop Budget : {laptopbudget}");
 Console.WriteLine($"Favorite Programming Language : {favoriteProgrammingLanguage}");
 if (programmingExperience == true) // Gekozen voor een if statement omdat ik true of false op een print niet mooi vindt
 {
     Console.WriteLine($"Programming Experience : Yes");
 }
 else
 {
     Console.WriteLine($"Programming Experience : No");
 }
 Console.WriteLine($"Months of Experience : {monthsOfExperience}");