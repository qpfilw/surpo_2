using System;

class Person
{
    public string name = "Jora";
    public string surname = "Ivanov";
    public Person(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
}

class Job
{
    public string vacancy { get; set; }
    public int money { get; set; }
    public string currency { get; set; }
    public Job(string vacancy, int money, string currency)
    {
        this.vacancy = vacancy;
        this.money = money;
        this.currency = currency;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("polina", "filiushina");
        Job job = new Job("programmer", 2000000, "dollars");
        Console.Write(person.name + " " + person.surname + '\n');
        Console.Write(job.vacancy + " " + "and her salary" + " " + job.money + " " + job.currency);
    }
}
