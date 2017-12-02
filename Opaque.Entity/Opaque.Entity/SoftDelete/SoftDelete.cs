using Opaque.Entity.Base;

namespace Opaque.Entity.SoftDelete
{
    public class SoftDelete<T>: Base<T>, ISoftDelete
    {
        public virtual bool IsDeleted { get; set; }
    }
}
