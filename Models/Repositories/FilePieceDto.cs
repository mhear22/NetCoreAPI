using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotapi.Models.Repositories
{
	public class FilePieceDto : IRow
	{
		public string Id { get; set; }
		public int Length { get; set; }
		public string Hash { get; set; }
	}
}