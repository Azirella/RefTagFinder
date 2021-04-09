using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class Unit
	{
		private int _UnitID;
		public int UnitID
		{
			get { return _UnitID; }
			set { _UnitID = value; }
		}

		private string _UnitName;
		public string UnitName
		{
			get { return _UnitName; }
			set { _UnitName = value; }
		}

		private string _PIDPath;
		public string PIDPath
		{
			get { return _PIDPath; }
			set { _PIDPath = value; }
		}

		private string _ImagePath;
		public string ImagePath
		{
			get { return _ImagePath; }
			set { _ImagePath = value; }
		}

        public bool IsValid 
		{ 
			get 
			{ 
				bool check = false;
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
				return check;
			} 
			 
		}

        public Unit(int UnitID_, string UnitName_, string PIDPath_, string ImagePath_)
		{
			this.UnitID = UnitID_;
			this.UnitName = UnitName_;
			this.PIDPath = PIDPath_;
			this.ImagePath = ImagePath_;
		}
        public Unit()
        {

        }
	}
}
