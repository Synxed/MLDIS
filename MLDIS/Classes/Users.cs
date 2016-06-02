using System;

namespace MLDIS
{
    static class Users
    {
        public enum Designation
        {
            Administrator,
            Doctor,
            Technician,
            Dispensary,
            Store,
            Patient,
            Invalid
        }

        public enum Module
        {
            UserRegistration,
            Invalid
        }

        public static Designation GetUserDesignation(string userDesignationInString)
        {
            try
            {
                return (Designation) Enum.Parse(typeof (Designation), userDesignationInString);
            }
            catch
            {
                return Designation.Invalid;
            }
            
        }

        public static Module GetModule(string moduleInString)
        {
            switch (moduleInString)
            {
                case "User Registration": return Module.UserRegistration;
                default: return Module.Invalid;
            }
        }
    }
}
