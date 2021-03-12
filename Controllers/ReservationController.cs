using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationMng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationMng.Controllers
{
    public class ReservationController : Controller
    {
        private readonly UserDbContext _usr;

        public ReservationController(UserDbContext usr)
        {
            _usr = usr;
        }
        public IActionResult Index()
        {
            //var list = _usr.Reservations
            //    .Join(_usr.Students,
            //    r => r.Students.Id,
            //    s => s.Id,
            //    (r, s) => new
            //    {
            //        cause = r.Cause,
            //        date = r.Date,
            //        status = r.Status,
            //        id = s.Id,
            //       userName = s.UserName,
            //       ResCount = s.resCount,
            //       Classe = s.Class,


            //    })
            //    .Join(_usr.TypeReservations,
            //    r => r.TypeReservation.id,
            //    tr => tr.id,
            //    (r, tr) => new
            //    {
            //        tr.name,
            //        tr.id,
            //        tr.accessNumber,
            //    }).ToList();

            //var list = _usr.Set<Reservation>().FromSqlRaw("CALL FilterByUser()").ToList<Reservation>();

            //var list = (from r in _usr.Reservations
            //            join s in _usr.Students
            //            on r.Students.Id equals s.Id
            //            join tr in _usr.TypeReservations
            //            on r.TypeReservation.id equals tr.id
            //            select new
            //            {
            //                r.Status,
            //                r.TypeReservation.name,
            //                r.Date,
            //                r.Cause,
            //                s.UserName,
            //                s.Class,
            //            }).AsEnumerable();

            var list = _usr.Reservations.Include(s => s.Student);

            //var list = (from s in _usr.Students
            //            from r in _usr.Reservations
            //            where s.Id == r.Students.Id
            //            select new
            //            {
            //                r.Status,

            //                r.Date,
            //                r.Cause,
            //                s.UserName,
            //                s.Class,
            //            }).ToList();
            //var list2 = (from rt in _usr.TypeReservations
            //             from r in _usr.Reservations
            //             where rt.id == r.id
            //             select new
            //             {
            //                 rt.name,
            //                 rt.accessNumber,

            //             }).ToList();
            //var res = list2.Union(list).ToList();
            ViewBag.list = list;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
