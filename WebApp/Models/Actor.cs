﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string PfpUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}