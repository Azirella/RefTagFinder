using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class UserPermission
	{
		private int _UserID;
		public int UserID
		{
			get { return _UserID; }
			set { _UserID = value; }
		}

		private string _PermissionCode;
		public string PermissionCode
		{
			get { return _PermissionCode; }
			set { _PermissionCode = value; }
		}


		public UserPermission(int UserID_, string PermissionCode_)
		{
			this.UserID = UserID_;
			this.PermissionCode = PermissionCode_;
		}
	}
}
