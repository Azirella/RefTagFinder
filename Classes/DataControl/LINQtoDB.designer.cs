﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RefTagFinder.Classes.DataControl
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
    using System.IO;
    using System.Windows.Forms;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ref5thDBSQL")]
	public partial class LINQtoDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUnit(Unit instance);
    partial void UpdateUnit(Unit instance);
    partial void DeleteUnit(Unit instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertEquipment(Equipment instance);
    partial void UpdateEquipment(Equipment instance);
    partial void DeleteEquipment(Equipment instance);
    partial void InsertEquipmentType(EquipmentType instance);
    partial void UpdateEquipmentType(EquipmentType instance);
    partial void DeleteEquipmentType(EquipmentType instance);
    #endregion
		
		public LINQtoDBDataContext() : 
				base(global::RefTagFinder.Properties.Settings.Default.Ref5thDBSQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Unit> Units
		{
			get
			{
				return this.GetTable<Unit>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserPermission> UserPermissions
		{
			get
			{
				return this.GetTable<UserPermission>();
			}
		}
		
		public System.Data.Linq.Table<LoginLog> LoginLogs
		{
			get
			{
				return this.GetTable<LoginLog>();
			}
		}
		
		public System.Data.Linq.Table<Equipment> Equipments
		{
			get
			{
				return this.GetTable<Equipment>();
			}
		}
		
		public System.Data.Linq.Table<EquipmentType> EquipmentTypes
		{
			get
			{
				return this.GetTable<EquipmentType>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectTable")]
		public ISingleResult<SelectTableResult> SelectTable([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tblName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tblName, iD);
			return ((ISingleResult<SelectTableResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateTable")]
		public ISingleResult<UpdateTableResult> UpdateTable(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tblName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitID", DbType="Int")] System.Nullable<int> unitID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitName", DbType="NVarChar(50)")] string unitName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PIDPath", DbType="NVarChar(MAX)")] string pIDPath, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ImagePath", DbType="NVarChar(MAX)")] string imagePath, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(50)")] string userName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfRegister", DbType="DateTime")] System.Nullable<System.DateTime> timeOfRegister, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfLogin", DbType="DateTime")] System.Nullable<System.DateTime> timeOfLogin, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfLogout", DbType="DateTime")] System.Nullable<System.DateTime> timeOfLogout, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentTypeID", DbType="Int")] System.Nullable<int> equipmentTypeID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentName", DbType="NVarChar(50)")] string equipmentName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="X_", DbType="Int")] System.Nullable<int> x_, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Y_", DbType="Int")] System.Nullable<int> y_, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentID", DbType="Int")] System.Nullable<int> equipmentID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentTypeID2", DbType="Int")] System.Nullable<int> equipmentTypeID2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitID2", DbType="Int")] System.Nullable<int> unitID2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Latitude", DbType="NVarChar(50)")] string latitude, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Longitude", DbType="NVarChar(50)")] string longitude, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="XOffset", DbType="Int")] System.Nullable<int> xOffset, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="YOffset", DbType="Int")] System.Nullable<int> yOffset, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsDatum", DbType="Bit")] System.Nullable<bool> isDatum, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tag", DbType="NVarChar(50)")] string tag, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID2", DbType="Int")] System.Nullable<int> userID2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PermissionCode", DbType="NVarChar(10)")] string permissionCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Temp", DbType="Int")] System.Nullable<int> temp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tblName, iD, unitID, unitName, pIDPath, imagePath, userName, password, timeOfRegister, userID, timeOfLogin, timeOfLogout, equipmentTypeID, equipmentName, x_, y_, equipmentID, equipmentTypeID2, unitID2, latitude, longitude, xOffset, yOffset, isDatum, tag, userID2, permissionCode, temp);
			return ((ISingleResult<UpdateTableResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertToTable")]
		public ISingleResult<InsertToTableResult> InsertToTable(
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tblName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitName", DbType="NVarChar(50)")] string unitName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PIDPath", DbType="NVarChar(MAX)")] string pIDPath, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ImagePath", DbType="NVarChar(MAX)")] string imagePath, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="NVarChar(50)")] string userName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(50)")] string password, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfRegister", DbType="DateTime")] System.Nullable<System.DateTime> timeOfRegister, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID", DbType="Int")] System.Nullable<int> userID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfLogin", DbType="DateTime")] System.Nullable<System.DateTime> timeOfLogin, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TimeOfLogout", DbType="DateTime")] System.Nullable<System.DateTime> timeOfLogout, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentTypeID", DbType="Int")] System.Nullable<int> equipmentTypeID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentName", DbType="NVarChar(50)")] string equipmentName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="X_", DbType="Int")] System.Nullable<int> x_, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Y_", DbType="Int")] System.Nullable<int> y_, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentID", DbType="Int")] System.Nullable<int> equipmentID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="EquipmentTypeID2", DbType="Int")] System.Nullable<int> equipmentTypeID2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UnitID", DbType="Int")] System.Nullable<int> unitID, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Latitude", DbType="NVarChar(50)")] string latitude, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Longitude", DbType="NVarChar(50)")] string longitude, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="XOffset", DbType="Int")] System.Nullable<int> xOffset, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="YOffset", DbType="Int")] System.Nullable<int> yOffset, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsDatum", DbType="Bit")] System.Nullable<bool> isDatum, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tag", DbType="NVarChar(50)")] string tag, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserID2", DbType="Int")] System.Nullable<int> userID2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="PermissionCode", DbType="NVarChar(10)")] string permissionCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Temp", DbType="Int")] System.Nullable<int> temp)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tblName, iD, unitName, pIDPath, imagePath, userName, password, timeOfRegister, userID, timeOfLogin, timeOfLogout, equipmentTypeID, equipmentName, x_, y_, equipmentID, equipmentTypeID2, unitID, latitude, longitude, xOffset, yOffset, isDatum, tag, userID2, permissionCode, temp);
			return ((ISingleResult<InsertToTableResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteFromTable")]
		public int DeleteFromTable([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string tblName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tblName, iD);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Unit")]
	public partial class Unit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UnitID;
		
		private string _UnitName;
		
		private string _PIDPath;
		
		private string _ImagePath;
		
		private EntitySet<Equipment> _Equipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUnitIDChanging(int value);
    partial void OnUnitIDChanged();
    partial void OnUnitNameChanging(string value);
    partial void OnUnitNameChanged();
    partial void OnPIDPathChanging(string value);
    partial void OnPIDPathChanged();
    partial void OnImagePathChanging(string value);
    partial void OnImagePathChanged();
    partial void OnisValidChanging(string value);
    partial void OnisValidChanged();
    #endregion
		
		public Unit()
		{
			this._Equipments = new EntitySet<Equipment>(new Action<Equipment>(this.attach_Equipments), new Action<Equipment>(this.detach_Equipments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					this.OnUnitIDChanging(value);
					this.SendPropertyChanging();
					this._UnitID = value;
					this.SendPropertyChanged("UnitID");
					this.OnUnitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this.OnUnitNameChanging(value);
					this.SendPropertyChanging();
					this._UnitName = value;
					this.SendPropertyChanged("UnitName");
					this.OnUnitNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIDPath", DbType="NVarChar(MAX)")]
		public string PIDPath
		{
			get
			{
				return this._PIDPath;
			}
			set
			{
				if ((this._PIDPath != value))
				{
					this.OnPIDPathChanging(value);
					this.SendPropertyChanging();
					this._PIDPath = value;
					this.SendPropertyChanged("PIDPath");
					this.OnPIDPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="NVarChar(MAX)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this.OnImagePathChanging(value);
					this.SendPropertyChanging();
					this._ImagePath = value;
					this.SendPropertyChanged("ImagePath");
					this.OnImagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isValid", CanBeNull=false)]
		

		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Unit_Equipment", Storage="_Equipments", ThisKey="UnitID", OtherKey="UnitID")]
		public EntitySet<Equipment> Equipments
		{
			get
			{
				return this._Equipments;
			}
			set
			{
				this._Equipments.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Equipments(Equipment entity)
		{
			this.SendPropertyChanging();
			entity.Unit = this;
		}
		
		private void detach_Equipments(Equipment entity)
		{
			this.SendPropertyChanging();
			entity.Unit = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Username;
		
		private string _Password;
		
		private System.DateTime _TimeOfRegister;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnTimeOfRegisterChanging(System.DateTime value);
    partial void OnTimeOfRegisterChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeOfRegister", DbType="DateTime NOT NULL")]
		public System.DateTime TimeOfRegister
		{
			get
			{
				return this._TimeOfRegister;
			}
			set
			{
				if ((this._TimeOfRegister != value))
				{
					this.OnTimeOfRegisterChanging(value);
					this.SendPropertyChanging();
					this._TimeOfRegister = value;
					this.SendPropertyChanged("TimeOfRegister");
					this.OnTimeOfRegisterChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPermission")]
	public partial class UserPermission
	{
		
		private int _UserID;
		
		private string _PermissionCode;
		
		public UserPermission()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionCode", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string PermissionCode
		{
			get
			{
				return this._PermissionCode;
			}
			set
			{
				if ((this._PermissionCode != value))
				{
					this._PermissionCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginLog")]
	public partial class LoginLog
	{
		
		private int _UserID;
		
		private System.DateTime _TimeOfLogin;
		
		private System.Nullable<System.DateTime> _TimeOfLogout;
		
		public LoginLog()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeOfLogin", DbType="DateTime NOT NULL")]
		public System.DateTime TimeOfLogin
		{
			get
			{
				return this._TimeOfLogin;
			}
			set
			{
				if ((this._TimeOfLogin != value))
				{
					this._TimeOfLogin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeOfLogout", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeOfLogout
		{
			get
			{
				return this._TimeOfLogout;
			}
			set
			{
				if ((this._TimeOfLogout != value))
				{
					this._TimeOfLogout = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Equipment")]
	public partial class Equipment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EquipmentID;
		
		private int _EquipmentTypeID;
		
		private int _UnitID;
		
		private string _Latitude;
		
		private string _Longitude;
		
		private System.Nullable<int> _XOffset;
		
		private System.Nullable<int> _YOffset;
		
		private System.Nullable<bool> _IsDatum;
		
		private string _Tag;
		
		private EntityRef<Unit> _Unit;
		
		private EntityRef<EquipmentType> _EquipmentType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEquipmentIDChanging(int value);
    partial void OnEquipmentIDChanged();
    partial void OnEquipmentTypeIDChanging(int value);
    partial void OnEquipmentTypeIDChanged();
    partial void OnUnitIDChanging(int value);
    partial void OnUnitIDChanged();
    partial void OnLatitudeChanging(string value);
    partial void OnLatitudeChanged();
    partial void OnLongitudeChanging(string value);
    partial void OnLongitudeChanged();
    partial void OnXOffsetChanging(System.Nullable<int> value);
    partial void OnXOffsetChanged();
    partial void OnYOffsetChanging(System.Nullable<int> value);
    partial void OnYOffsetChanged();
    partial void OnIsDatumChanging(System.Nullable<bool> value);
    partial void OnIsDatumChanged();
    partial void OnTagChanging(string value);
    partial void OnTagChanged();
    #endregion
		
		public Equipment()
		{
			this._Unit = default(EntityRef<Unit>);
			this._EquipmentType = default(EntityRef<EquipmentType>);
			OnCreated();
		}

		

		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EquipmentID
		{
			get
			{
				return this._EquipmentID;
			}
			set
			{
				if ((this._EquipmentID != value))
				{
					this.OnEquipmentIDChanging(value);
					this.SendPropertyChanging();
					this._EquipmentID = value;
					this.SendPropertyChanged("EquipmentID");
					this.OnEquipmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentTypeID", DbType="Int NOT NULL")]
		public int EquipmentTypeID
		{
			get
			{
				return this._EquipmentTypeID;
			}
			set
			{
				if ((this._EquipmentTypeID != value))
				{
					if (this._EquipmentType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEquipmentTypeIDChanging(value);
					this.SendPropertyChanging();
					this._EquipmentTypeID = value;
					this.SendPropertyChanged("EquipmentTypeID");
					this.OnEquipmentTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int NOT NULL")]
		public int UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					if (this._Unit.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUnitIDChanging(value);
					this.SendPropertyChanging();
					this._UnitID = value;
					this.SendPropertyChanged("UnitID");
					this.OnUnitIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="NVarChar(50)")]
		public string Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="NVarChar(50)")]
		public string Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XOffset", DbType="Int")]
		public System.Nullable<int> XOffset
		{
			get
			{
				return this._XOffset;
			}
			set
			{
				if ((this._XOffset != value))
				{
					this.OnXOffsetChanging(value);
					this.SendPropertyChanging();
					this._XOffset = value;
					this.SendPropertyChanged("XOffset");
					this.OnXOffsetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YOffset", DbType="Int")]
		public System.Nullable<int> YOffset
		{
			get
			{
				return this._YOffset;
			}
			set
			{
				if ((this._YOffset != value))
				{
					this.OnYOffsetChanging(value);
					this.SendPropertyChanging();
					this._YOffset = value;
					this.SendPropertyChanged("YOffset");
					this.OnYOffsetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDatum", DbType="Bit")]
		public System.Nullable<bool> IsDatum
		{
			get
			{
				return this._IsDatum;
			}
			set
			{
				if ((this._IsDatum != value))
				{
					this.OnIsDatumChanging(value);
					this.SendPropertyChanging();
					this._IsDatum = value;
					this.SendPropertyChanged("IsDatum");
					this.OnIsDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tag", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Tag
		{
			get
			{
				return this._Tag;
			}
			set
			{
				if ((this._Tag != value))
				{
					this.OnTagChanging(value);
					this.SendPropertyChanging();
					this._Tag = value;
					this.SendPropertyChanged("Tag");
					this.OnTagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Unit_Equipment", Storage="_Unit", ThisKey="UnitID", OtherKey="UnitID", IsForeignKey=true)]
		public Unit Unit
		{
			get
			{
				return this._Unit.Entity;
			}
			set
			{
				Unit previousValue = this._Unit.Entity;
				if (((previousValue != value) 
							|| (this._Unit.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Unit.Entity = null;
						previousValue.Equipments.Remove(this);
					}
					this._Unit.Entity = value;
					if ((value != null))
					{
						value.Equipments.Add(this);
						this._UnitID = value.UnitID;
					}
					else
					{
						this._UnitID = default(int);
					}
					this.SendPropertyChanged("Unit");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EquipmentType_Equipment", Storage="_EquipmentType", ThisKey="EquipmentTypeID", OtherKey="EquipmentTypeID", IsForeignKey=true)]
		public EquipmentType EquipmentType
		{
			get
			{
				return this._EquipmentType.Entity;
			}
			set
			{
				EquipmentType previousValue = this._EquipmentType.Entity;
				if (((previousValue != value) 
							|| (this._EquipmentType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EquipmentType.Entity = null;
						previousValue.Equipments.Remove(this);
					}
					this._EquipmentType.Entity = value;
					if ((value != null))
					{
						value.Equipments.Add(this);
						this._EquipmentTypeID = value.EquipmentTypeID;
					}
					else
					{
						this._EquipmentTypeID = default(int);
					}
					this.SendPropertyChanged("EquipmentType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EquipmentType")]
	public partial class EquipmentType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EquipmentTypeID;
		
		private string _EquipmentName;
		
		private System.Nullable<int> _X_;
		
		private System.Nullable<int> _Y_;
		
		private EntitySet<Equipment> _Equipments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEquipmentTypeIDChanging(int value);
    partial void OnEquipmentTypeIDChanged();
    partial void OnEquipmentNameChanging(string value);
    partial void OnEquipmentNameChanged();
    partial void OnX_Changing(System.Nullable<int> value);
    partial void OnX_Changed();
    partial void OnY_Changing(System.Nullable<int> value);
    partial void OnY_Changed();
    #endregion
		
		public EquipmentType()
		{
			this._Equipments = new EntitySet<Equipment>(new Action<Equipment>(this.attach_Equipments), new Action<Equipment>(this.detach_Equipments));
			OnCreated();
		}

		


		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentTypeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EquipmentTypeID
		{
			get
			{
				return this._EquipmentTypeID;
			}
			set
			{
				if ((this._EquipmentTypeID != value))
				{
					this.OnEquipmentTypeIDChanging(value);
					this.SendPropertyChanging();
					this._EquipmentTypeID = value;
					this.SendPropertyChanged("EquipmentTypeID");
					this.OnEquipmentTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EquipmentName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EquipmentName
		{
			get
			{
				return this._EquipmentName;
			}
			set
			{
				if ((this._EquipmentName != value))
				{
					this.OnEquipmentNameChanging(value);
					this.SendPropertyChanging();
					this._EquipmentName = value;
					this.SendPropertyChanged("EquipmentName");
					this.OnEquipmentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_X_", DbType="Int")]
		public System.Nullable<int> X_
		{
			get
			{
				return this._X_;
			}
			set
			{
				if ((this._X_ != value))
				{
					this.OnX_Changing(value);
					this.SendPropertyChanging();
					this._X_ = value;
					this.SendPropertyChanged("X_");
					this.OnX_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Y_", DbType="Int")]
		public System.Nullable<int> Y_
		{
			get
			{
				return this._Y_;
			}
			set
			{
				if ((this._Y_ != value))
				{
					this.OnY_Changing(value);
					this.SendPropertyChanging();
					this._Y_ = value;
					this.SendPropertyChanged("Y_");
					this.OnY_Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EquipmentType_Equipment", Storage="_Equipments", ThisKey="EquipmentTypeID", OtherKey="EquipmentTypeID")]
		public EntitySet<Equipment> Equipments
		{
			get
			{
				return this._Equipments;
			}
			set
			{
				this._Equipments.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Equipments(Equipment entity)
		{
			this.SendPropertyChanging();
			entity.EquipmentType = this;
		}
		
		private void detach_Equipments(Equipment entity)
		{
			this.SendPropertyChanging();
			entity.EquipmentType = null;
		}
	}
	
	public partial class SelectTableResult
	{
		
		private int _UnitID;
		
		private string _UnitName;
		
		private string _PIDPath;
		
		private string _ImagePath;
		
		public SelectTableResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int NOT NULL")]
		public int UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					this._UnitID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this._UnitName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIDPath", DbType="NVarChar(MAX)")]
		public string PIDPath
		{
			get
			{
				return this._PIDPath;
			}
			set
			{
				if ((this._PIDPath != value))
				{
					this._PIDPath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="NVarChar(MAX)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this._ImagePath = value;
				}
			}
		}
	}
	
	public partial class UpdateTableResult
	{
		
		private int _UnitID;
		
		private string _UnitName;
		
		private string _PIDPath;
		
		private string _ImagePath;
		
		public UpdateTableResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int NOT NULL")]
		public int UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					this._UnitID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this._UnitName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIDPath", DbType="NVarChar(MAX)")]
		public string PIDPath
		{
			get
			{
				return this._PIDPath;
			}
			set
			{
				if ((this._PIDPath != value))
				{
					this._PIDPath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="NVarChar(MAX)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this._ImagePath = value;
				}
			}
		}
	}
	
	public partial class InsertToTableResult
	{
		
		private int _UnitID;
		
		private string _UnitName;
		
		private string _PIDPath;
		
		private string _ImagePath;
		
		public InsertToTableResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitID", DbType="Int NOT NULL")]
		public int UnitID
		{
			get
			{
				return this._UnitID;
			}
			set
			{
				if ((this._UnitID != value))
				{
					this._UnitID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UnitName
		{
			get
			{
				return this._UnitName;
			}
			set
			{
				if ((this._UnitName != value))
				{
					this._UnitName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PIDPath", DbType="NVarChar(MAX)")]
		public string PIDPath
		{
			get
			{
				return this._PIDPath;
			}
			set
			{
				if ((this._PIDPath != value))
				{
					this._PIDPath = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="NVarChar(MAX)")]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this._ImagePath = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
