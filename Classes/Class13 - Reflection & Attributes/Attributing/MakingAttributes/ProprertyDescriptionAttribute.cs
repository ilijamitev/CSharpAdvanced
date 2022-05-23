
namespace MakingAttributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    internal class ProprertyDescriptionAttribute : ClassDescriptionAttribute
    {
        public ProprertyDescriptionAttribute(string description) : base(description) { }
    }

}