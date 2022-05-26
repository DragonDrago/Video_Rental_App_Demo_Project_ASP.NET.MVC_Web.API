using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Rental_App_Asp.net.MVC_Web_API.Models;

namespace Video_Rental_App_Asp.net.MVC_Web_API.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}