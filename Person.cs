//public class Person
//{
//    public string Name;
//    public void Introduce(string to)
//    {
//        Console.WriteLine("Hi {0} I am {1}", to, Name);
//    }

//    public static Person Parse(string str)
//    {
//        Person p = new Person();
//        p.Name = str;
//        return p;
//    }
//}
////public class Person
////{
////    private string name;
////    public DateTime BirthDate;
////    public Person(DateTime birthDate)
////    {
////        BirthDate = birthDate;
////    }
////    public int Age
////    {
////        get
////        {
////            var timeSpan = DateTime.Today - BirthDate;
////            var years = (int)(timeSpan.TotalDays / 365.25);
////            return years;
////        }
////    }
////    public string Name
////    {
////        get { return name; }
////        set { name = value; }
////    }
////    public int Id { get; set; }
////}