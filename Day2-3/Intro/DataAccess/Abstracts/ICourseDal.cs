using Intro.Entities.Concretes;

namespace Intro.DataAccess.Abstracts
{
	public interface ICourseDal
	{
		List<Course> GetAll();
		void Add(Course course);
		void Update(Course course);
		void Delete(Course course);
		void DeleteById(int id);
	}
}
