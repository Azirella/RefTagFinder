using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class EquipmentType
	{
		private int _EquipmentTypeID;
		public int EquipmentTypeID
		{
			get { return _EquipmentTypeID; }
			set { _EquipmentTypeID = value; }
		}

		private string _EquipmentName;
		public string EquipmentName
		{
			get { return _EquipmentName; }
			set { _EquipmentName = value; }
		}

		private int? _X;
		public int? X
		{
			get { return _X; }
			set { _X = value; }
		}

		private int? _Y;
		public int? Y
		{
			get { return _Y; }
			set { _Y = value; }
		}


		public EquipmentType(int EquipmentTypeID_, string EquipmentName_, int? X_, int? Y_)
		{
			this.EquipmentTypeID = EquipmentTypeID_;
			this.EquipmentName = EquipmentName_;
			this.X = X_;
			this.Y = Y_;
		}

        public EquipmentType()
        {

        }
	}
}
