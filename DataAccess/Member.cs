using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Member
    {
        public int Id { get;  set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string LastName { get; set; }
        public string  MotherName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string SchoolName { get; set; }
        public string Description { get; set; }
    }
}
