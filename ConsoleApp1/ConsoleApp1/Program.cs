using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
public interface IParent
{
    string Info();
    double Metod1();
    double Metod2();
}
public class Child1 : IParent
{
    protected double a;
    protected double b;
    protected double c;
    protected double S;
    protected double V;
    public Child1(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        
    }
    double IParent.Metod1()
    {
        return S = 2 * (a * b + b * c + a * c);
    }
    double IParent.Metod2()
    {
        return V = a * b * c;
    }
    string IParent.Info()
    {
        return "Прямокутний паралелепiпед:"  + "a=" + a + "," + "b=" + "," + b + "," + "c=" + "," + c ;
    }
}
 public class Child2:IParent
    {
        protected double R;
        protected double l;
        protected double S1;
        protected double V1;
        const double p = 3.14;
        public Child2(double R,double l)
        {
            this.R = R;
            this.l = l;
        } 
        double IParent.Metod1()
        {
            return S1 = p * R * l + p * Math.Pow(R, 2);
        } 
        double IParent.Metod2()
        {
            return V1 = 1d / 3 * (p * Math.Pow(R, 2) * l);
        }
        string IParent.Info()
        {
        return "Конус:" + "R=" + R + "," + "l=" + l ;
        }
}   
 public class Child3:IParent
{
    protected double r;
    const double p = 3.14;
    protected double S2;
    protected double V2;

    public Child3(double r)
    {
        this.r = r;
    } 
    double IParent.Metod1()
    {
        return S2 = 4 * p * r * 2;
    } 
    double IParent.Metod2()
    {
        return V2 = 4 / 3 * (p * Math.Pow(r,2));
    } 
    string IParent.Info()
    {
        return "Куля:" + "R=" + r ; 
    } 
}    
class Program
{
     static void Main(string[] args)
       {
          IParent obj = null;
          Random o = new Random();
        string I,I2,I3;
        int n; double a,b,c,S,V,R,l,S1,V1,r,S2,V2;
          for(int i = 1; i<=5; i++)
         {
            n = o.Next(1, 4); 
            if (n==1)
            {
                a = o.Next(1, 18); b = o.Next(1, 20); c = o.Next(1, 22);
                obj = new Child1(a,b,c);
                I = obj.Info();
                S = obj.Metod1();
                V = obj.Metod2();
                Console.WriteLine(I + "," + " S=" + S + "," + "V= " + V);
            }   
            if (n==2)
            {
                R = o.Next(2, 10); l = o.Next(5, 20);
                obj = new Child2(R, l);
                 I2 = obj.Info();
                S1 = obj.Metod1();
                V1 = obj.Metod2();
                Console.WriteLine(I2 + "," + " S=" + S1 + "," + "V= " + V1);
            } 
            if (n==3)
            {
                r = o.Next(2, 10);
                obj = new Child3(r);
                I3 = obj.Info();
                S2 = obj.Metod1();
                V2 = obj.Metod2();
                Console.WriteLine(I3 + ","+" S="  + S2 + "," + "V= " + V2);
            }
         }  
       }
}

 
   
    


 
   

