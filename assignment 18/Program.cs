using assignment_18.AuthenticationService;
using assignment_18.IClonable;
using assignment_18.Interface;
using assignment_18.Interface_Ex3;
using assignment_18.IShape;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using assignment_18.NotificationService;

namespace assignment_18
{
    internal class Program
    {
        //public static void Print10NumbersFromSeries(SeriesByTwo series)
        //{
        //    if (series == null)
        //        return; //return with void if this not equel then its get out from method or function
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.current} \t");
        //        series.GetNext();
        //    }
        //        series.Reset();
        //    Console.WriteLine();
        //}

        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null)
                return; //return with void if this not equel then its get out from method or function
            for (int i = 0; i< 10; i++)
            {
                Console.Write($"{series.current} \t");
                series.GetNext();
            }
    series.Reset();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Part 1

            #region Interface Example 2
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);

            //ISeries series = new SeriesByTwo();
            //Print10NumbersFromSeries(series);

            //ISeries series1 = new SeriesByThree();
            //Print10NumbersFromSeries(series1);

            //ISeries series2 = new SeriesByFour();
            //Print10NumbersFromSeries(series2); 
            #endregion

            #region Interface Example 3
            //Airplane airplane = new Airplane();
            //airplane.Forward(); //implicitly => if we do both interface implement implicitly and explicitly we do implicitly

            //IMoveable moveable = new Airplane();
            //moveable.Forward(); //Explicitly => if we do Imoveable in airplane class implement explicitly

            //IFlyable flyable = new Airplane();
            //flyable.Backward(); //Implicitly 
            #endregion

            #region Shallow copy VS Deep copy [value type]
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = {4, 5, 6 };

            //Console.WriteLine($"Hashcode Arr01 : {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Arr02 : {Arr02.GetHashCode()}"); //18643596

            #region Shallow copy 
            ////Shallow copy
            //Arr02 = Arr01;
            ////this object {1,2,3} has 2 references []
            ////this object {4,5,6} unreachable object
            //Console.WriteLine("After Shallow copy");

            //Console.WriteLine($"Hashcode Arr01 : {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Arr02 : {Arr02.GetHashCode()}"); //54267293

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); //100 
            #endregion

            #region Deep copy
            ////Deep copy
            //Arr02 = (int[]) Arr01.Clone();
            ////clone method : will generate new object
            ////with new different identity
            ////this object will have the same object state[data]
            ////of the caller object

            //Console.WriteLine("After Deep copy");

            //Console.WriteLine($"Hashcode Arr01 : {Arr01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Arr02 : {Arr02.GetHashCode()}"); //33574638

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); //1
            //Console.WriteLine(Arr02[0]); //100
            #endregion

            #endregion

            #region Shallow copy VS Deep copy [reference type]
            //string[] Name01 = new string[] { "omar" };
            //string[] Name02 = new string[1]; //null

            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //18643596

            #region Shallow copy
            ////shallow copy
            //Name02 = Name01;

            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //54267293

            //Console.WriteLine(Name01[0]); //omar
            //Console.WriteLine(Name02[0]); //omar

            //Name02[0] = "mona";

            //Console.WriteLine(Name01[0]); //mona
            //Console.WriteLine(Name02[0]); //mona 
            #endregion

            #region Deep copy
            ////Deep copy
            //Name02 = (string[])Name01.Clone();

            //Console.WriteLine("After deep copy");
            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //33574638

            //Console.WriteLine(Name01[0]); //omar
            //Console.WriteLine(Name02[0]); //omar

            //Name02[0] = "mona";

            //Console.WriteLine(Name01[0]); //omar
            //Console.WriteLine(Name02[0]); //mona 
            #endregion

            #endregion

            #region Shallow copy VS Deep copy [reference type(String Builder)]
            //StringBuilder[] Name01 = new StringBuilder[1];
            //Name01[0] = new StringBuilder("omar");
            ////Name01[0].Append("omar"); //Null ref exciptioin
            //StringBuilder[] Name02 = new StringBuilder[1];

            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //18643596

            #region Shallow copy
            ////Shallow copy
            //Name02 = Name01;

            //Console.WriteLine("After Shallow copy");
            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //54267293

            //Console.WriteLine(Name01[0]); //omar
            //Console.WriteLine(Name02[0]); //omar

            //Name02[0].Append(" Ahmed");

            //Console.WriteLine("After Change");
            //Console.WriteLine(Name01[0]); //omarAhmed
            //Console.WriteLine(Name02[0]); //omarAhmed 
            #endregion

            #region Deep copy
            ////Deep copy
            //Name02 = (StringBuilder[])Name01.Clone();

            //Console.WriteLine("After Deep copy");
            //Console.WriteLine($"Hashcode Name01 : {Name01.GetHashCode()}"); //54267293
            //Console.WriteLine($"Hashcode Name02 : {Name02.GetHashCode()}"); //33574638

            //Console.WriteLine(Name01[0]); //omar
            //Console.WriteLine(Name02[0]); //omar

            //Name02[0].Append(" ahmed");

            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]); //omar ahmed
            //Console.WriteLine(Name02[0]); //omar ahmed
            #endregion

            #endregion

            #region Interface - ICloneable
            //Employee emp01 = new Employee()
            //{
            //    Id = 10,
            //    Name = "Ali",
            //    Salary = 3_000,
            //    Department = new Department(){Id = 100,Name = "HR"}
            //};
            //Employee emp02 = new Employee()
            //{
            //    Id = 10,
            //    Name = "mona",
            //    Salary = 5_000
            //};
            //Console.WriteLine($"HashCode of emp01 = {emp01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of emp02 = {emp02.GetHashCode()}"); //18643596

            ////Shallow copy
            //Employee emp03 = emp01;
            //Console.WriteLine("After Shallow copy");
            //Console.WriteLine($"HashCode of emp01 = {emp01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of emp03 = {emp03.GetHashCode()}"); //54267293 

            ////Deep copy
            //Employee emp03 = (Employee)emp01.Clone();
            ////Employee emp03 = new Employee(emp01);
            //Console.WriteLine("After Deep copy");
            //Console.WriteLine($"HashCode of emp01 = {emp01.GetHashCode()}"); //54267293
            //Console.WriteLine($"HashCode of emp03 = {emp03.GetHashCode()}"); //33574638

            //emp03.Department.Name = "Sales";
            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);
            //Console.WriteLine(emp03);
            #endregion

            #region IComparable
            //            int[] Numbers = {5,9,4,2,3,7,1,10};

            //            Array.Sort(Numbers);
            //            foreach (var item in Numbers)
            //            {
            //                Console.WriteLine(item);
            //            }

            //            Employee[] employees =
            //{
            //                new Employee(){Id = 10 , Name = "omar" , Salary = 5000},
            //                new Employee(){Id = 20 , Name = "ali" , Salary = 3000},
            //                new Employee(){Id = 30 , Name = "ahmed" , Salary = 7000},
            //            };

            //            Array.Sort(employees);

            //            foreach (var item in employees)
            //            {
            //                Console.WriteLine(item);
            //            }

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    for (int j = 1; j < employees.Length-j; j++)
            //    {
            //        if (employees[j].compareTo(employees[j+1]) == 1)
            //        {
            //            swap(employees[j], employees[j + 1]);
            //        };
            //    };
            //};
            #endregion
            #endregion

            #region part 2

            #region question 1
            //What is the primary purpose of an interface in C#?

            //Answer => b) To define a blueprint for a class
            #endregion

            #region question 2
            //Which of the following is NOT a valid access modifier for interface members in C#?

            //Answer => a)private
            //and i think too that b)Protected maybe its not valid in interface
            #endregion

            #region question 3
            //Can an interface contain fields in C#?

            //Answer => b) No
            #endregion

            #region question 4
            //In C#, can an interface inherit from another interface?

            //Answer => b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region question 5
            //Which keyword is used to implement an interface in a class in C#?

            //Answer => d) implements
            #endregion

            #region question 6
            //Can an interface contain static methods in C#?

            //Answer => b)No
            #endregion

            #region question 7
            //In C#, can an interface have explicit access modifiers for its members?

            //Answer => b) No, all members are implicitly public
            #endregion

            #region question 8
            //What is the purpose of an explicit interface implementation in C#?

            //Answer => b) To provide a clear separation between interface and class members
            #endregion

            #region question 9
            //In C#, can an interface have a constructor?

            //Answer =>b) No, interfaces cannot have constructors
            #endregion

            #region question 10
            //How can a C# class implement multiple interfaces?

            //Answer => c) By separating interface names with commas
            #endregion
            #endregion

            #region part 3
            #region question 1
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two
            //interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes
            //Circle and Rectangle. Test your implementation by creating instances of both classes and displaying
            //their shape information.

            ////create instances of circle and rectange
            //Circle circle = new Circle(5);
            //Rectange rectange = new Rectange(4, 6);

            ////Display shape Information
            //circle.DisplayShapeInfo();
            //rectange.DisplayShapeInfo();
            #endregion

            #region question 2
            //In this example, we start by defining the IAuthenticationService interface with two methods:
            //AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface
            //and provides the specific implementation for these methods.
            //In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username
            //and password with the stored credentials.It returns true if the user is authenticated and false
            //otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.
            //It returns true if the user is authorized and false otherwise.
            //In the Main method, we create an instance of the BasicAuthenticationService class and assign it
            //to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and
            //AuthorizeUser methods using this interface reference.
            //This implementation allows you to switch the authentication service implementation easily by
            //creating a new class that implements the IAuthenticationService interface and providing the desired
            //logic for authentication and authorization.

            ////create an instance from Basic Authentication class
            //IAuthenticationService authenticationService = new BasicAuthenticationService(); //ref [parent] => obj [child]

            ////call the authentication method
            //string username = "admin";
            //string password = "password";
            //bool isAuth = authenticationService.AuthenticateUser(username, password);
            //Console.WriteLine($"User Authenticated : {isAuth}");

            //string role = "admin";
            //bool isAuthorized = authenticationService.AuthorizeUser(username, role);
            //Console.WriteLine($"User AuthorizeUser : {isAuthorized}");
            #endregion

            #region question 3
            //we define the INotificationService interface with a method SendNotification that takes a recipient
            //and a message as parameters.
            //We then create three classes: EmailNotificationService, SmsNotificationService, and
            //PushNotificationService, which implement the INotificationService interface.
            //In each implementation, we provide the logic to send notifications through the respective
            //communication channel:
            //he EmailNotificationService class simulates sending an email by outputting a message to the console.
            //The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            //The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            //In the Main method, we create instances of each notification service class and call the
            //SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels by creating
            //new classes that implement the INotificationService interface and provide the specific logic for each channel.

            ////create instance of each notification service class
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService notificationService = new PushNotificationService();

            //// Call the SendNotification method with sample recipient and message values
            //string recipient = "kerloss.emeil18@gmail.com";
            //string message = "Hello, kerloss! You have a new notification.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //notificationService.SendNotification(recipient, message);
            #endregion
            #endregion
        }
    }
}
