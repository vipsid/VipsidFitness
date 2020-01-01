using System;
using VipsidFitness.BL.Controller;

namespace VipsidFitness.CMD
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Welcome to VipsidFitness");

			Console.WriteLine("Enter name");
			var name = Console.ReadLine();

			Console.WriteLine("Enter gender");
			var gender = Console.ReadLine();

			Console.WriteLine("Enter date of birth");
			var birthdate = DateTime.Parse(Console.ReadLine()); // TODO Rewrite

			Console.WriteLine("Enter weight");
			var weight = double.Parse(Console.ReadLine());

			Console.WriteLine("Enter height");
			var height = double.Parse(Console.ReadLine());

			var userController = new UserController(name, gender, birthdate, weight, height);
			userController.Save();
		}
	}
}
