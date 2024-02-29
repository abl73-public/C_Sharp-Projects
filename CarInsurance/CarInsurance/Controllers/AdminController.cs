using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.ToList();
                var quotes = new List<Admin>();
                foreach (var insuree in insurees)
                {
                    var quote = new Admin();
                    quote.FirstName = insuree.FirstName;
                    quote.LastName = insuree.LastName;
                    quote.EmailAddress = insuree.EmailAddress;
                    quote.BaseQuote = 50m;
                    int dateCompare = DateTime.Now.Subtract(insuree.DateOfBirth).Days;
                    // days 365*26
                    if (dateCompare >= 9490)
                    {
                        quote.OverTwentySix = 25m;
                    }
                    else
                    {
                        quote.OverTwentySix = 0m;
                    }
                    // days 365*18+364
                    if (dateCompare <= 6934)
                    {
                        quote.MinusEighteen = 100m;
                    }
                    else
                    {
                        quote.MinusEighteen = 0m;
                    }

                    if (dateCompare > 6934 && dateCompare < 9490)
                    {
                        quote.BetwNineteenAndTwentySix = 50m;
                    }
                    else
                    {
                        quote.BetwNineteenAndTwentySix = 0m;
                    }

                    if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                    {
                        quote.CarYearBeforeOver = 25m;
                    }
                    else
                    {
                        quote.CarYearBeforeOver = 0m;
                    }

                    if (insuree.CarMake == "Porche" || insuree.CarMake == "porche")
                    {
                        quote.CarMakePorche = 25m;
                        if (insuree.CarModel == "911 Carrera" || insuree.CarModel == "911 carrera")
                        {
                            quote.CarModelCarrera = 25m;
                        }
                        else
                        {
                            quote.CarModelCarrera = 0m;
                        }
                    }
                    else
                    {
                        quote.CarMakePorche = 0m;
                    }

                    if (insuree.SpeedingTickets > 0)
                    {
                        quote.SpeedingTicketsQuantityYes = insuree.SpeedingTickets;
                        quote.SpeedingTicketsQuantity = (insuree.SpeedingTickets * 10.0m);
                    }
                    else
                    {
                        quote.SpeedingTicketsQuantityYes = 0;
                        quote.SpeedingTicketsQuantity = 0m;
                    }

                    if (insuree.DUI)
                    {
                        quote.DUIYes = (insuree.Quote * 25 / 100);
                    }
                    else
                    {
                        quote.DUIYes = 0;
                    }

                    if (insuree.CoverageType)
                    {
                        quote.CoverageTypeYes = (insuree.Quote * 50 / 100);
                    }
                    else
                    {
                        quote.CoverageTypeYes = 0;
                    }

                    quote.TotalQuote = insuree.Quote;

                    quotes.Add(quote);
                }

                return View(quotes);
            }
        }
    }
}