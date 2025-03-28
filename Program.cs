using System;
using March29;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("HEKK\n");
        var cokkie = new Indexers();
        cokkie["name"] = "rajat dalle";
        Console.WriteLine(cokkie["name"]);
        // Using Param to pass a number as an array
        //var calculator = new Calculator();
        //Console.WriteLine(calculator.Add(1, 2, 3));

        //// how to create a object in C-Sharp
        //var person = new Person();
        //person.Name = "Suraj Shah";
        //person.Introduce("Mosh");

        //var p = Person.Parse("om sambhar");
        //p.Introduce("Mosh");

        //// using customer class constructor learning from here

        //var customer1 = new Customer(21, "suraj");
        //var order = new Order("pizza", 320);
        //customer1.Orders.Add(order);
        //Console.WriteLine(customer1.Orders.Count);

        //foreach (var item in customer1.Orders)
        //{
        //    Console.WriteLine(item.Pizza + " " + item.Price);
        //}

        //// ref
        //int a = 1;
        //Ref r = new Ref();
        //r.MyMethod(ref a);
        //Console.WriteLine("The value of a is " + a);

        //// out
        //Out o = new Out();
        //int b;
        //int c;
        //o.MyMethod(out b, out c);
        //Console.WriteLine("The value of b: {0} c: {1} ", b, c);


        //customer1.Promote(); // Example of calling the Promote method.
        //Console.WriteLine("Orders after promote: " + customer1.Orders.Count); //shows 0 after promote.

        //var p = new Person(new DateTime(2003, 8, 20));
        //p.Name = "Suraj Shah";
        //p.Id = 1;
        //Console.WriteLine(p.Name + " " + " " + p.Id);
        //Console.WriteLine("Your age is " + p.Age);



    }
}
