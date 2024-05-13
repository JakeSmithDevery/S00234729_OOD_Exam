using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S00234729_OOD_Exam
{
    //creating class for 1(f)
    public class RestarauntData : DbContext
    {
        //make dbsets for both classes
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public RestarauntData(string fullName) : base(fullName)
        {

        }
    }
}
