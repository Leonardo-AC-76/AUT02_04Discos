﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AUT02_04Discos.Models
{
    [Table("Customer")]
    [Index("SupportRepId", Name = "IFK_CustomerSupportRepId")]
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(40)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        [StringLength(80)]
        public string Company { get; set; }
        [StringLength(70)]
        [Display(Name = "Dirección")]
        public string Address { get; set; }
        [StringLength(40)]
        [Display(Name = "Ciudad")]
        public string City { get; set; }
        [StringLength(40)]
        public string State { get; set; }
        [StringLength(40)]      
        [Display(Name = "Pais")]
        public string Country { get; set; }
        [StringLength(10)]
        [Display(Name = "Código Postal")]
        public string PostalCode { get; set; }
        [StringLength(24)]
        public string Phone { get; set; }
        [StringLength(24)]
        public string Fax { get; set; }
        [Required]
        [StringLength(60)]
        public string Email { get; set; }
        public int? SupportRepId { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}