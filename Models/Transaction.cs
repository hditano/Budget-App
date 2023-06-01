namespace Budget.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
