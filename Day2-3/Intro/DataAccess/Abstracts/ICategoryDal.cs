using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Abstracts
{
	public interface ICategoryDal
	{
		List<Category> GetAll();
		void Add(Category category);
		void Delete(Category category);
		void DeleteById(int id);
		void Update(Category category);
	}
}
