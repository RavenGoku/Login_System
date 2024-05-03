using System.Security.Cryptography.X509Certificates;

namespace Challenge_Login_System
{
    internal class Program
    {
        // static

        private static void Main(string[] args)
        {
            string userName = "";
            string password = "";
            bool isRegistered = false;

            Register(ref userName, ref password);

            Login(userName, password, RegistrationCheck(userName, password));

            Console.Read();
        }

        // ********************************************************************************
        /// <summary>
        /// calling function with two parameters by reference(addresses) not by value because we don't
        /// want to work with copies but make changes in original variables.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        // <created>Kamil Mikolajewski,03/05/2024</created>
        // <changed>Kamil Mikolajewski,03/05/2024</changed>
        // ********************************************************************************
        public static void Register(ref string userName, ref string password)
        {
            //input username and password to register in the system
            Console.WriteLine("Please input username and password to register.\n");
            Console.Write("Please input username:");
            userName = Console.ReadLine();
            Console.Write("Please input password:");
            password = Console.ReadLine();
        }

        // ********************************************************************************
        /// <summary>
        /// Function that check if user input both userName and password,
        /// 'if_else' statements are nested and proper information will pop up.
        /// either register was successful or not.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        // <created>Kamil Mikolajewski,03/05/2024</created>
        // <changed>Kamil Mikolajewski,03/05/2024</changed>
        // ********************************************************************************
        public static bool RegistrationCheck(string user, string password)
        {
            bool isRegister = false;

            if (user != "" && password != "")
            {
                isRegister = true;
                Console.WriteLine($"Registration Successful.");
                Console.WriteLine($"-----------------------------------.");
                //you can turn on/off displaying username and password. simply comment or uncomment line below
                //Console.WriteLine($"Your username:{user}\nYour password:{password}");
                Console.WriteLine("You can login to the system now.");
            }
            else
            {
                isRegister = false;
                Console.WriteLine($"Registration Failed.\nYou left username or password empty!");
            }
            return isRegister;
        }

        // ********************************************************************************
        /// <summary>
        /// Function compares user input with stored user and password variables
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <param name="isRegister"></param>
        // <created>Kamil Mikolajewski,03/05/2024</created>
        // <changed>Kamil Mikolajewski,03/05/2024</changed>
        // ********************************************************************************
        public static void Login(string user, string password, bool isRegister)
        {
            if (isRegister && user != "" && password != "")
            {
                string tempUserName;
                string tempPassword;

                Console.Write("\nEnter your username:");
                tempUserName = Console.ReadLine();
                Console.Write("Enter your password:");
                tempPassword = Console.ReadLine();
                if (tempUserName.Equals(user) && tempPassword.Equals(password))
                {
                    Console.WriteLine($"Login successful!\nHello {user}!");
                }
                else
                {
                    Console.WriteLine($"Login failed!\nYour username and password doesn't match!");
                }
            }
            else
            {
                Console.WriteLine("You are not registered, Try Again!");
            }
        }
    }
}