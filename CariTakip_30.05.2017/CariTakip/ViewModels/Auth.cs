using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CariTakip.ViewModels
{
    public class AuthLogin
    {
        [Required][MaxLength(50)]
        public string Adi { get; set; }
        [Required][DataType(DataType.Password)][MaxLength(12)]
        public string Sifre { get; set; }
    }
}