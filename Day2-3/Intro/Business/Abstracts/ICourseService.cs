using Intro.Entities.Concretes;

namespace Intro.Business.Abstracts
{
	public interface ICourseService
	{
		List<Course> GetAll();
		void Add(Course course);
		void Update(Course course);
		void Delete(Course course);
		void DeleteById(int id);
	}
}
