using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    class EnumExample
    {
        public void EnumExample()
        {
            var user = new User();
            if (user.Status == RegistrationStatus.Active && user.Type == UserType.Admin)
            {
                Console.WriteLine("User Login Successfull.");
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public RegistrationStatus Status { get; set; }
        public UserType Type { get; set; }

    }

    public enum RegistrationStatus
    {
        Active,
        InActive,
        Blocked
    }

    public enum UserType
    {
        Admin,
        Support,
        Member,
        SuperAdmin
    }
}
