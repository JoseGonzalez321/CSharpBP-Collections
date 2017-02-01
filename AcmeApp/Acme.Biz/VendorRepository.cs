using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();
                vendors.Add(new Vendor { VendorId = 1, CompanyName = "ABC"});
                vendors.Add(new Vendor { VendorId = 2, CompanyName = "XYZ"});
            }

            foreach (var vendor in vendors)
                Console.WriteLine(vendor);

            return vendors;
        }

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        //Generic Constraint Syntax to only primitive values (e.g. int, bool)
        public T RetrieveValue<T>(string sql, T defaultValue) where T : struct
        {
            T value = defaultValue;

            return value;
        }

        //Limit of generic contraints
        //Need to overload method to take only strings.
        // Cannot used where T : class because we want to restrict ref types
        // but still enable primitives (as method above) and strings.
        public string RetrieveValue(string sql, string defaultValue)
        {
            string value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
