namespace dotapi.Repositories
{
	interface IRepo<IRow>
	{
		IRow Get(string Id);
	}
	
	public class RepoBase<T> : IRepo<T>
	{
		public RepoBase()
		{
			
		}
		
		public T Get(string Id)
		{
			return default(T);
		}
	}
}