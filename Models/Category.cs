using System.ComponentModel.DataAnnotations;
namespace BulkyWeb.Models
{
	public class Category
	{
		[Key] //[Key] is imported from Data Annotaion, which will help the entity framework know that Id is the primary key
		public int Id { get; set; }
		[Required]
		[MaxLength(30)]
		public string? Name { get; set; }
		[Range(1,100)]
		public int DisplayOrder { get; set; }
	}
}

