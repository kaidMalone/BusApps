﻿namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};


        // call Q1 method
        TotalCredits(customer_list);
        // call Q2 method
        AmarilloAverageAge(customer_list);
        // call Q3 method
        CanyonAge(customer_list);

    }

    // Q1 method
    public static void TotalCredits(Customer[] customerList){
        double credit = 0;

        foreach(Customer p in customerList){
            credit += p.customerCredit;
        }

        Console.WriteLine($"The total Credits: {credit}");
    }

    // Q2 method
    public static void AmarilloAverageAge(Customer[] customerList){
        double age = 0;
        int index = 0;
        
        foreach(Customer p in customerList){
            if(p.customerCity == "Amarillo"){
                age += p.customerAge;
                index++;
            }
        }


        Console.WriteLine($"The average age of customers in Amarillo: {age/index}");
    }

    // Q3 method
    public static void CanyonAge(Customer[] customerList){
        Console.Write("Customers who live in Canyon and over 30 years old:");
        
        string names = "";
        foreach(Customer p in customerList){
            if(p.customerAge > 30 && p.customerCity == "Canyon"){
                names += " " + p.customerName + ",";
            }
        }

        Console.WriteLine(names);
    }
}

// Q0 class
class Customer{

    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}