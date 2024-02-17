using Intro.Entities.Concretes;

namespace Intro.Business.Abstracts
{
	public interface IInstructorService
	{
		List<Instructor> GetAll();
		void Add(Instructor instructor);
		void Update(Instructor instructor);
		void Delete(Instructor instructor);

	}
}
