namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());

        int max1 = max(a, b);

        Console.WriteLine($"a = {a}; b = {b};");
        Console.WriteLine($"The largest number is: {max1}");

        // Q2
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        int e = Convert.ToInt16(Console.ReadLine());
        int f = Convert.ToInt16(Console.ReadLine());

        int max2 = max(c, d, e, f);

        Console.WriteLine($"a = {c}; b = {d}; c = {e}; d = {f};");
        Console.WriteLine($"The largest number is: {max2}");

        // Q3
        createAccount();
    }

    // Question 1 Method
    static int max(int a, int b){

        if(a>b){
            return a;
        } else{
            return b;
        }
    }

    // Question 2 Method
    static int max(int a, int b, int c, int d){
        int max1 = max(a, b);
        int max2 = max(c, d);

        return max(max1, max2);
    }

    // Question 3 Methods
    static bool checkAge(int birthYear){
        int age = 2025 - birthYear;

        if(age >= 18){
            return true;
        } else{
            return false;
        }
    }

    static void createAccount(){
        Console.WriteLine("Enter Your Username: ");
        string user = Console.ReadLine();
        Console.WriteLine("Enter Your Password: ");
        string pass = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again: ");
        string pass2 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear: ");
        int bYear = Convert.ToInt16(Console.ReadLine());

        if(checkAge(bYear)){
            Console.WriteLine(pass == pass2 ? "Account is created successfully" :  
                "Wrong Password");
        } else{
            Console.WriteLine("Could not create an account");
        }
    }
}
