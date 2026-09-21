using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OneonOneTest.Models
{
    public class AccountHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                // CONCAT FIRST & LAST NAME
                return $"{FirstName} {LastName}";
            }
        }
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
