// Delegates (higher-order functions) in C#

/*
   A "delegate" in C# is type for lambda terms that can be manipulated
   as values.  This mechanism is a good example of how modern programming
   languages are converging: what once was strictly the domain of languages
   such as scheme are now finding their way into more conventional languages.
*/


using System;
using System.Collections.Generic;  // needed for List class 

public delegate int fun(int x);  // declares delegate type

public delegate int fun2(int x, int y); 

public delegate bool predicate(int x);


public class higherorder // main class
{

// instances of delegates
public static int square(int x) { return x*x; }
public static bool odd(int x) => x%2==1;  // equivalent to {return x%2==1;}
public static int mult(int x, int y) => x*y;


// higher order function to map a funtion over every element of a List
public static List<int> map(fun f, List<int> M)
{
   List<int> A = new List<int>();
   foreach (int x in M) { A.Add( f(x) ); }
   // can also use other loop structures:
   // for (int i=0;i<M.Count;i++) A.Add( f(M[i]) );
   return A;
} // map

// filter out only the elements of M that statisfy predicate p:
public static List<int> filter(predicate p, List<int> M)
{
  List<int> N = new List<int>();  // new list to be constructed
  foreach (int x in M)
   {
      if (p(x)) N.Add(x);
   }
  return N;
} // filter


// The following "function" illustrates how the "closures" of scheme/perl can
// also be captured in C# using delegates:
public static fun makeaccumulator(int init)  // returns a fun delegate
{
   int ax = init;  // the accumulator closure variable
   return delegate(int x)
   {  ax += x;
      return ax;
   };
   // can also say return (x) => { ax+=x; return ax;}
} // makeaccumulator

public static void Main(string[] args)
{
   List<int> L = new List<int>();
   // List is a typed array/list combo structure 
   L.Add(2); L.Add(3); L.Add(5); L.Add(7); L.Add(10);
   List<int> M = map(new fun(square), L);
   foreach (int x in M) Console.Write(x+" ");  // prints 4 9 24 9 25 49 100 
   Console.WriteLine("");
  
   // in-line delegate (like an anonymous lambda term (sub in perl))
   // "delegate" here is like a typed lambda:

   M = filter( delegate(int x) {return x%2==0;}, L); // filter even elements

   foreach (int x in M) Console.Write(x+" ");  // prints 2 10
   Console.WriteLine("\n\n");

   // closures in C#:
   fun myax = makeaccumulator(0);
   fun yourax = makeaccumulator(100);
   Console.WriteLine(myax(50));
   Console.WriteLine(myax(50));
   Console.WriteLine(yourax(50));
} // main

} // class higherorder

