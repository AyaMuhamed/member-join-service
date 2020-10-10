
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace MemberServices.Models
{
    [SwaggerSchema(Description= "Defines member profile")]
    public class Member
    {
        [SwaggerSchema(Description="Member's unique identifier")]
        [Required]
        public int id { get; set; }
        
        [SwaggerSchema(Description="Member's first name")]
        [StringLength(150)]
        [Required]
        public string firstName { get; set; }  
         
        [SwaggerSchema(Description="Member's last name")]
        public string lastName { get; set; } 

        [SwaggerSchema(Description="Member's age")]
        public int age { get; set; } 
        
    }
}