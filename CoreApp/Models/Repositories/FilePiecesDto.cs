namespace dotapi.Models.Repositories
{
	public class FilePiecesDto: IRow
	{
		public string Id { get; set; }
		public string FilePieceId { get; set; }
		public string FileId { get; set; }
		public int PieceNumber { get; set;}
	}
}