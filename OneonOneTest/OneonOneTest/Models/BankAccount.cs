using System.ComponentModel;

namespace OneonOneTest.Models
{
    public class BankAccount
    {
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public int NumberofTransactions { get; set; }
        public int Id { get; set; }

        // Foreign key to AccountHolder
        public int AccountHolderId { get; set; }
        public AccountHolder? AccountHolder { get; set; }
    }
}
