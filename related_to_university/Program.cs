using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace related_to_university
{
    class Program
    {
      
        static void Main(string[] args)
        {
            /*
            student s1 = new student("ali");            //exapmle     1
            s1.name = "helal";
            */


            /*
            Location loc = new Location("irbid","salah alden");                       //example       2
            Employee emp1 = new Employee("Michael", "michael", loc, "1234");
            Employee emp2 = new Employee("Susan", "susan", loc, "4321");
            Employee emp3 = new Employee();
            TimeSheet ts = new TimeSheet();
            Console.WriteLine("Email address for Susan is {0}", emp2.Email());
            emp1.RecordOvertime(ts, 5);
            */

            /*
            cat c1 = new cat();                      example      3
            c1.eat();
            */

            /*
            A a = new A();              //example 4
            B b = new B();
            b.talk();
            a.talk();
            */


            /*
            B b = new B();                              example     5
            b.f();
            b.rr();
            */


            /*
            A a1 = new A();                       example 6
            A a2 = new A();
            A.x = 20;      //this is how to access static variable in a class
            a1.y = 100;
            a2.y = 30;            //every object has its own y ... but the variable x is sharbale
            A.z = 40;           //we can intialize a static varibal without makeing new object
            Console.WriteLine(A.x + "  "+ a1.y+"  "+a2.y);
            A.print();                  //we can not make object from static
            */



            /*
            person p1 = new person();               //example 7
            student s1 = new student();
            person p2 = s1;  //I can say person p2=new student();   //up casting    //there is no syntax error becuase every student is a person
            //every student is a person but not every person is a student ..so I cant say //student s2=p2;// ERROR....untill we make casting
            student s2 = (student)p2;     //down casting    //we can convert it to make it points on student when I give it refernece of student from the first 
            //there should be a relation between two classes to make casting..we cant make casting between employee ans student 
            p2.p();
            //I cant cay p2.h(); even if I make it reference to student 
            */


            /*
            int x = 123;
            Object o = x;               //boxing: converting value type to reference type
            x = 234;         //only the value of x will change 
            o = 788;
            int i = (int)o;    //unboxing:converting reference type to value type
            object j=44;
            int h = (int)j;
            */

            /*                        //example  8
            A a;     //it is gonna take defulte values...I can define it like this or A a=new A();
            B b;     //it ids gonna take null.....if I said B b=new B(); it is gonna stored in heap not null
            */


            /*                  example 9
            print(10, a.fri);
            if (10 < (int)a.fri)
                Console.WriteLine("true");
            */

            
            /*
            ArrayList arr = new ArrayList();
            arr.Add("ali");
            arr.Add(3.4);
            arr.Add(null);
            arr.Add(true);
            arr.Add(new Object());
            object s1 = new object();
            arr.Add(s1);
            Console.WriteLine(arr.Count);
            arr.Remove(3.4);
            arr.RemoveAt(3);
            arr.RemoveRange(2, 2);   //it is gonnna go to 3 index and remove two items after it
            int[] type = { 1, 2, 3 };
            arr.AddRange(type);  //it takes colletion type like arraylist or array or list or linkedlist ..etc
            Console.WriteLine(arr.Count);
            foreach (var i in arr)
                Console.WriteLine(i);
            */


             /*                     //  example 10
            List<int> a = new List<int>();
            a.Add(12);
            person p = new person();
            student s = new student(10,"ahmed");
            List<person> b = new List<person>();
            b.Add(p);
            b.Add(s);
            b.Add(new student(3,"belal"));
            b.Add(new employee());
            for (int i = 0; i < b.Count; i++)
                Console.WriteLine(b[i]);
            foreach (person i in b)
                Console.WriteLine(i);

            List<student> stu = new List<student>();
            stu.Add(new student(2, "khaled"));
            stu.Add(new student(5, "khlel"));
            stu.Add(new student(3, "mhamad"));
            stu.Add(new student(9, "jamel"));
            foreach (student i in stu)
                Console.WriteLine(i.id+"  "+i.name);
            */




            Console.ReadKey();
        }


        /*          example 9

        enum a           //speacil class
        {
            sat = 16, mon, tu, wen, fri, sun, thi    //the next varible will take the next value
        }
        static void print(int x, a v)
        {
            Console.WriteLine(x + "  " + v);
        }
*/


    }
    /*class person                //example        1
    {
        public string name
        {
            get;
            set;
        }
        public person(string name)
        {
            this.name = name;
            Console.WriteLine("i am parent   "+name);
        }
    }
    class student:person
    {

        public int id
        {
            get { return id; }
            set { value = id; }
        }
        public student(string x) : base(x)
        {
            Console.WriteLine("i am child");
        }
    }
    */


    /*
    public class Location                                //example         2
    {
        string city;
        string street;
        public Location(string city,string street)
        {
            this.city = city;
            this.street = street;
        }
    }

    public class Employee
    {
        string name;
        string username;
        Location currentLocation;
        string phoneNumber;
        public Employee(string name, string username,
        Location location, string phoneNumber)
        {
            this.name = name;
            this.username = username;
            this.currentLocation = location;
            this.phoneNumber = phoneNumber;
        }
        public Employee()
        {
            this.name = "default";
            this.username = "default";
            this.currentLocation = null;
            this.phoneNumber = "0000";
        }
        public void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }

        public string Email()
        {
            return username + "@example.com";
        }
        public void RecordOvertime(TimeSheet timeSheet, int hours)
        {
            timeSheet.AddEntry(name, hours);
        }
    }

    public class TimeSheet
    {
        public void AddEntry(string name, int hours)
        {
            Console.WriteLine("recorded that {0} worked {1} hours", name, hours);
        }
    }
    */


    /*
    interface animal                                              //example      3
    {
      
        void eat();
    }
    interface b                                 //intrerfaces have no implemntation ..it is just to be inherited
    {                                //we cant make any varibale or constuctor of interfaces...it is just for methods
       void move();
    }
    class h { }
    class cat :h,animal,b           //we can do multiple inheritance by interfaces not by classes
    {                                //we can make inherit for one class as much as we want interfaces
        public void eat()
        {
            Console.WriteLine("cat food");
        }
        public void move()
        {

        }
    }
    class bird : animal
    {
        public void eat()
        {
            Console.WriteLine("bird food");
        }
    }
    /


    /*
    class A                                                   example     4
    {
      public virtual void talk() { Console.WriteLine("fast talk"); }
    }
    class B : A
    {
        public override void talk()
        {
            base.talk();            //this to call the base method not the overrided
           Console.WriteLine("slow talk");
        }
    }
    */


    /*                          //example 5
   abstract class A                                                                 exapmle      5
    {                           //we can not make any object of abstract classes 
        public void f() { Console.WriteLine("here we are"); }          
        public abstract void rr();  //we gave it this abstract method without implementation
    }
    class B : A 
    {
        public override void rr() { Console.WriteLine("hello world"); }
    }
    */


    /*
    sealed class A                         // when we define a class as sealed that means it cant be inherited
    {

    }
   class B:A { }             //this is a wrong line ...
    */


    /*
    //maybe we can make the function as a sealed if we dont want to inhert it
     class A                      
    {
        public sealed void print() { }        //this is a wrong line ...
    }
    class B : A { }
    */


    /*
    //static is sharable between all objects of claas
    class A                                                example 6
    {
        public static int x ;
        public static int z;
        public int y;
        public static void print()    //when we do a static method all the variable in this function should be static
        {
            Console.WriteLine(x + "  " + z);
            Math.Min(x, z);
        }
    }
    */


    /*
    class person                      //  example 7
    {
        public void p()
        { Console.WriteLine("head"); }
    }
    class student: person
    {
        public void h()
        { Console.WriteLine("son"); }
    }
    */


    /*
    struct A             //value type                  //exsmple 8
    {
        public int x;
        public int y;
    }
    class B           //reference type
    {
        public int x;
        public int y;
    }
    */
    


                         // example 10
    class person
    {
        int x;
    }
    class student: person
    {
        public int id;
        public string name;
        public student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class employee:person
    {
        public employee() { Console.WriteLine("employee class"); }
    }
   
}


