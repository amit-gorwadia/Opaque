namespace Opaque.Entity.Base
{
    public abstract class Base<T> : Empty, IBase<T>
    {
        public virtual T Id { get; set; }
    }
}
