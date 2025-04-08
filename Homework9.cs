using System.Reflection;

namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook.Add("Alice", 4);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }

        double count = 0;
        foreach(var stu in gradebook){
            count += stu.Value;
        }
        count /= gradebook.Count;

        Console.WriteLine($"The average GPA is: {count}");

        
        foreach(Student stu in Student.studentList){
            if(gradebook[stu.studentName]>count){
                stu.PrintInfo();
            }
        }
        
    }
    class Student {
        
        public static List<Student> studentList = new List<Student>();
        private int studentID;
        public string studentName {get; set;}

        public Student(int id, string name){
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo(){
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }
}
