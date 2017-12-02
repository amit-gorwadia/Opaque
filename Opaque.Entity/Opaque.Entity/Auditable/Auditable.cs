using Opaque.Entity.Base;
using System;

namespace Opaque.Entity.Auditable
{
    public class Auditable<T>: Base<T>, IAuditable
    {
        public virtual DateTime CreatedOn { get; set; }

        public virtual string CreatedBy { get; set; }

        public virtual DateTime? ModifiedOn { get; set; }

        public virtual string ModifiedBy { get; set; }
    }
}
