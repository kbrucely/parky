﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static parkyapi.Models.Trail;

namespace parkyapi.Models.Dtos
{
    public class TrailUpdateDto
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Distance { get; set; }

        public DifficultyType Difficulty { get; set; }

        [Required]
        public int NationalParkId { get; set; }

    }
}
