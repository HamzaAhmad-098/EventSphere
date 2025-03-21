using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class PaymentTrackingBL
    {
        PaymentTrackingDL trackingDL = new PaymentTrackingDL();
        public List<PaymentTracking> GetPayments()
        {
            return trackingDL.GetPayments();
        }
        public void UpdatePaymentStatus(int registrationId, int newStatusId)
        {
            trackingDL.UpdatePaymentStatus(registrationId, newStatusId);
        }
        public List<PaymentTracking> SearchPayments(string searchText)
        {
            return trackingDL.SearchPayments(searchText);
        }
    }
}
