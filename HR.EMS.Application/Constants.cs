using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Application
{
    public static class Constants
    {
        public const string DataFetched = "Data Fetched Successfully";
        public const string DataInserted = "Data Inserted Successfully";
        public const string DataUpdated = "Data Updated Successfully";
        public const string DataDeleted = "Data Deleted Successfully";

        // Error messages
        public const string InvalidUsernamePassword = "Invalid username or password";
        public const string AuthenticationSuccessful = "Authentication successful";
        public const string ErrorDuringAuthentication = "Authentication failed";
        public const string UsernameEmailTaken = "UserName/Email is already taken";
        public const string RegistrationSuccessful = "Registration Successful";
        public const string ErrorDuringRegistration = "Error during registration";

        // Add more constants as needed
    }




}
