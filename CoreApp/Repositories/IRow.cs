using System.ComponentModel.DataAnnotations;

namespace CoreApp.Models.Repositories
{
	public interface IRow
	{
		[Key]
		string Id { get; set; }
	}
}