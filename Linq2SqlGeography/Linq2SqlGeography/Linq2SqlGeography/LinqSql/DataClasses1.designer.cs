﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.454
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq2SqlGeography.LinqSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SqlSpatialJiangmeng")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::Linq2SqlGeography.Properties.Settings.Default.SqlSpatialTestConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CELLTRACING> CELLTRACING
		{
			get
			{
				return this.GetTable<CELLTRACING>();
			}
		}
		
		public System.Data.Linq.Table<SITE> SITE
		{
			get
			{
				return this.GetTable<SITE>();
			}
		}
		
		public System.Data.Linq.Table<EventLocating> EventLocating
		{
			get
			{
				return this.GetTable<EventLocating>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CELLTRACING")]
	public partial class CELLTRACING
	{
		
		private string _SiteName;
		
		private string _MI_STYLE;
		
		private int _MI_PRINX;
		
		private Microsoft.SqlServer.Types.SqlGeometry _SP_GEOMETRY;
		
		public CELLTRACING()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="VarChar(30)")]
		public string cell
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_STYLE", DbType="VarChar(254)")]
		public string MI_STYLE
		{
			get
			{
				return this._MI_STYLE;
			}
			set
			{
				if ((this._MI_STYLE != value))
				{
					this._MI_STYLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_PRINX", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MI_PRINX
		{
			get
			{
				return this._MI_PRINX;
			}
			set
			{
				if ((this._MI_PRINX != value))
				{
					this._MI_PRINX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_GEOMETRY", UpdateCheck=UpdateCheck.Never)]
		public Microsoft.SqlServer.Types.SqlGeometry SP_GEOMETRY
		{
			get
			{
				return this._SP_GEOMETRY;
			}
			set
			{
				if ((this._SP_GEOMETRY != value))
				{
					this._SP_GEOMETRY = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SITE")]
	public partial class SITE
	{
		
		private string _msc;
		
		private string _bsc;
		
		private string _cell;
		
		private string _cell_name;
		
		private System.Nullable<decimal> _longitude;
		
		private System.Nullable<decimal> _latitude;
		
		private int _band;
		
		private System.Nullable<decimal> _arfcn;
		
		private string _height;
		
		private System.Nullable<decimal> _dir;
		
		private System.Nullable<decimal> _tilt;
		
		private System.Nullable<int> _ant_bw;
		
		private System.Nullable<int> _power;
		
		private string _ant_gain;
		
		private string _ant_type;
		
		private System.Nullable<int> _ant_size;
		
		public SITE()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_msc", DbType="NVarChar(30)")]
		public string msc
		{
			get
			{
				return this._msc;
			}
			set
			{
				if ((this._msc != value))
				{
					this._msc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bsc", DbType="NVarChar(30)")]
		public string bsc
		{
			get
			{
				return this._bsc;
			}
			set
			{
				if ((this._bsc != value))
				{
					this._bsc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cell", DbType="NVarChar(30)")]
		public string cell
		{
			get
			{
				return this._cell;
			}
			set
			{
				if ((this._cell != value))
				{
					this._cell = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cell_name", DbType="VarChar(21)")]
		public string cell_name
		{
			get
			{
				return this._cell_name;
			}
			set
			{
				if ((this._cell_name != value))
				{
					this._cell_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_longitude", DbType="Decimal(11,6)")]
		public System.Nullable<decimal> longitude
		{
			get
			{
				return this._longitude;
			}
			set
			{
				if ((this._longitude != value))
				{
					this._longitude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_latitude", DbType="Decimal(11,6)")]
		public System.Nullable<decimal> latitude
		{
			get
			{
				return this._latitude;
			}
			set
			{
				if ((this._latitude != value))
				{
					this._latitude = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_band", DbType="Int NOT NULL")]
		public int band
		{
			get
			{
				return this._band;
			}
			set
			{
				if ((this._band != value))
				{
					this._band = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_arfcn", DbType="Decimal(3,0)")]
		public System.Nullable<decimal> arfcn
		{
			get
			{
				return this._arfcn;
			}
			set
			{
				if ((this._arfcn != value))
				{
					this._arfcn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_height", DbType="VarChar(3)")]
		public string height
		{
			get
			{
				return this._height;
			}
			set
			{
				if ((this._height != value))
				{
					this._height = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dir", DbType="Decimal(3,0)")]
		public System.Nullable<decimal> dir
		{
			get
			{
				return this._dir;
			}
			set
			{
				if ((this._dir != value))
				{
					this._dir = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tilt", DbType="Decimal(3,0)")]
		public System.Nullable<decimal> tilt
		{
			get
			{
				return this._tilt;
			}
			set
			{
				if ((this._tilt != value))
				{
					this._tilt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ant_bw", DbType="Int")]
		public System.Nullable<int> ant_bw
		{
			get
			{
				return this._ant_bw;
			}
			set
			{
				if ((this._ant_bw != value))
				{
					this._ant_bw = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_power", DbType="Int")]
		public System.Nullable<int> power
		{
			get
			{
				return this._power;
			}
			set
			{
				if ((this._power != value))
				{
					this._power = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ant_gain", DbType="VarChar(3)")]
		public string ant_gain
		{
			get
			{
				return this._ant_gain;
			}
			set
			{
				if ((this._ant_gain != value))
				{
					this._ant_gain = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ant_type", DbType="VarChar(15)")]
		public string ant_type
		{
			get
			{
				return this._ant_type;
			}
			set
			{
				if ((this._ant_type != value))
				{
					this._ant_type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ant_size", DbType="Int")]
		public System.Nullable<int> ant_size
		{
			get
			{
				return this._ant_size;
			}
			set
			{
				if ((this._ant_size != value))
				{
					this._ant_size = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EventLocating")]
	public partial class EventLocating
	{
		
		private string _SiteName;
		
		private string _MI_STYLE;
		
		private int _MI_PRINX;
		
		private Microsoft.SqlServer.Types.SqlGeometry _SP_GEOMETRY;
		
		public EventLocating()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteName", DbType="VarChar(30)")]
		public string events
		{
			get
			{
				return this._SiteName;
			}
			set
			{
				if ((this._SiteName != value))
				{
					this._SiteName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_STYLE", DbType="VarChar(254)")]
		public string MI_STYLE
		{
			get
			{
				return this._MI_STYLE;
			}
			set
			{
				if ((this._MI_STYLE != value))
				{
					this._MI_STYLE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MI_PRINX", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int MI_PRINX
		{
			get
			{
				return this._MI_PRINX;
			}
			set
			{
				if ((this._MI_PRINX != value))
				{
					this._MI_PRINX = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SP_GEOMETRY", UpdateCheck=UpdateCheck.Never)]
		public Microsoft.SqlServer.Types.SqlGeometry SP_GEOMETRY
		{
			get
			{
				return this._SP_GEOMETRY;
			}
			set
			{
				if ((this._SP_GEOMETRY != value))
				{
					this._SP_GEOMETRY = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
