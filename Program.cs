using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your ID code:");
            string usersID = Console.ReadLine();
            Console.WriteLine("Enter Your credit card information:");
            string Creditcard = Console.ReadLine();
            Console.WriteLine("Ener your Credit card CVV:");
            string CVValidation = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);

            }
            else
            {
                Console.WriteLine("Wrong format. Try again.");
            }

            if (Credit(Creditcard))
            {
                Console.WriteLine("Your card has been accepted");
                CVV(CVValidation);
            }
            else
            {
                Console.WriteLine("Your card has been declined");
            }




        }

        public static bool Validate(string idCode)
        {
            if (idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong formar: {e}");
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            // || - alt gr + <>
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");
            }
            else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }




        }

        public static bool Credit(string CardInf)
        {
            if (CardInf.Length == 16)
            {
                try
                {
                    long.Parse(CardInf);
                    return true;
                }
                catch (Exception a)
                {
                    Console.WriteLine($"Wrong formar: {a}");
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
        public static bool CVV(string CVValidation)
        {
            if (CVValidation.Length == 3)
            {
                try
                {
                    long.Parse(CVValidation);
                    return true;
                }
                catch (Exception b)
                {
                    Console.WriteLine($"Wrong formar: {b}");
                    return false;
                }

            }
            else
            {
                return false;
            
            }

            }
    }
}
