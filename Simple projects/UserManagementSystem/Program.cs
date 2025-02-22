namespace UserManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = [];

            while (true)
            {
                Console.WriteLine(value: "1. Add user");
                Console.WriteLine(value: "2. View all users");
                Console.WriteLine(value: "3. Search User by ID");
                Console.WriteLine(value: "4. Exit");

                Console.Write(value: "Enter your choice: ");

                string? choice = Console.ReadLine();

                if (!int.TryParse(s: choice, result: out int option))
                {
                    Console.WriteLine(value: "Invalid input for choice of operation!\n");

                    continue;
                }

                if (option < 1 || option > 4)
                {
                    Console.WriteLine(value: "The specified option does not exist!\n");

                    continue;
                }

                if (option == 4)
                {
                    Console.WriteLine(value: "Program successfully exited!");

                    Environment.Exit(exitCode: 0);
                }
                else if (option == 3)
                {
                    Console.Write(value: "Enter User ID: ");

                    string? userIdInput = Console.ReadLine();

                    if (!int.TryParse(s: userIdInput, result: out int userId))
                    {
                        Console.WriteLine(value: "Invalid input for user ID!\n");

                        continue;
                    }

                    User? user = null;

                    try
                    {
                        user = users.SingleOrDefault(predicate: x => x.Id == userId);
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine(value: "Multiple users exist with the specified ID! Program will now terminate!");

                        Environment.Exit(exitCode: -1);
                    }

                    if (user is null)
                    {
                        Console.WriteLine(value: "User Not Found\n");
                    }
                    else
                    {
                        Console.WriteLine(value: $"User Found -> {user}\n");
                    }
                }
                else if (option == 2)
                {
                    if (users.Count == 0)
                    {
                        Console.WriteLine(value: "There are no users added to the list!\n");

                        continue;
                    }

                    for (int i = 0; i < users.Count; i++)
                    {
                        Console.WriteLine(value: users[i]);
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.Write(value: "Enter User ID: ");

                    string? userIdInput = Console.ReadLine();

                    if (!int.TryParse(s: userIdInput, result: out int userId))
                    {
                        Console.WriteLine(value: "Invalid input for user ID!\n");

                        continue;
                    }

                    if (users.Exists(match: x => x.Id == userId))
                    {
                        Console.WriteLine(value: "The user with the specified ID already exists! Please enter another one!\n");

                        continue;
                    }

                    Console.Write(value: "Enter Name: ");

                    string? userName = Console.ReadLine();

                    if (string.IsNullOrEmpty(value: userName))
                    {
                        Console.WriteLine(value: "Invalid input for user name!\n");

                        continue;
                    }

                    Console.Write(value: "Enter Age: ");

                    string? ageInput = Console.ReadLine();

                    if (!int.TryParse(s: ageInput, result: out int userAge))
                    {
                        Console.WriteLine(value: "Invalid input for user age!\n");

                        continue;
                    }

                    users.Add(item: new(id: userId, name: userName, age: userAge));

                    Console.WriteLine(value: "User added successfully!\n");
                }
            }
        }
    }

    internal class User
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = default!;

        public int Age { get; private set; }

        public User() { }

        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }
}
