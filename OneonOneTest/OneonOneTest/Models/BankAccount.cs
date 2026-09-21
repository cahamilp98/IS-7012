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
        public int AccountId { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
    }
}
