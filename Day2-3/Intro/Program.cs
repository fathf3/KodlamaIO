using Intro.Business.Concretes;
using Intro.DataAccess.Concretes.InMemory;


CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());

foreach (var course in courseManager.GetAll())
	Console.WriteLine(course.CourseName);

Console.WriteLine("*************");

foreach (var instructor in instructorManager.GetAll())
	Console.WriteLine(instructor.InstructorFirstName + " " + instructor.InstructorLastName);