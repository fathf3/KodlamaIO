using Intro.Entities.Concretes;

namespace Intro.DataAccess.Abstracts
{
	public interface IInstructorDal
	{
		List<Instructor> GetAll();
		void Add(Instructor instructor);
		void Delete(Instructor instructor);
		void DeleteById(int id);
		void Update(Instructor instructor);

	}
}
