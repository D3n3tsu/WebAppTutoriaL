using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace WebAppTutoriaL.Models
{
    public class WebAppUser : IdentityUser
    {
        public DateTime FirstTripPlan { get; set; }
    }
}