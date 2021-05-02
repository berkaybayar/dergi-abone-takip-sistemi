﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DergiAboneProje.Models
{
    public class Uyeler 
    {
        [Key]
        public int UyeID { get; set; }

        [Required(ErrorMessage = "Üye adı boş bırakılamaz")]
        [Display(Name = "Üye Adı Soyadı")]
        [RegularExpression(@"^[A-z^şŞıİçÇöÖüÜĞğ ]+$", ErrorMessage = "Üye adı sadece harf içerebilir.")]
        [MaxLength(50,ErrorMessage = "Üye adı soyadı en fazla 50 haneli olabilir")]       
        public string UyeAD { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Geçersiz email adresi girdiniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tel no boş bırakılamaz.")]
        [Display(Name = "Tel No")]
        public long TelNo { get; set; }

        [Required(ErrorMessage = "Doğum Tarihi boş bırakılamaz.")]
        [Display(Name ="Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime Tarih { get; set; }
       
    }
}
