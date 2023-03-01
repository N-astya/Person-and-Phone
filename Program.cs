using System;
using System.Numerics;


namespace Person_and_Phone
{
    internal class Program
    {
        public class Person
        {
            private string fullName = "";
            private int age;
            public Person()
            {
                fullName = " Человек";
                age = 0;
            }
            public Person(int m, string n)
            {
                fullName = n;
                age = m;
            }
            public void move()
            {
                Console.Write(fullName);
                Console.Write(" говорит");
            }
            public void talk()
            {
                Console.Write(fullName);
                Console.Write(" идёт ");
            }
        }

        static void Main(string[] args)
        {
            Person PersonOne = new Person();
            Person PersonTwo = new Person(17, " Анастасия");
            PersonOne.move();
            PersonOne.talk();
            PersonTwo.move();
            PersonTwo.talk();
            Phone firstPhone = new Phone();
            Phone secondPhone = new Phone();
            Console.WriteLine(firstPhone.getNumber());
            firstPhone.recieveCall("\nЮрий ");
            firstPhone.sendMessage("89005884175");
            Console.WriteLine(secondPhone.getNumber());
            secondPhone.recieveCall("\nЮрий ");
            secondPhone.sendMessage("40", "89005884175");
            firstPhone.printArgs();
            secondPhone.printArgs();
            firstPhone.recieveCall("Юрий ", 124567);
        }
        public class Phone
        {
            private int number;
            private string model = "";
            private int weight;
            public void printArgs()
            {
                Console.Write(number);
                Console.Write(model);
                Console.Write(weight);
            }
            public void sendMessage(params string[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            public int getNumber()
            {
                return number;
            }
            public void recieveCall(string name)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
            }
            public void recieveCall(string name, int number)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
                Console.Write(number);
            }
            public Phone(int q, string v, int w) : this(q, v)
            {
                weight = w;
            }
            public Phone(int q, string v)
            {
                number = q;
                model = v;
                weight = 0;
            }
            public Phone()
            {
                number = 0;
                model = "";
                weight = 0;
            }
        }
    }
}