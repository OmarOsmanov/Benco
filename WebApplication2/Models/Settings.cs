using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WorkTime { get; set; }
        public string Info { get; set; }
    }
}
