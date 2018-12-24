namespace CoreApp.Models.Repositories
{
	public class FileDto : IRow
	{
		public string Id { get; set; }
		public int Length { get; set; }
		public string Filename { get; set; }
	}
}