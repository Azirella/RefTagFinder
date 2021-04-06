using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class LoginLog
	{
		private int _UserID;
		public int UserID
		{
			get { return _UserID; }
			set { _UserID = value; }
		}

		private DateTime _TimeOfLogin;
		public DateTime TimeOfLogin
		{
			get { return _TimeOfLogin; }
			set { _TimeOfLogin = value; }
		}

		private DateTime? _TimeOfLogout;
		public DateTime? TimeOfLogout
		{
			get { return _TimeOfLogout; }
			set { _TimeOfLogout = value; }
		}


		public LoginLog(int UserID_, DateTime TimeOfLogin_, DateTime? TimeOfLogout_)
		{
			this.UserID = UserID_;
			this.TimeOfLogin = TimeOfLogin_;
			this.TimeOfLogout = TimeOfLogout_;
		}
	}
}
