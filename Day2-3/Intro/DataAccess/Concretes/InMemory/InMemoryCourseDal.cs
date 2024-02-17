using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;

namespace Intro.DataAccess.Concretes.InMemory
{
	public class InMemoryCourseDal : ICourseDal
	{
		List<Course> _courses;
		public InMemoryCourseDal()
		{
			_courses = new List<Course>
			{
				new Course {Id=1, InstructorId=1, CourseName="C# + Angular", Description="Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)"},
				new Course {Id=2, InstructorId=1, CourseName="Java + React", Description="Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)"},
				new Course {Id=3, InstructorId=1, CourseName=".Net Geliştirme", Description="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)"},
				new Course {Id=4, InstructorId=1, CourseName="Python", Description="Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)"}
			};
		}
		public void Add(Course course)
		{
			_courses.Add(course);
		}

		public void Delete(Course course)
		{
			_courses.Remove(course);
		}

		public void DeleteById(int id)
		{
			_courses.Remove(_courses.SingleOrDefault(c => c.Id == id));
		}

		public List<Course> GetAll()
		{
			return _courses.ToList();
		}

		public void Update(Course course)
		{
			Course updateCourse = _courses.SingleOrDefault(c => c.Id == course.Id);
			updateCourse.Id = course.Id;
			updateCourse.InstructorId = course.InstructorId;
			updateCourse.CourseName = course.CourseName;
			updateCourse.Description = course.Description;
		}
	}
}
