using System;

namespace ClassWork17
{
    class Program
    {
        // модификатор доступа delegate тип-возвращаемого_зн NameDelegate(тип_argument argument)
        public delegate void MyDelegate1();
        public delegate int MyDelegate2(int i);
        static void Main(string[] args)
        {
            //MyDelegate1 myDelegate = MyMethod1;
            //myDelegate += MyMethod2;
            //myDelegate -= MyMethod1;
            //myDelegate();
            //myDelegate.Invoke();
            //var myDelegate2 = new MyDelegate1(MyMethod1);
            //myDelegate2 += MyMethod2;

            //var myDelegate3 = myDelegate + myDelegate2;
            MyDelegate2 myValueDelegate = new MyDelegate2(MyMethod3);
            myValueDelegate += MyMethod3;
            myValueDelegate += MyMethod3;
            myValueDelegate(new Random().Next(1, 10));

            // Action
            var cl = new MyClass();
            Action methodMyClass = cl.MyClassMethod;
            Hello(6, methodMyClass);
            // Action<string> mm =  
            // delegate(params){
             // code
            // }
            // Event - ключевое слово которое говорит что мы обьявляем событие
            var classNew = new MyClass();
            classNew.Simple(6);
            classNew.Help += 
            // MyDelegate2 myValueDelegate2 = delegate (int i)
            // {
            //     Console.WriteLine("anonimeMethod");
            //     return 0;
            // };
        }
        private static void Hello(int i, Action action)
        {
            if(i > 5)
            {
                action.Invoke();
            }
        }
        private static void MyMethod1()
        {
            Console.WriteLine("MyMethod1");
        }
        private static void MyMethod2()
        {
            Console.WriteLine("MyMethod2");
        }

        private static int MyMethod3(int i)
        {
            Console.WriteLine();
            return 0;
        }

        private class MyClass : myNewInterface
        {
            public  void MyClassMethod()
            {
                Console.WriteLine("It`s Method.");
            }

            public event Action<int> Help;
            public void Simple(int i)
            {
                if (i > 5)
                {
                    Help?.Invoke(i * i);
                }
            }
        }
    }
}
