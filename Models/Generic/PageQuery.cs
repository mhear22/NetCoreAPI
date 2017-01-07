namespace dotapi.Models.Generic
{
	public interface IPageQuery
	{
		int Skip { get; set; }
		int Take { get; set; }
	}
	
	public abstract class PageQuery : IPageQuery
	{
		public int Skip { get;set; }
		public int Take { get;set; }
	} 
}