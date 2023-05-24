// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// struct(user define data type) is like a value type. it is used when there is less complex field with less elements / logics. It is not commonly used.
// struct can have a default constructor.
// class is the blueprint of an object
// constructor is a special method THAT WE USE TO INSTATIATE A CLASS by using the "NEW" keyword.
// in struct you can call the default contructor or the established constructor but not in class
// using Struct;


// PARAMETERLESS CONSTRUCTOR
// Declearing of Variable in Struct
// Employee Emp = new Employee();
// OR
// using Struct;
// Employee Emp = new Employee();

// Emp.Name = "Ade";
// Emp.Id = 7;


// Access and Assigning Values
// Employee Emp2;
// Emp2 = Emp;
// Emp2.Id = 9;
// Emp2.Name = "Bayo";

// Emp.getinfo(Emp.Id, Emp.Name);

// // OR
// Emp2.getinfo(Emp2.Id, Emp2.Name);

// public class Employee
// {
//     public int Id;
//     public string Name;

//     public void getinfo(int Id, string Name)
//     {
//         System.Console.WriteLine($"Your name is {Name} and your Id is {Id} ");
//     }
// }



// OR

// Employee Emp = new Employee(9, "Ade");
// System.Console.WriteLine(Emp.Id);
// System.Console.WriteLine(Emp.Name);

// public struct Employee
// {
//     public int Id;
//     public string Name;

    

//     public Employee(int id, string name)
//     {
//         Id = id;
//         Name = name;
//     }

//     public void getinfo(int id, string name)
//     {
//         System.Console.WriteLine($"Your name is {Name} and your Id is {Id} ");
//     }
// }







// ////////ENUM
// IT IS A SPECIAL CLASS THAT CONTAINS A CONSTANT VARIABLE WITH A CONRESPONDING INTEGERS 
    

// public enum Human
// {
//     male,
//     female,
//     tans

// }
// System.Console.WriteLine(DaysOfTheWeek.Mon is DaysOfTheWeek);
// // DaysOfTheWeek DayValue = DaysOfTheWeek.Wed;
// // OR
// int DayValue = (int)DaysOfTheWeek.Wed;
// System.Console.WriteLine(DayValue);
// public enum DaysOfTheWeek
// {
//     Mon = 1,
//     Tue = 2,
//     Wed = 3,
//     Thurs = 4,
//     Fri = 5,
//     Sat = 6,
//     Sun = 7
// }

// System.Console.WriteLine(coffeeSize.small);

using Struct;

static int calcPrice (coffeeSize size)
{
    switch (size)
    {
        case coffeeSize.small:
        return 500;
        
        case coffeeSize.medium:
        return 1000;

        case coffeeSize.large:
        return 1500;
        
        default:
        return 0;
    }
}
System.Console.WriteLine(calcPrice(coffeeSize.small));


System.Console.WriteLine("Enter 1 for small size ...... Enter 2 for medium size........ Enter 3 for big size");
int enter = int.Parse(Console.ReadLine());
if (enter == 1)
{
        System.Console.WriteLine(calcPrice(coffeeSize.small));
}
else if (enter == 2)
{
    System.Console.WriteLine(calcPrice(coffeeSize.medium));
}
else if (enter ==3)
{
    System.Console.WriteLine(calcPrice(coffeeSize.large));
}



