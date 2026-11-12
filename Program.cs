

using System.Runtime.CompilerServices;
using DesingPatternOOP.src.oopPrinciple.Encapsulations;
using _src.oopPrinciple.Abstractions;
using _src.Transport;
using oopPrinciple.Polymorphism;
using Microsoft.VisualBasic;
using DesingPatternOOP_.src.oopPrinciple.Coupling;
using DesingPatternOOP_.src.oopPrinciple.Compositions;
using DesingPatternOOP_.src.SOLID.L;
using DesingPatternOOP_;
using DesingPatternOOP_.src.SOLID.I;


//encapsulation is one of the fundamental principles of object-oriented programming (OOP) 
// that involves bundling data (attributes) and methods (functions) that operate on that data into a single unit, 
// typically a class. It also restricts direct access to some of an object's components, 
// which can prevent the accidental modification of data and promote a clear interface for interacting with the object.

BankAccount account = new BankAccount(1000);

System.Console.WriteLine(account.Balance());

account.Deposit(100);
System.Console.WriteLine(account.Balance());

account.Withdraw(100);
System.Console.WriteLine(account.Balance());



//Abstraction is a fundamental concept in object-oriented programming (OOP) that focuses on simplifying complex systems by modeling classes based on the essential properties 
// and behaviors an object should have, while hiding unnecessary details. It allows developers to create a clear and simplified interface for interacting with objects, 
// making it easier to manage complexity and enhance code maintainability.

EmailService emailService = new EmailService();
emailService.SendEmail(); 

//Inheritance is a fundamental concept in object-oriented programming (OOP) 
// that allows a class (called a subclass or derived class) to inherit properties and behaviors (methods) 
// from another class (called a superclass or base class).

var car = new Car();

car.Brand = "Toyota";
car.Start();
car.Stop();

//unique
car.NumberOfDoors = 4;

//polymorphism is a fundamental concept in object-oriented programming (OOP) that allows objects of different classes 
// to be treated as objects of a common superclass.


List<Vechicle> userVechile = new List<Vechicle>();

userVechile.Add(new UserCar{Brand = "Toyota",NumberOfDoors = 4, NumberOFWheels = 4});
userVechile.Add(new UserMotorcycle{Brand = "Honda"});
userVechile.Add(new UserPlane{Brand = "Boeing", NumberOfDoors = 2});

//vechicle inspections

// System.Console.WriteLine("Vechicle Inspections:" + userVechile.Count + " vechicles found.");

foreach  (var vechile in userVechile)
{
    if (vechile is UserCar)
    {
        var mycar = (UserCar)vechile;
        mycar.Start();
    }else if (vechile is UserMotorcycle)
    {
        var myMotorcycle = (UserMotorcycle)vechile;
        myMotorcycle.Start();
    }else if (vechile is UserPlane)
    {
        var myPlane = (UserPlane)vechile;
        myPlane.Start();
    }
}

//Coupling is a concept in software engineering that refers to the degree of interdependence between software modules.


//In this example, the Order class is tightly coupled with 
// the SendEmail class because it directly creates an instance of SendEmail and calls its method.

Console.WriteLine("--------------------------------------------------------------------`");
var order = new Order(new Emailsender());
order.PlaceOrder();

var order2 = new Order(new SmsSender());
order2.PlaceOrder();


Console.WriteLine("----------------------------compositions----------------------------------------`");

Carcom comcar = new Carcom();
comcar.startCar();


Console.WriteLine("----------SOLID PRONCIPLES-------");


Console.WriteLine("-------------------------------Liskov substitution Principle-------------------------------------`");

//Liskov substitution Principle

// "objects of a superclass should be replaceable with objects of its subclass
//  without affecting the correctness of the program"

// var rect = new Lrectangle();
// rect.Height = 10;
// rect.Width = 5;

// Console.WriteLine("execpted area = 10 * 5 = 50");
// System.Console.WriteLine($"calculated area = {rect.Area}");


Lshape rectangle = new Lrectangle{Height =10, Width=5};
System.Console.WriteLine($"Area of a rectangle : {rectangle.Area}");

Lshape square = new Lsquare{ SideLength = 5};
System.Console.WriteLine($"Area of a square : {square.Area}");



// Interface Segregation Principle (ISP) is one of the SOLID principles of object-oriented design.


//CLIENT SHOULD NOT BE FORCED TO DEPEND ON INTERFACES THEY DO NOT USE

var incircle = new InCircle();
incircle.Radius = 5;
System.Console.WriteLine($"Area of a circle : {incircle.Area()}");


