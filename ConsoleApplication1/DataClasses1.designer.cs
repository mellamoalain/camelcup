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

namespace ConsoleApplication1
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
	
	
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Camello> Camellos
		{
			get
			{
				return this.GetTable<Camello>();
			}
		}
		
		public System.Data.Linq.Table<Casilla> Casillas
		{
			get
			{
				return this.GetTable<Casilla>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Camello
	{
		
		private string _Id_camello;
		
		private string _Color;
		
		private string _Fk_casilla;
		
		private string _AlturaCasilla;
		
		private string _Dado;
		
		public Camello()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_camello", CanBeNull=false)]
		public string Id_camello
		{
			get
			{
				return this._Id_camello;
			}
			set
			{
				if ((this._Id_camello != value))
				{
					this._Id_camello = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", CanBeNull=false)]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this._Color = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fk_casilla", CanBeNull=false)]
		public string Fk_casilla
		{
			get
			{
				return this._Fk_casilla;
			}
			set
			{
				if ((this._Fk_casilla != value))
				{
					this._Fk_casilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AlturaCasilla", CanBeNull=false)]
		public string AlturaCasilla
		{
			get
			{
				return this._AlturaCasilla;
			}
			set
			{
				if ((this._AlturaCasilla != value))
				{
					this._AlturaCasilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dado", CanBeNull=false)]
		public string Dado
		{
			get
			{
				return this._Dado;
			}
			set
			{
				if ((this._Dado != value))
				{
					this._Dado = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Casilla
	{
		
		private string _Id_casilla;
		
		public Casilla()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_casilla", CanBeNull=false)]
		public string Id_casilla
		{
			get
			{
				return this._Id_casilla;
			}
			set
			{
				if ((this._Id_casilla != value))
				{
					this._Id_casilla = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
