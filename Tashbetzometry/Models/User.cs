using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tashbetzometry.Models.DAL;

namespace Tashbetzometry.Models
{
	public class User
	{
		string mail;
		string userName;
		string password;
		string firstName;
		string lastName;
		string image;

		public User()
		{

		}

		public User(string mail, string userName, string password, string firstName, string lastName, string image)
		{
			Mail = mail;
			UserName = userName;
			Password = password;
			FirstName = firstName;
			LastName = lastName;
			Image = image;
		}

		public User(string mail, string password)
		{
			Mail = mail;
			Password = password;
		}

		public string Mail { get => mail; set => mail = value; }
		public string Password { get => password; set => password = value; }
		public string UserName { get => userName; set => userName = value; }
		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public string Image { get => image; set => image = value; }

		//login
		public User GetUserFromDB(string mail, string password)
		{
			DBService db = new DBService();
			return db.GetUserFromDB(mail, password);
		}

		//register
		public int InsertUserToServer(User user)
		{
			DBService db = new DBService();
			int numAffected = db.InsertUserToDB(user);
			return numAffected;
		}

		//forgetPassword
		public User GetForgetPassFromDB(string mail)
		{
			DBService db = new DBService();
			return db.GetForgetPassFromDB(mail);
		}

		//update paassword
		public int UpdatePasswordDB(User user)
		{
			DBService db = new DBService();
			return db.UpdatePasswordDB(user);
		}
	}
}