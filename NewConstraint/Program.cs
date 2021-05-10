using System;

namespace NewConstraint
{


    public class simpleClass
    {
        int i1 { get; set; }

        /*private simpleClass()
        {

        }*/
        public simpleClass()
        {

        }

        public simpleClass(int i)
        {
            i1 = i;
        }
    }

    public class newConstraint<T1, T2> where T1:class,new() where T2:class,new()
    //public class newConstraint<T1, T2> where T1:class where T2:class
    {
        public T1 inline1 { get; set; }


        public T2 inline2 { get; set; }

        /*public newConstraint()
        {

        }*/

        public newConstraint()
        {
            inline1 = new T1();
            inline2 = new T2();
        }
        public newConstraint(T1 i1,T2 i2)
            {
            inline1 = i1;
            inline2 = i2;
            }
        

        /*public T1 constructGenericType()
        {
            var newT1 = new T1();
            var newT2 = new T2();
            return newT1;
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            var nonPublic = new simpleClass(100);
            var test = new newConstraint<simpleClass,simpleClass>(nonPublic,nonPublic);
            var @null = new newConstraint<simpleClass,simpleClass>();
            /*var test = new newConstraint<int, int>(100,200);
            var @out=test.Add(test.v1, test.v2);
            Console.WriteLine($"{@out}");*/

            //var oriGeneric = new simpleClass();
            //var genericNow = new newConstraint<simpleClass, simpleClass>(oriGeneric, oriGeneric);
        }
    }
}
