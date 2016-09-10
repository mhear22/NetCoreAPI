namespace dotapi.Repositories.Attributes
{
	public class ColumnAttribute : System.Attribute
	{
		public string ColumnName;
		public bool isPrimaryKey;
		
		public ColumnAttribute (string name, bool PrimaryKey = false)
		{
			isPrimaryKey = PrimaryKey;
			ColumnName = name;
		}
	}
}