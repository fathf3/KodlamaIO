using Intro.Business.Abstracts;
using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;

namespace Intro.Business.Concretes
{
	public class InstructorManager : IInstructorService
	{
		private readonly IInstructorDal _instructorDal;

		public InstructorManager(IInstructorDal instructorDal)
		{
			_instructorDal = instructorDal;
		}

		public void Add(Instructor instructor)
		{
			_instructorDal.Add(instructor);
			
		}

		public void Delete(Instructor instructor)
		{
			_instructorDal.Delete(instructor);
		}

		public void DeleteById(int id)
		{
			_instructorDal.DeleteById(id);
		}

		public List<Instructor> GetAll()
		{
			//Console.WriteLine(">>> Eğitmenler listeleniyor...\n");
			return _instructorDal.GetAll();
		}

		public void Update(Instructor instructor)
		{
			_instructorDal.Update(instructor);
		}
	}
}
