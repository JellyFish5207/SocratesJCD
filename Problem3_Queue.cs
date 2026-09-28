using System;
struct StudentRequest{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;

}
public class Program{
    Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
    
    public void ADD(){
        StudentRequest request = new StudentRequest();
        Console.Write("Enter Student Number:");
        request.StudentNumber = Console.ReadLine();
        Console.Write("Enter Student Name:");
        request.StudentName = Console.ReadLine();
        Console.Write("Write Request:");
        request.RequestType = Console.ReadLine();
        requestQueue.Enqueue(request);
        }

    public void DISPLAY(){
        if (requestQueue.Count == 0){
            Console.Write("ZERO PENDING REQUESTS\n");
        }else{
        foreach (var items in requestQueue){
            Console.WriteLine($" {items.StudentName} - {items.RequestType}\n");
                }
            }
        }
        
    public void PROCESS(){
        if (requestQueue.Count == 0){
            Console.Write("ZERO PENDING REQUESTS\n");
        }else{
            Console.WriteLine($"Processing Request...\n");
            requestQueue.Dequeue();
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
            program.ADD();
            break;

            case 2:
            program.DISPLAY();
            break;
            
            case 3:
            program.PROCESS();
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