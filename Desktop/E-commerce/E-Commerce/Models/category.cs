using System;
using System.ComponentModel.DataAnnotations;
namespace E_Commerce.Models
{
	public class EmptyClass
	{
        [Key]
		public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}

