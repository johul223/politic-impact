using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/*
 * Created by: Johannes Dahlgren
 * Created at: 6/11 2012
 */
//testar att lägga till en rad
namespace PoliticImpact1.Models
{
    public class CaseModel
    {
        /*
         * Variables from "Dropbox/Arkitektur/tables.doc"
         * */
        [Required]
        public int ID { get; set; }

        [Required]
        public long Owner { get; set; }

        [Required]
        [StringLength(100, ErrorMessage="{0} must be at least {2} characters long.", MinimumLength=5)]
        public string Title { get; set; }

        [Required]
        [StringLength(10000,ErrorMessage="You must have a description.", MinimumLength=1)]
        public string Text { get; set; }

        [Required]
        public bool Published { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime LastEdited { get; set; }

        public int imageId { get; set; }

        public byte[] imageBytes { get; set; }

        public string photoName { get; set; }
    }

}