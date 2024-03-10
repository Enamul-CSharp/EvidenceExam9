using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvidenceExam9.Models
{
	public class Designation
	{

		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		//public virtual List<Employee> Employees { get; set; }





	}
}