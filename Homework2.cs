namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
        Console.WriteLine("Please input a letter grade:");
        string n = Console.ReadLine();
        
        switch(n){
            
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            
            case "B":
                Console.WriteLine("GPA point: 3");
                break;

            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        // Question 2

        Console.WriteLine("Please input the first num:");
        int firstNum = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        int secNum = Convert.ToInt16(Console.ReadLine());    

        Console.WriteLine("Please input the third num:");
        int thirdNum = Convert.ToInt16(Console.ReadLine());

        if(firstNum<secNum){
            if(firstNum<thirdNum){
                Console.WriteLine($"The smallest number is: {firstNum}");
            } else {
                Console.WriteLine($"The smallest number is: {thirdNum}");
            } 
        } else {
            if(secNum<thirdNum){
                Console.WriteLine($"The smallest number is: {secNum}");
            } else {
                Console.WriteLine($"The smallest number is: {thirdNum}");
            }
        }

        // Bonus Question

        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0)){
            Console.WriteLine($"{year} is a Leap Year.");
        } else {
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }
}
