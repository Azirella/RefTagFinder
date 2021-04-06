using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class User
	{
		private int _UserID;
		public int UserID
		{
			get { return _UserID; }
			set { _UserID = value; }
		}

		private string _Username;
		public string Username
		{
			get { return _Username; }
			set { _Username = value; }
		}

		private string _Password;
		public string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}

		private DateTime _TimeOfRegister;
		public DateTime TimeOfRegister
		{
			get { return _TimeOfRegister; }
			set { _TimeOfRegister = value; }
		}


		public User(int UserID_, string Username_, string Password_, DateTime TimeOfRegister_)
		{
			this.UserID = UserID_;
			this.Username = Username_;
			this.Password = Password_;
			this.TimeOfRegister = TimeOfRegister_;
		}
	}
}
