using System;

namespace dotapi.Models.Repositories
{
	public class FilePieceDto : IRow
	{
		public string Id { get;set; }
		public int Length {get;set;}
	}
}