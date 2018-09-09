using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HappyCalendarAPI.DTO
{
    public class AreaDTO
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(255)]
        public string AreaName { get; set; }
    }
}