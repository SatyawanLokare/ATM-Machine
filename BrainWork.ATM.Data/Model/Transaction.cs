using System;
using System.Collections.Generic;
using System.Text;

namespace BrainWork.ATM.Data
{
    public  class Transaction
    {
        public int Id { get; set; }
        public string TransactionNumber { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public int StatusId { get; set; }
        public int DepositeModeId { get; set; }
        public TransactionType TransactionType { get; set; }
        public Status Status { get; set; }
        public DepositMode DepositMode { get; set; }
    }
}
