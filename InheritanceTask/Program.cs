
using Task.Inheritance;

string username;
string password;
while (true)
{
    Console.Write("Enter username: ");
    username = Console.ReadLine();
    User user = new User(username, "password");
    if (user.isValidUsername())
    {
        break;
    }
    else
    {
        Console.WriteLine("Username uzunlugu 6dan boyuk olmalidir");
    }
}

    while (true)
    {
        Console.Write("Enter password: ");
        password = Console.ReadLine();
        User user1 = new User(username, password);
        if (user1.isValidPassword())
        {
            break;
        }
        else
        {
            Console.WriteLine("Password 1 reqem ve 1 boyuk herf olsun en azi");
        }
    }
    string email;
    while (true)
    {
        Console.Write("Enter email ");
        email = Console.ReadLine();
        User user2 = new User(username, password, email);
        if (user2.CheckEmail())
        {
            break;
        }
        else
        {
            Console.WriteLine("Email düzgün formatda deyil!");
        }
    }
    Console.WriteLine("Enter isSuper admin (true/false): ");
    bool isSuperAdmin = bool.Parse(Console.ReadLine());
    Console.WriteLine("Enter section: ");
    string section = Console.ReadLine();

    Admin admin = new Admin(username, password, isSuperAdmin, section,email);
    admin.ShowInfo();