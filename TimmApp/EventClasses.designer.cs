﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimmApp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="aspnet-TimmApp-20151030094331")]
	public partial class EventClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    #endregion
		
		public EventClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TimmDbContext"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EventClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EventClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _eventStart;
		
		private System.DateTime _eventEnd;
		
		private System.Nullable<int> _employee_EmployeeId;
		
		private string _text;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OneventStartChanging(System.DateTime value);
    partial void OneventStartChanged();
    partial void OneventEndChanging(System.DateTime value);
    partial void OneventEndChanged();
    partial void Onemployee_EmployeeIdChanging(System.Nullable<int> value);
    partial void Onemployee_EmployeeIdChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    #endregion
		
		public Event()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventStart", DbType="DateTime NOT NULL")]
		public System.DateTime eventStart
		{
			get
			{
				return this._eventStart;
			}
			set
			{
				if ((this._eventStart != value))
				{
					this.OneventStartChanging(value);
					this.SendPropertyChanging();
					this._eventStart = value;
					this.SendPropertyChanged("eventStart");
					this.OneventStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eventEnd", DbType="DateTime NOT NULL")]
		public System.DateTime eventEnd
		{
			get
			{
				return this._eventEnd;
			}
			set
			{
				if ((this._eventEnd != value))
				{
					this.OneventEndChanging(value);
					this.SendPropertyChanging();
					this._eventEnd = value;
					this.SendPropertyChanged("eventEnd");
					this.OneventEndChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_EmployeeId", DbType="Int")]
		public System.Nullable<int> employee_EmployeeId
		{
			get
			{
				return this._employee_EmployeeId;
			}
			set
			{
				if ((this._employee_EmployeeId != value))
				{
					this.Onemployee_EmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._employee_EmployeeId = value;
					this.SendPropertyChanged("employee_EmployeeId");
					this.Onemployee_EmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="NVarChar(MAX)")]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
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
}
#pragma warning restore 1591
