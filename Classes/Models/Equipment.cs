using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTagFinder.Classes.Models
{
	public class Equipment
	{
		private int _EquipmentID;
		public int EquipmentID
		{
			get { return _EquipmentID; }
			set { _EquipmentID = value; }
		}

		private int _EquipmentTypeID;
		public int EquipmentTypeID
		{
			get { return _EquipmentTypeID; }
			set { _EquipmentTypeID = value; }
		}

		private int _UnitID;
		public int UnitID
		{
			get { return _UnitID; }
			set { _UnitID = value; }
		}

		private string _Latitude;
		public string Latitude
		{
			get { return _Latitude; }
			set { _Latitude = value; }
		}

		private string _Longitude;
		public string Longitude
		{
			get { return _Longitude; }
			set { _Longitude = value; }
		}

		private int? _XOffset;
		public int? XOffset
		{
			get { return _XOffset; }
			set { _XOffset = value; }
		}

		private int? _YOffset;
		public int? YOffset
		{
			get { return _YOffset; }
			set { _YOffset = value; }
		}

		private bool? _IsDatum;
		public bool? IsDatum
		{
			get { return _IsDatum; }
			set { _IsDatum = value; }
		}

		private string _Tag;
		public string Tag
		{
			get { return _Tag; }
			set { _Tag = value; }
		}


		public Equipment(int EquipmentID_, int EquipmentTypeID_, int UnitID_, string Latitude_, string Longitude_, int? XOffset_, int? YOffset_, bool? IsDatum_, string Tag_)
		{
			this.EquipmentID = EquipmentID_;
			this.EquipmentTypeID = EquipmentTypeID_;
			this.UnitID = UnitID_;
			this.Latitude = Latitude_;
			this.Longitude = Longitude_;
			this.XOffset = XOffset_;
			this.YOffset = YOffset_;
			this.IsDatum = IsDatum_;
			this.Tag = Tag_;
		}
        public Equipment()
        {

        }
	}
}
