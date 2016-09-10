using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using dotapi.Repositories.Attributes;

namespace dotapi.Repositories
{
	interface IRepo<IRow>
	{
		IRow Get(string Id);
	}
	
	public class RepoBase<T> : IRepo<T>
	{
		private static SqlConnection Conn = null;
		
		private string TableName = "";
		private List<string> ColumnNames = new List<string>(); 
		
		public RepoBase()
		{
			InitDb(new ConnectionBuilder()
					.User("root")
					.Password("password")
					.ToString());
			ExtractModel();
		}
		
		public RepoBase(ConnectionBuilder connection)
		{
			InitDb(connection.ToString());
			ExtractModel();
		}
		
		private void InitDb(string ConnectionString)
		{
			if(Conn == null)
			{
				Conn = new SqlConnection(ConnectionString);
			}
		}
		
		private void ExtractModel()
		{
			var type = typeof(T);
			var info = type.GetTypeInfo();
			var fields = info.GetFields();
			var props = info.GetProperties();
			foreach(var field in fields)
			{
				ReadAttributes(field.GetCustomAttributes());
			}
			
			foreach(var prop in props)
			{
				ReadAttributes(prop.GetCustomAttributes());
			}
		}
		
		private void ReadAttributes(IEnumerable<Attribute> attributes)
		{
			foreach(var attribute in attributes)
			{
				if(attribute is TableAttribute)
				{
					if(!string.IsNullOrWhiteSpace(TableName))
						throw new Exception("Two Table attributes in DTO");
					var x = (TableAttribute)attribute;
					TableName = x.TableName;
				}
				else if(attribute is ColumnAttribute)
				{
					ColumnNames.Add(((ColumnAttribute)attribute).ColumnName);
				}
			}
		}
		
		public T Get(string Id)
		{
			return default(T);
		}
	}
}