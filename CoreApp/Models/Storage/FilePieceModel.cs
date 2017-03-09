namespace dotapi.Models.Storage
{
	public class FilePieceModel
	{
		public string Id { get; set; }
		public int Length { get; set; }
		public string Hash { get; set; }
		public byte[] Bytes {get;set;}
	}
}