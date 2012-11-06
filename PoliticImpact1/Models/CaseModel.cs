using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/*
 * Created by: Johannes Dahlgren
 * Created at: 6/11 2012
 */

namespace PoliticImpact1.Models
{
    public class CaseModel
    {
        public int ID { get; set; }
        public long Owner { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Published { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastEdited { get; set; }
    }

}