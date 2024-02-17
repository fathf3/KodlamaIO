using Intro.Entities.Abstracts;

namespace Intro.Entities.Concretes
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		public string CategoryName { get; set; }
	}
}
