using System;
using System.Collections.Generic;
using System.Text;


class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.accounts = new List<BankAccount>();

    }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.name = name;
        this.age = age;
        this.accounts = accounts;

    }

    public decimal GetBalanced()
    {
        return decimal.Parse(this.accounts.ToString());
    }
}

