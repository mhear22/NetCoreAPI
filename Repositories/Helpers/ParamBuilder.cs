using System.Data;
using System.Data.SqlClient;

namespace dotapi.Repositories.Helpers
{
	public class ParamBuilder
	{
		private SqlParameter param = new SqlParameter();
		
		public ParamBuilder(string Name, string Value)
		{
			param.ParameterName = Name;
			param.SqlDbType = SqlDbType.Text;
			param.Value = Value;
		}
		
		public SqlParameter GetParam()
		{
			return param;
		}
	}
	
	public class PB : ParamBuilder 
	{
		public PB(string Name, string Value): base(Name, Value) { }
	}
}