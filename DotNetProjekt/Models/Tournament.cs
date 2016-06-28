using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCprojekt.Models
{
    public class Tournament
    {
        public Int16 Id { get; set; }
        public String name { get; set; }
        public String location { get; set; }
        public String discipline { get; set; }
        public String organisator { get; set; }
        //mapka
        public int requestLimit { get; set; }
        public TimeSpan deadline { get; set; }
        //logo
        public int playersCount { get; set; }


    }



}