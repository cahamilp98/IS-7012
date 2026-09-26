using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OneonOneTest.Models
{
    public class AccountHolder
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]  
        [Required(ErrorMessage = "Last Name is required")]
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
        [RegularExpression(@"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d{4}$", ErrorMessage = "Date of Birth must be in the format MM/DD/YYYY")]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone number must be in the format (123) 456-7890")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Account Holder ID")]
        public int Id { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
    }
}
