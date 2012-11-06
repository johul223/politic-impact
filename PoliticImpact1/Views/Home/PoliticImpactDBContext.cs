using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoliticImpact1.Views.Home
{
    public class PoliticImpactDBContext : DbContext
    {
        public DbSet<PoliticImpact1.Models.CaseModel> Cases { get; set; }
    }
}