namespace tema24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string username = "Andrei";
            const string password = "oradea23";
            string userInput, passwordInput;
            while (true)
            {
                Console.Write("Introduceti username:");
                userInput = Console.ReadLine();

                Console.Write("Introduceti parola:");
                passwordInput = Console.ReadLine();

                if (userInput == username && passwordInput == password)
                {
                    Console.Write("Bine ai venit,Andrei");
                    break;
                }
                else
                { Console.Write("Autentificare esuata"); }

            }
        }
    }
}