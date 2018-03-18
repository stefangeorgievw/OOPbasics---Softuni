using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;

    public string  FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;
        }
        
    }

    private string lastName;

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            this.lastName = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer!");
            }
            this.age = value;
        }

    }

    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        private set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less tha 460leva!");
            }
            this.salary = value;
        }
        
    }


    public Person(string firstName,string lastName,int age,decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age < 30 )
        {
            this.salary += this.salary * percentage / 200;
        }
        else
        {
            this.salary += this.salary * percentage / 100;
        }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} gets {this.Salary:F2} leva.";
    }

}

