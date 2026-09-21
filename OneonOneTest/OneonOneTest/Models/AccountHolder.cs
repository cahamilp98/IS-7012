using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OneonOneTest.Models
{
    public class AccountHolder
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]  
        public string LastName { get; set; }
        [DisplayName("Full Name")]
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
        [DisplayName("Account Holder ID")]
        public int Id { get; set; }
    }
}
