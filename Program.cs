using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("assignment1 question 1");
            A1Q1 obj1 = new A1Q1();
            obj1.Assignment1();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question2");
            A1Q2 obj2 = new A1Q2();
            obj2.Assignment2();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question3");
            A1Q3 obj3 = new A1Q3();
            obj3.Assignment3();
            Console.ReadLine();

        }

        class A1Q1
        {
            public void Assignment1()
            {
                int[] transactions = { 200, -150, 340, 500, -100 };
                int totalSum = 0;

                foreach (int transaction in transactions)
                {
                    totalSum += transaction;
                }

                Console.WriteLine("Total Sum of Transactions: " + totalSum);
            }
        }

            class A1Q2
            {

                public void Assignment2()
                {

                    float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
                    float total = 0.0f;

                    foreach (float score in scores)
                    {
                        total += score;
                    }

                    float average = total / scores.Length;
                Console.WriteLine("total scores :" + total);

                }

            }
            
          class A1Q3
        {
            public void Assignment3()
            {

            }

        }

        }

    }


       


