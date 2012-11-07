using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoliticImpact.Models
{
    public class CaseItem
    {
        /*
            * Variables from "Dropbox/Arkitektur/tables.doc"
            * */
        [Required]
        public int ID { get; set; }

        [Required]
        public long Owner { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Title { get; set; }

        [Required]
        [StringLength(10000, ErrorMessage = "You must have a description.", MinimumLength = 1)]
        public string Text { get; set; }

        [Required]
        public bool Published { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Deadline { get; set; }

        [DataType(DataType.DateTime) ]
        public DateTime LastEdited { get; set; }

        public int imageId { get; set; }

        public byte[] imageBytes { get; set; }

        public string imageName { get; set; }
    }
    
}