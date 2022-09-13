using System;

namespace sharpC
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] email = new string[3];
            string[] username = new string[3];
            string[] password = new string[3];

            //User Credentials

            //user0
            email[0] = "jayrenzo21@gmail.com";
            username[0] = "ennzzo";
            password[0] = "Zxcvbnm21@";

            //user1
            email[1] = "kaixue21@gmail.com";
            username[1] = "xueee";
            password[1] = "kai2X!";

            //user2
            email[2] = "hyourin30@gmail.com";
            username[2] = "farside";
            password[2] = "moon30@@";


            for (int i = 0; i < email.Length; i++)
            {
                Console.WriteLine($"Index: {i}");
                Console.WriteLine($"Email: {email[i]}");
                Console.WriteLine($"Username: {username[i]}");
                Console.WriteLine($"Password: {password[i]}");

                Console.WriteLine();
            }
        }
    }
}
