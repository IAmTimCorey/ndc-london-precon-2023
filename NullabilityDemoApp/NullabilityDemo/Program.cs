using NullabilityDemo;

UserClass user = new UserClass { LastName = "Corey" };

Console.WriteLine(user.LastName?.Length);