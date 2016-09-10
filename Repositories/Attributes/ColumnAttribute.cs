namespace dotapi.Repositories.Attributes
{
	public class ColumnAttribute : System.Attribute
	{
		public string ColumnName;
		
		public ColumnAttribute (string name)
		{
			ColumnName = name;
		}
	}
}