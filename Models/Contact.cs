using System.ComponentModel.DataAnnotations;

namespace WebApIContacts.Models
{
	public class Contact
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public EmailAddressAttribute email { get; set; }
		[Required]
		public byte[] Picture { get; set; }
    }
}
