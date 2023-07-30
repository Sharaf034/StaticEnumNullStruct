



//using Enum_Struct_Nall;

//Person.Name = "Sh";
//Console.WriteLine(Person.Name);
//Person.Test();

//Person person = new Person();
//Person person1 = new Person();
//Person person2 = new Person();
//Person person3 = new Person();


//Car car = new Car();
//Car car1 = new Car();
//Car car2 = new Car();


//Console.WriteLine(Car.count);

//using Enum_Struct_Nall.Extention;

//int num = 20;
//int result = num.Sum(100);

//Console.WriteLine(result);

////string name = "Fidan";
////Console.WriteLine(name.HasStr("n"));

//string name = "Fidan566@";
//Console.WriteLine(name.CheckDigitOfString());


//using Enum_Struct_Nall;
//using Enum_Struct_Nall.Extention;

//Book book = new Book();

//book.Name = "Xosrov ve Shirin";

//book.Test();

//string name = null;
//Console.WriteLine(name);

//int? age = null;
//if (age == null)
//{
//    Console.WriteLine("Age not found");
//}

//using Enum_Struct_Nall;

//Animal animal = new Animal();
//animal.GeTAge();


//using Enum_Struct_Nall;

//CheckRole(3);

//foreach (var item in Enum.GetValues(typeof(Roles)))
//{
//    Console.WriteLine(item);
//}


//HasRole("Admin");







//var result = HasRole("Admin");


//if (result)
//{
//    Console.WriteLine("Yes,we have this role");
//}
//else
//{
//    Console.WriteLine("No,we dont have this role");
//}
//static bool HasRole(string role)
//{
//    bool hasRole = false;
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {

//            hasRole = true;

//        }
//    }

//    return false;



//}

//static void HasRole(string role)
//{
//    bool hasRole = false;
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {

//            hasRole = true;

//        }
//    }

//    if (hasRole)
//    {
//        Console.WriteLine("Yes,we have this role");
//    }
//    else
//    {
//        Console.WriteLine("No,we dont have this role");
//    }

//}





//static string HasRole(string role)
//{
//    ;
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {

//            return "Yes,we have this role";

//        }
//    }

//    return "No,we dont have this role";
//}

//Console.WriteLine(HasRole("Admin"));



//static void CheckRole(int roleId)
//{
//    //if (roleId ==(int) Roles.SuperAdmin)
//    //{
//    //    Console.WriteLine("SuperAdmin");
//    //}

//    switch (roleId)
//    {
//        case (int)Roles.SuperAdmin:
//            Console.WriteLine("SuperAdmin");
//            break;
//        case (int)Roles.Admin:
//            Console.WriteLine("Admin");
//            break;
//        case (int)Roles.Member:
//            Console.WriteLine("Member");
//            break;

//        default:
//            Console.WriteLine("Role Id is wrong");
//            break;
//    }
//}


