﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public int Age { get; set; }
        public string PfpUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        
        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}