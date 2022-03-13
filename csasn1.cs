/*
                CSC 123/252 C# Assignment 1

Part I (warmup):

1. C# is basically like Java, but there are some unique features.  One
of these is the "delegate" construct, which allows you to write
higher-order functions.  That is, functions that take other functions
as arguments (such as map, fold, howmany, etc ...).  Study the sample
programs in the blackboard folder (under "more programs" that use
delegates to understand how they works  Then write the delegate

public delegate bool boolFun(int x);

( alternatively, with C# 4.0+, you can use Func<int,bool> )

And implement the function "howmany" on arrays.  That is, it should
return the number of elements in an arrays of integers (see
higherorder.cs) for which the delegate function returns
true. Demonstrate your program with at least two instantiations of the
the delegate template.

For example, given int[] A = {4,3,6,9,15}; I should be able to call

howmany(A,(x)=>x%2==0)

which should return 2, since there are 2 even numbers in the array.

howmany(A,(x)=>x<0) should return 0.

public static int howmany(int[] A,boolFun p)
{// ...
}


/* **************************************************************************
Part II:  Implementing Multiple Inheritance
*/

// C# (and Java, Kotlin, etc) does not allow for the inheritance of
// multiple classes (abstract or not), only interfaces.  In 
//   class A: B,C,D   { ... }
// only B can be a class, C and D must be interfaces

//// But we want to have multiple inheritance anyway!  Are we going to let
// a silly little thing like a language restriction stop us?  Think back
// to how we managed to achieve inheritance and even dynamic dispatch in Perl
// using just closures.

// Given:
using System;

public interface Ia
{
   void f();
   void g();
   void h1();
}

public interface Ib
{
   void f();
   void g();
   void h2();
}


public class A : Ia
{
  public virtual void f() { Console.WriteLine("f from class A"); }
  public virtual void g() { Console.WriteLine("g from class A"); }
  public virtual void h1() { Console.WriteLine("h1 from class A"); }
}

public class B : Ib
{
  public virtual void f() { Console.WriteLine("f from class B"); }
  public virtual void g() { Console.WriteLine("g from class B"); }
  public virtual void h2() { Console.WriteLine("h2 from class B"); }
}


/// Show how to construct a class

//public class C : Ia, Ib

// That implements both intferaces.  (class C can implement other
// interfaces, and extend a class as well).  This class should inherit
// both h1 from A and h2 from B.  FURTHERMORE, C MUST inherit f() 
// from class A and g() from class B.

//*** Your solution MUST make use of the single inheritance allowed by the
// language, and only emulate the additional inheritance.  There's no need
// to emulate both inheritances.  *** This is important ***
		
/// Your class C must work with the supplied .dll file.  To compile
// a C# program using a .dll, do  csc yourprogram.cs /r:csasn1b.dll
// or mcs program.cs -r:csasn1b.dll  in Mono (Linux VM has mono).
// FYI: to create a .dll, write a program without a Main and do
// csc /t:library program.cs  or  mcs -t:library program.cs

// The classes A and B and interfaces Ia, Ib are defined in the .dll.
// HOWEVER, the exact behavior of the functions f(), g(), h1() and h2()
// are slightly different, just to make sure that you're doing this assignment
// the right way.  The Main below will have a slightly different output
// than the code above suggests.  Test your program with this version of
// the classes first to make sure it works.

// public static void Main()
// { C n = new C();   //don't put any print statements in your C constructor
//   n.f(); n.g(); n.h1(); n.h2();  //exact output will show proper inheritance
// }

///** Anyone who just copy and paste the code from A and B or
///// who tries to decompile the .dll will lose 100000 points.
///// Anyone who does not take advantage of the built-in single
///// inheritance will lose 99999 points.

// Now, this doesn't mean you can't define f, g and h1/h2 in your subclasses
// It means that you cannot copy the "Console.WriteLine" code, 
// because it really represents arbitrarily complex code.  Your solution 
// must work in general, regardless of how these functions are implemented.


/////////////////////////////////////////////////////////////////////////////

//2. This is a slightly harder version of the above problem.  This time there
// are no interfaces Ia, Ib to give you a clue.  Instead you just have

public class A2
{
  protected virtual void f() {Console.WriteLine("A2.f");}
  protected virtual void g() {Console.WriteLine("A2.g");}
  protected virtual void h1() {Console.WriteLine("A2.h1");}
}
public class B2
{
  protected virtual void f() {Console.WriteLine("B2.f");}
  protected virtual void g() {Console.WriteLine("B2.g");}
  protected virtual void h2() {Console.WriteLine("B2.h2");}
}


// these classes are also in the same .dll

// Write a class C2 that inherits all the functionality of A2 and B2,
// with the same stipulation that it should take f() from A2 and g() from B2.

// Hint: you may define other interfaces, classes to help you, but YOU MAY 
// NOT CHANGE A2, B2 (do not change the .dll)

// Unlike part 1, this time both inheritances may have to be emulated.

// public static void Main()
// { C2 n = new C2();   //don't put any print statements in your C2 constructor
//   n.f(); n.g(); n.h1(); n.h2();  //exact output will show proper inheritance
// }

