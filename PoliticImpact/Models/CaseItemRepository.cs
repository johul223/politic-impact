using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace PoliticImpact.Models
{ 
    public class CaseItemRepository : ICaseItemRepository
    {
        PoliticImpactContext context = new PoliticImpactContext();

        public IQueryable<CaseItem> All
        {
            get { return context.CaseItems; }
        }

        public IQueryable<CaseItem> AllIncluding(params Expression<Func<CaseItem, object>>[] includeProperties)
        {
            IQueryable<CaseItem> query = context.CaseItems;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CaseItem Find(int id)
        {
            return context.CaseItems.Find(id);
        }

        public void InsertOrUpdate(CaseItem caseitem)
        {
            if (caseitem.ID == default(int)) {
                // New entity
                context.CaseItems.Add(caseitem);
            } else {
                // Existing entity
                context.Entry(caseitem).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var caseitem = context.CaseItems.Find(id);
            context.CaseItems.Remove(caseitem);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose() 
        {
            context.Dispose();
        }
    }

    public interface ICaseItemRepository : IDisposable
    {
        IQueryable<CaseItem> All { get; }
        IQueryable<CaseItem> AllIncluding(params Expression<Func<CaseItem, object>>[] includeProperties);
        CaseItem Find(int id);
        void InsertOrUpdate(CaseItem caseitem);
        void Delete(int id);
        void Save();
    }
}