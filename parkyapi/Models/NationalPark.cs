﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace parkyapi.Models
{
    public class NationalPark
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        public DateTime Created { get; set; }
        public DateTime Established { get; set; }
    }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
}