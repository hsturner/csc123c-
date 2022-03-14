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
    /*
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
    */

    class C : A, Ib
    {
        //h1 from a 
        //h2 from b 
        //f from a 
        //g from 
        private B n = new B();
        public override void g()
        {
            n.g();
        }

        public void h2()
        {
            n.h2();
        }
    }
    

    public static void Main() { 
        C n = new C();   //don't put any print statements in your C constructor
        n.f(); n.g(); n.h1(); n.h2();  //exact output will show proper inheritance
    }
}
