﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Display(Name = "Ad"), Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(100)]
        [Display(Name = "Soyad"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email { get; set; }
        public string? Telefon { get; set; }
        [StringLength(100)]
        public string? KullaniciAdi { get; set; }
        [Display(Name ="Şifre"), Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }
        [Display(Name ="Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
        public Guid? UserGuid { get; set; } = Guid.NewGuid();

    }
}
