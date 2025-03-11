namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Professor alice = new Professor();
        alice.profName = "Alice";
        alice.classTeach = "Java";
        alice.Salary = 9000;

        Professor bob = new Professor();
        bob.profName = "Bob";
        bob.classTeach = "Math";
        bob.Salary = 8000;

        Student lisa = new Student();
        lisa.studentName = "Lisa";
        lisa.classEnroll = "Java";
        lisa.SetGrade(90);

        Student tom = new Student();
        tom.studentName = "Tom";
        tom.classEnroll = "Math";
        tom.SetGrade(80);

        // Q2
        Console.WriteLine($"Professor {alice.profName} teaches {alice.classTeach}, and the salary is: {alice.Salary}");
        Console.WriteLine($"Professor {bob.profName} teaches {bob.classTeach}, and the salary is: {bob.Salary}");
        Console.WriteLine($"Student {lisa.studentName} enrolls {lisa.classEnroll}, and the grade is: {lisa.GetGrade()}");
        Console.WriteLine($"Student {tom.studentName} enrolls {tom.classEnroll}, and the grade is: {tom.GetGrade()}");
        Console.WriteLine($"The salary difference between {alice.profName} and {bob.profName} is: {alice.Salary - bob.Salary}");
        Console.WriteLine($"The total grade of {lisa.studentName} and {tom.studentName} is: {lisa.GetGrade() + tom.GetGrade()}");
    }   

    class Professor{

        public string profName;
        public string classTeach;
        public double Salary{get; set;}
    }

    class Student{
        
        public string studentName;
        public string classEnroll;
        private double studentGrade;

        public void SetGrade(double newGrade){
            studentGrade = newGrade;
        }

        public double GetGrade(){
            return studentGrade;
        }
    }
}
