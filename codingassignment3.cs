using System;
using System.Collections.Generic;
public delegate bool boolFun(int x);

//Part 1: Higher order functions
public class higherorder
{
    //ublic static int 
    // public static bool exists(int x) => x != null;
    public static int howmany(List<int> A, boolFun p)
    {
        int ax = 0;
        foreach (int x in A)
        {
            if (p(x)) ax++;
        }

        return ax;
    }
  /*  public static void Main(String[] args)
    {
        List<int> l1 = new List<Int32>();
        l1.Add(1);
        l1.Add(2);
        l1.Add(3);
        int result = howmany(l1, (x) => x == 1);
        Console.Write("result: " + result);
        result = howmany(l1, (x) => x>0);
        Console.Write("result: " + result);
        l1.Add(6);
        result = howmany(l1, (x) => x > 5);
        Console.Write("result: " + result);
    }
    */

} //end part 1 

//part 2: Multiple inheritance

class multiInherit
{
    class C : A, Ib
    {
        //h1 from a 
        //h2 from b 
        //f from a 
        //g from b 
        public void h2();
        public void  g();
    }
    

    public static void Main() { 
        C n = new C();   //don't put any print statements in your C constructor
        n.f(); n.g(); n.h1(); n.h2();  //exact output will show proper inheritance
    }
}
