using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeExercise.Models
{
    public class LinkedinUser
    {
        [Key]
        public int Id { get; set; }
        public string LinkedinId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Headline { get; set; }
        public string ProfileUrl { get; set; }
        public string PictureUrl     {get;set;}
        public string EmailAddress { get; set; }

    }
}