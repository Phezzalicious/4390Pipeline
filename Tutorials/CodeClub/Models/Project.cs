using System;
using System.ComponentModel.DataAnnotations;

namespace CodeClub.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{get; set;}
        public DateTime DueDate { get; set; }
        public int Customer{get; set;}
        
     
    }
   
}