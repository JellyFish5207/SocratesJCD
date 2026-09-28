using System;
struct Student{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;

}
public class Program{
Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
    
    public void ADD(){
        Student student = new Student();
        Console.Write("Enter Student Number:");
        student.StudentNumber = Console.ReadLine();
        Console.Write("Enter Student Name:");
        student.Name = Console.ReadLine();
        Console.Write("Enter Program:");
        student.Program = Console.ReadLine();
        Console.Write("Enter Year Level:");
        int year = int.Parse(Console.ReadLine());
        while (year < 1 || year >= 5){
            Console.Write("Year Level Invalid");
            year = int.Parse(Console.ReadLine());
        }
        student.YearLevel = year;
        if (!studentDictionary.ContainsKey(student.StudentNumber)){
        studentDictionary.Add(student.StudentNumber, student);
        }
    }

    public void SEARCH(){
        Console.Write("Search for Student Number:");
        string search = Console.ReadLine();
        if (studentDictionary.TryGetValue(search, out Student student)){
            Console.WriteLine($" Student Number: {student.StudentNumber}\n Name: {student.Name}\n Program: {student.Program}\n Year Level: {student.YearLevel}");
        } else{
            Console.Write($"Student {search} Not Found");
        }

    }
    
    public void DISPLAY(){
        foreach (var items in studentDictionary){
            Console.WriteLine($" Student Number: {items.Value.StudentNumber}\n Name: {items.Value.Name}\n Program: {items.Value.Program}\n Year Level: {items.Value.YearLevel}");}
        }
        
    static void Main(){
    Program program = new Program();
    int option;
    do{
        Console.Write("What To Do: ");
        option = int.Parse(Console.ReadLine());
        switch (option){
            case 1: 
            program.ADD();
            break;

            case 2:
            program.SEARCH();
            break;
            
            case 3:
            program.DISPLAY();
            break;
            
            case 4:
            Console.Write("Exiting Program...");
            break;
            
            default: 
            Console.WriteLine("Please Select VALID Option");
            break;
        }
    }while (option != 4);
    }
}