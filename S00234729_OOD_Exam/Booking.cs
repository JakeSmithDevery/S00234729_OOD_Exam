using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S00234729_OOD_Exam
{
    //Class for Q1(c)
    public class Booking
    {
        //vars for Q1(c)
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfParticipants { get; set; }

        //part of one to many (to one)
        public virtual Customer Customer { get; set; }
    }
}
