using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCprojekt.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String location { get; set; }
        public String discipline { get; set; }
        public String organisator { get; set; }
        [DataType(DataType.Date)]
        public DateTime time { get; set; }
        [DataType(DataType.Date)]
        public DateTime deadline { get; set; }
        public int requestLimit { get; set; }
        public int playersCount { get; set; }
        public List<String> players { get; set; }


    }



}