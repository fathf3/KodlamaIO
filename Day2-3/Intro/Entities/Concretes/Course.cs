﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities.Concretes
{
	public class Course
	{
		public int Id { get; set; }
		public int InstructorId { get; set; }
		public string CourseName { get; set; }
		public string Description { get; set; }
	}
}
