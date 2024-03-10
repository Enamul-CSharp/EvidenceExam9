using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvidenceExam9.Models
{
	public class UserInfo
	{
		//[Key]
		//public Guid UserId { get; set; } = Guid.NewGuid();
		[Key]
		[Required]
		[StringLength(50, MinimumLength = 4)]
		public string UserName { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 6)]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		//[EnumDataType(typeof(UserRole))]
		public string Role { get; set; }

	}

	//public enum UserRole
	//{
	//    Admin, User, Student, Teacher
      // }


}
