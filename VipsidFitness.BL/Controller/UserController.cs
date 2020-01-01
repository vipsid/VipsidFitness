using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using VipsidFitness.BL.Model;

namespace VipsidFitness.BL.Controller
{
	/// <summary>
	/// User controller.
	/// </summary>
	public class UserController
	{
		/// <summary>
		/// Application user.
		/// </summary>
		public User User { get; }

		/// <summary>
		/// Create a new user controller.
		/// </summary>
		/// <param name="user"></param>
		public UserController(string userName, 
			                  string genderName, 
							  DateTime birthDay,
					          double weight,
					          double height)
		{
			// TODO: Check

			var gender = new Gender(genderName);
			User = new User(userName, gender, birthDay, weight, height);
		}

		/// <summary>
		/// Save user data.
		/// </summary>
		public void Save()
		{
			var formatter = new BinaryFormatter();

			using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, User);
			}
		}

		/// <summary>
		/// Get user data.
		/// </summary>
		/// <returns> Application user. </returns>
		public UserController()
		{
			var formatter = new BinaryFormatter();

			using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
			{
				if(formatter.Deserialize(fs) is User user)
				{
					User = user;
				}

				// TODO: What to do if the user is not read?
			}
		}
	}
}
