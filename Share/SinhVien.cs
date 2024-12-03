using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share
{
	public class SinhVien
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Tên không được để trống")]
		[NoWhiteSpace(ErrorMessage = "Tên không được chứa khoảng trắng")]
		public string Name { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "Tuổi phải lớn hơn 0")]
		public int Age { get; set; }
	}
	public class NoWhiteSpaceAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value is string str && str.Contains(" "))
			{
				return new ValidationResult(ErrorMessage);
			}
			return ValidationResult.Success;
		}
	}
}
