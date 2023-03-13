using System.Drawing;
using System.Transactions;

namespace _003A.FInalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string First;
            Console.Write("Enter First Name: ");
            First = Console.ReadLine();

            string Last;
            Console.Write("Enter Last Name: ");
            ; Last = Console.ReadLine();

            userName(Last, First);

            string age;
            Console.Write("Enter Birth Year: ");          
            age = Console.ReadLine();
            int number = Convert.ToInt32(age);

            int winner = ageUser(number);

            Console.Write(winner);
            Console.Write("\n");
            
            string gender;
            Console.WriteLine("Please Enter Gender: (M, F, O)");
            gender = Console.ReadLine();

            string q1;
            Console.WriteLine("Question 1: Do you take meds");
            q1 = Console.ReadLine();

            string q2;
            Console.WriteLine("Question 2: Do you play any sports");
            q2 = Console.ReadLine();

            string q3;
            Console.WriteLine("Question 3: Have you had any serious injuries");
            q3 = Console.ReadLine();

            string q4;
            Console.WriteLine("Question 4: How tall are you");
            q4 = Console.ReadLine();

            string q5;
            Console.WriteLine("Question 5: How much do you weigh");
            q5 = Console.ReadLine();

            string q6;
            Console.WriteLine("Question 6: Do you drink a lot of water");
            q6 = Console.ReadLine();

            string q7;
            Console.WriteLine("Question 7: Have you smoked");
            q7 = Console.ReadLine();

            string q8;
            Console.WriteLine("Question 8: Have you drank acholcol");
            q8 = Console.ReadLine();

            string q9;
            Console.WriteLine("Question 9: Have you ever passed out?");
            q9 = Console.ReadLine();

            string q10;
            Console.WriteLine("Question 10: Has blood ever come out while you were peeing?");
            q10 = Console.ReadLine();
        }

        static void userName(string lastName, string firstName)
        {
            Console.WriteLine($"{lastName}, {firstName}");
        }

        static int ageUser(int year)
        {
            return 2023 - year;
        }

        static void gen(string gender) 
        {
            if (gender == 'M') 
            {
                Console.WriteLine("Male");
            }

            if (gender == 'F') 
            {
                Console.WriteLine("Female");
            }

            if (gender == 'O') 
            {
                Console.WriteLine("Others not listed:");
            }
        }

    }
}