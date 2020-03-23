using System;
using System.Collections.Generic;
using login_cs.Model;

namespace login_cs
{
  class Program
  {
    static void Main(string[] args)
    {
      User Kristina = new User("kristina", "password1");
      User Luke = new User("luke", "password2");
      User Lincoln = new User("lincoln", "password3");


      Dictionary<string, User> users = new Dictionary<string, User>();
      users.Add(Kristina.Username.ToLower(), Kristina);
      users.Add(Luke.Username.ToLower(), Luke);
      users.Add(Lincoln.Username.ToLower(), Lincoln);

      Console.WriteLine("Hello World!");
      Console.WriteLine("Please Enter Your Username");
      string nameInput = Console.ReadLine().ToLower();
      Console.WriteLine("\nPlease Enter Your Password");
      string passwordInput = Console.ReadLine();

      if (users.ContainsKey(nameInput) && users[nameInput].ValidatePassword(passwordInput))
      {
        Console.WriteLine($"Successfully Logged In! \nWelcome {nameInput}");
      }
      else
      {
        Console.WriteLine($"Sorry, that username and password combo are incorrect!");
      }

    }
  }
}
