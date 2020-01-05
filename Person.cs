using System;



public class Person
{

    public enum SEX
    {
        남자,
        여자
    };


    public Person()
    {
        Console.WriteLine("default Constructor");
    }
    public Person(Person person)
    {
        Console.WriteLine("copy Constructor");
        name = person.name;
        age = person.age;
        sex = person.sex;
    }

    public Person(String name, int age, SEX sex)
    {
        Console.WriteLine("instance Constructor");//Constuctor overloading
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
    ~Person()
    {
        Console.WriteLine("destructor");
    }


    public String name;
    public int age;
    public SEX sex;

    public void talkMyName()
    {
        Console.WriteLine("my name is {0}", name);
    }
}
