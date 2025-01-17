﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnline.Data.EF
{
  public  class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }

        public Transaction Status { get; set; }
        public string Provider { get; set; }

    }
}
