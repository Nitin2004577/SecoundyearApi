using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secoundyear.Properties.Models
{
    public class SingUp
    {
        [Key]
        public int id {get;set;}

        public string userName {get; set;} = string.Empty;

        public string email {get; set;} = string.Empty;

        public string password {get; set;} = string.Empty;

        public string comformPassword {get; set;} = string.Empty;       


    }
}