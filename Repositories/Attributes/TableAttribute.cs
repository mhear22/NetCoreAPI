namespace dotapi.Repositories.Attributes
{
	public class TableAttribute : System.Attribute
	{
		public string TableName;
		
		public TableAttribute (string name)
		{
			TableName = name;
		}
	}
}