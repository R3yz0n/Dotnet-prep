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
OuterClass.InnerClass ic = new OuterClass.InnerClass();
// OuterClass oc = new OuterClass();
// ------------------------------------------------------------------------------------------------



// ------------------------------------------------------------------------------------------------
//Partial Class
// PartialClass pc = new PartialClass();
// pc.MethodA();
// pc.MethodB();
// ------------------------------------------------------------------------------------------------