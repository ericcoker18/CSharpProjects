using System;
using System.Collections.Generic;
using System.Text;

namespace PoCos
{
    class DriverLicense
    {
        String FirstName { get; set; }
        String LastName { get; set; }
        String Gender { get; set; }
        int LicenseNum { get; set; }

        public DriverLicense(string firstname, string lastname, string gender, int licensenum)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            LicenseNum = licensenum;

             string GetFullName()
            {
                return FirstName + LastName;

            }

        }
    }
}
