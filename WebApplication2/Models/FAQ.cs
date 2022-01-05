using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public string Quettion { get; set; }
        public string QuettionsContext { get; set; }
    }
}
