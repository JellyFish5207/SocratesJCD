using System;
struct Student{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;

}
public class Program{
    Student[] students = new Student[10];
    public int studentCount = 0;
    
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
        students[studentCount] = student;
        studentCount += 1;
    }
    
    public void DISPLAY(){
        for (int i = 0; i < studentCount; i+=1){
            Console.WriteLine($" Student Number: {students[i].StudentNumber}\n Name: {students[i].Name}\n Program: {students[i].Program}\n Year Level: {students[i].YearLevel}");
        }}
        
    public void SEARCH(){
        Console.Write("Search for Student Number:");
        string search = Console.ReadLine();
        int found = 0;
        for (int i = 0; i < studentCount; i+=1){
            if (students[i].StudentNumber == search){
            found = 1;
            Console.WriteLine($" Student Number: {students[i].StudentNumber}\n Name: {students[i].Name}\n Program: {students[i].Program}\n Year Level: {students[i].YearLevel}");
            }
        }
        if (found == 0){
                Console.WriteLine("Student Not Found");
            }
    }
    
    public void UPDATE(){
        Console.Write("Search for Student Number:");
        string search = Console.ReadLine();
        int found = 0;
        for (int i = 0; i < studentCount; i+=1){
            if (students[i].StudentNumber == search){
                found = 1;
                Console.Write("Enter Student Name:");
                students[i].Name = Console.ReadLine();
                Console.Write("Enter Program:");
                students[i].Program = Console.ReadLine();
                Console.Write("Enter Year Level:");
                int year = int.Parse(Console.ReadLine());
                while (year < 1 || year >= 5){
                    Console.Write("Year Level Invalid");
                    year = int.Parse(Console.ReadLine());}
                    students[i].YearLevel = year;
            }
        }
        if (found == 0){
                Console.WriteLine("Student Not Found");
            }
    }
    
    public void DELETE(){
        Console.Write("Search for Student Number:");
        string search = Console.ReadLine();
        int found = 0;
        for (int i = 0; i < studentCount; i+=1){
            if (students[i].StudentNumber == search){
                found = 1;
                for (int x = i; x < studentCount; x+=1){
                    students[x] = students[x+1];
                }
            studentCount -= 1;
            }
        }
        if (found == 0){
                Console.WriteLine("Student Not Found");
            }
    }
    
    static void Main(){
    Program program = new Program();
    int option;
    do{
        Console.Write("What To Do: ");
        option = int.Parse(Console.ReadLine());
        switch (option){
            case 1: 
            if (program.studentCount >= 10){
                Console.WriteLine("Maximum Students Reached");
            } else{
            program.ADD();}
            break;
            
            case 2:
            program.DISPLAY();
            break;
            
            case 3:
            program.SEARCH();
            break;
            
            case 4:
            program.UPDATE();
            break;
            
            case 5:
            program.DELETE();
            break;
            
            case 6:
            Console.Write("Exiting Program...");
            break;

            default: 
            Console.WriteLine("Please Select VALID Option");
            break;
        }
    }while (option != 6);
    }
}