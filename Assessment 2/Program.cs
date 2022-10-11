namespace Assessment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+\n| Welcome to the Auction House |\n+------------------------------+");
            Console.WriteLine(" ");
            Console.WriteLine("Main Menu\n-------- -\n(1) Register\n(2) Sign In\n(3) Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Testing");            
            bool run = true;
            do
            {
                Console.WriteLine("Please select an option between 1 and 3: ");
                bool option = Int32.TryParse(Console.ReadLine(), out int optionValue);
                if (option)
                {
                    if (optionValue < 3 && optionValue > 0)
                    {
                        if (optionValue == 1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Registration\n------------");
                            Console.WriteLine(" ");
                            Console.WriteLine("Please enter your name");
                            string username = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.WriteLine("Please enter your email address");
                            string email = Console.ReadLine();
                            Console.WriteLine(" ");
                            Console.WriteLine("Please choose a password\n* At least 8 characters\n* No white space characters\n* At least one upper -case letter\n* At least one lower -case letter\n* At least one digit\n* At least one special character");
                            string password = Console.ReadLine();
                            bool valid = false;
                            //PASSWORD INPUT CRITERIA
                            if (password.Length > 7 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                            {
                                valid = true;
                            }
                            else
                            {
                                Console.WriteLine("Password does not match criteria! Register failed.");
                                run = false;
                            }
                            if (valid)
                            {
                                Console.WriteLine("Registered real!");  
                            }
                        }
                    }
                    if (optionValue > 2 || optionValue < 1)
                    {
                        Console.WriteLine("+--------------------------------------------------+\n| Good bye, thank you for using the Auction House! |\n+--------------------------------------------------+");
                        run = false;
                    }

                }
            } while (run);
            Console.WriteLine("+--------------------------------------------------+\n| Good bye, thank you for using the Auction House! |\n+--------------------------------------------------+");

            Environment.Exit(0);
        }
    }
}