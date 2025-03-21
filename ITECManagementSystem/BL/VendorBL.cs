using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class VendorBL
    {
        VendorDL vendorDL = new VendorDL();
        public List<Vendor> GetVendors()
        {
            return vendorDL.GetVendors();
        }
        public bool AddVendor(Vendor vendor)
        {
            if (vendor == null)
                throw new Exception("Vendor cannot be null.");
            if (string.IsNullOrWhiteSpace(vendor.VendorName))
                throw new Exception("Vendor name is required.");
            if (string.IsNullOrWhiteSpace(vendor.ServiceType))
                throw new Exception("Service type is required.");
            if(vendorDL.InsertVendor(vendor))
            {
                return true;
            }
            return false;
        }
        public bool UpdateVendor(Vendor vendor)
        {
            if (vendor == null || vendor.VendorId <= 0)
                throw new Exception("Invalid vendor selection.");
            if (vendorDL.UpdateVendor(vendor))
            {
                return true;
            }
            return false;
        }
        public bool DeleteVendor(int vendorId)
        {
            if (vendorId <= 0)
                throw new Exception("Invalid vendor selection.");
            if (vendorDL.DeleteVendor(vendorId))
            {
                return true;
            }
            return false ;
        }
    }
}
