using System;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class FinanceBL
    {
        FinanceDL financeDL = new FinanceDL();
        public bool RecordTransaction(FinanceTransaction txn)
        {
            if (txn.Amount <= 0)
                throw new Exception("Transaction amount must be greater than zero.");
            return financeDL.InsertTransaction(txn);
        }
    }
}
