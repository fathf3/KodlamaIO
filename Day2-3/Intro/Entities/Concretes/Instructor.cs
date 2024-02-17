using Intro.Entities.Abstracts;

namespace Intro.Entities.Concretes
{
	public class Instructor : IEntity
	{
		public int Id { get; set; }
		public string InstructorFirstName { get; set; }
		public string InstructorLastName { get; set; }
		public string InstructorEmail { get; set; }

	}
}
