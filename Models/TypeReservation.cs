using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationMng.Models
{
    public class TypeReservation
    {
        public int id { get; set; }
        public string name { get; set; }
        public int accessNumber { get; set; }
        public virtual Reservation Reservation { get; set; }


    }
}
