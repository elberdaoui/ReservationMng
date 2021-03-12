using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationMng.Models
{
    public class Student : IdentityUser  //IdentityUser<string>
    {
        public string Class { get; set; }
        public int resCount { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
