//NOTE WE CANNOT CALL NON STATIC METHOD FROM STATIC MAIN METHOD
// Types t = new Types();
// Swapping s = new Swapping();

// Goto g = new Goto();
// Array a = new Array();
// Strings s = new Strings();


// ------------------------------------------------------------------------------------------------

//Encapsulation Example && Data Hiding
// Encapsulation account = new Encapsulation();
// Depositing and withdrawing money (encapsulation)
// account.Deposit(1000);   // Direct access to the methodcl
// account.Withdraw(1000);   // Direct access to the methodcl

// ------------------------------------------------------------------------------------------------

//Properteis & its Types
// Properties p = new Properties();

// ------------------------------------------------------------------------------------------------




// ------------------------------------------------------------------------------------------------

//Constructor & Deconstructor
//Contructing
// Constructor person1 = new Constructor("sagar", "thapa");

// Explicitly calling Deconstruct
// string fn, ln;
// person1.Deconstruct(out string fn, out string ln);
// System.Console.WriteLine(fn + ln);

// Implicitly calling Deconstruct

// Constructor person2 = new Constructor(" reyzon", "chhetri");

// (string a, string b) = person2;
// System.Console.WriteLine(a + b);

// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Finializer
// Finalizer f = new Finalizer();
// ------------------------------------------------------------------------------------------------




// ------------------------------------------------------------------------------------------------
//Static Class
// StaticClass.IncrementCounter();
// ------------------------------------------------------------------------------------------------


// ------------------------------------------------------------------------------------------------
//Sealed Class
// SealedClass s = new SealedClass();
// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Nested Class
// OuterClass.InnerClass ic = new OuterClass.InnerClass();
// OuterClass oc = new OuterClass();
// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Partial Class
// PartialClass pc = new PartialClass();
// pc.MethodA();
// pc.MethodB();
// ------------------------------------------------------------------------------------------------


// ------------------------------------------------------------------------------------------------
//Indexer

// Indexer i = new Indexer();
// i[0] = "Sagar";
// System.Console.WriteLine(i[0]);
// ------------------------------------------------------------------------------------------------




// ------------------------------------------------------------------------------------------------
//Object Type

// ObjectType ot = new ObjectType();
// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Structure

// Structure s;
// Structure s1 = new Structure();
// s1.num = 10;
// Structure s2 = s1;
// s1.num = 20;
// System.Console.WriteLine(s2.num);


// ------------------------------------------------------------------------------------------------




// ------------------------------------------------------------------------------------------------
//Enums

// System.Console.WriteLine(Convert.ToInt32(Days.Mon));
// int today = (int)Enums.Binary.no;
// System.Console.WriteLine(today);

// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Method Overriding
// Dog d = new Dog();
// d.color = "red";
// d.Legs = 4;
// d.Display();


// Animal a = new Dog();
// a.Eat();
// System.Console.WriteLine(a.Legs);

// ------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------
//Method Hiding

// Base b = new Derived();
// b.Display();

//------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------
//Abstract Class
// AbstractionDemo dc = new AbstractionDemo();
// dc.AbstractMethod();
//------------------------------------------------------------------------------------------------


// ************************************************************************************************

// Interface can have both abstract and non abstract methods
// Abstract can have both abstract and non abstract properties
//Interface dont have constructor but Abstract class have constructor
// Interface suppors multiple inheritance but Abstract class does not support single inheritance

// ************************************************************************************************




//------------------------------------------------------------------------------------------------

//Binary Operator Overloading

// BinaryOperatorOverloading b1 = new BinaryOperatorOverloading();
// BinaryOperatorOverloading b2 = new BinaryOperatorOverloading();
// b1.name = "Sagar";
// b2.name = "Thapa";
// b1.num = 10;
// b1.num = 20;
// BinaryOperatorOverloading b3 = new BinaryOperatorOverloading();
// b3 = b1 + b2;
// System.Console.WriteLine(b3.num);
// System.Console.WriteLine(b3.name);

//------------------------------------------------------------------------------------------------




//------------------------------------------------------------------------------------------------

//Unary Operator Overloading

// UnaryOverloading u1 = new UnaryOverloading();
// u1.num = 10;
// UnaryOverloading u2 = new UnaryOverloading();
// u2 = ++u1;
// System.Console.WriteLine(u2.num);
//------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------

//Relational Operator Overloading

// RelationalOverloading r1 = new RelationalOverloading();
// RelationalOverloading r2 = new RelationalOverloading();
// r1.num = 10;
// r2.num = 10;
// bool r3 = r1 > r2;
// System.Console.WriteLine(r3);

//------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------

//SIngle casting Delegate
// SingleCastDelegate.Main();

//MultiCast Delegate
// MultiCastDelegate.Main();
//------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------
//Lamda Expressions
// LamdaExpression.Main();
//------------------------------------------------------------------------------------------------

//------------------------------------------------------------------------------------------------
// LINQ
// LINQ.Main();
//------------------------------------------------------------------------------------------------


//------------------------------------------------------------------------------------------------
// CRUD
CrudApp.Main();
//------------------------------------------------------------------------------------------------