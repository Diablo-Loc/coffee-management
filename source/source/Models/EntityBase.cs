using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.Models
{
    public abstract class EntityBase
    {
        private int _id;
        private DateTime _created;
        private DateTime _updated;
        public int Id { get { return this._id; } set { this._id = value; } }
        public DateTime CreatedAt { get { return this._created; } set { this._created = value; } }
        public DateTime UpdatedAt { get { return this._updated; } set { this._updated = value; } }

        protected EntityBase()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        protected EntityBase(int id)
        {
            Id = id;
            CreatedAt = DateTime.Now;
            UpdatedAt = CreatedAt;
        }
        ~EntityBase() { }
        public void Touch()
        {
            UpdatedAt = DateTime.Now;
        }
    }
}
