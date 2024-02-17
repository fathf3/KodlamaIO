using Intro.Business.Abstracts;
using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;

namespace Intro.Business.Concretes
{
	public class CourseManager : ICourseService
	{
		private readonly ICourseDal _courseDal;

		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

		public void Add(Course course)
		{
			_courseDal.Add(course);
		}

		public void Delete(Course course)
		{
			_courseDal.Delete(course);
		}

		public void DeleteById(int id)
		{
			_courseDal.DeleteById(id);
		}

		public List<Course> GetAll()
		{
			return _courseDal.GetAll().ToList();
		}

		public void Update(Course course)
		{
			_courseDal.Update(course);
		}
	}
}
