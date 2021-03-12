using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationMng.Models
{
    public class Reservation
    {
        
        public string id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Cause { get; set; }

        
        public virtual Student Student { get; set; }
        public virtual ICollection<TypeReservation> TypeReservations { get; set; }
    }
}
