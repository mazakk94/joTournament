using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCprojekt.Models
{
    public class TournamentDbContext : DbContext
    {
        public TournamentDbContext() : base("DefaultConnection") { }
        //Int16 Id { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }



    }
}