using Encapsulation;

User[] users = new User[3];
for (int i = 0; i < users.Length; i++)
{
    Console.WriteLine("Fullname daxil edin:");
    string fullname = Console.ReadLine();
    Console.WriteLine("Email daxil edin:");
    string email = Console.ReadLine();
    while (true)
    {
        Console.WriteLine("Password daxil edin:");
        string password = Console.ReadLine();
        User user = new User(email, password);
        if (user.PasswordChecker(password))
        {
            user.Fullname = fullname; users[i] = user;
            break;
        }
        else
        {
            Console.WriteLine("Password sertlerini odemir, yeniden cehd edin.");
        }
    }



}

bool isFound = true;
while (isFound)
{
    Console.WriteLine("1. Show all users");
    Console.WriteLine("2. Get info by id");
    Console.WriteLine("0. Quit");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            foreach (var user in users)
            {
                user.GetInfo();
            }
            break;

        case 2:
            Console.WriteLine("Id daxil edin:");
            int id = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    user.GetInfo();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("User tapilmadi.");
            }
            break;

        case 0:
            isFound = false;
            break;

        default:
            Console.WriteLine("Yanlis secim.");
            break;
    }
}