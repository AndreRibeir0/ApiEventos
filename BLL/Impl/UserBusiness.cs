using BLL.Interfaces;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBusiness : IEntityBase<User>
    {

        public void Add(User item)
        {
            using (EventsContext db  = new EventsContext())
            {
                db.Users.Add(item);
                db.SaveChanges();
            }
        }

        public void Delete(User item)
        {
            using (EventsContext db = new EventsContext())
            {
                db.Entry<User>(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(User item)
        {
            using (EventsContext db = new EventsContext())
            {
                db.Entry<User>(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IList<User> GetAll()
        {
            using (EventsContext db = new EventsContext())
            {
                return db.Users.AsNoTracking().ToList();
            }
        }

        public User GetByID(int id)
        {
            using (EventsContext db = new EventsContext())
            {
                return db.Users.Find(id);
            }
        }

    }
}
