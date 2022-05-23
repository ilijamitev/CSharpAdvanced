
namespace MakingAttributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    [ClassDescription("This is the attribute that describes class description")]
    internal class ClassDescriptionAttribute : Attribute
    {
        public string Description { get; init; }
        public ClassDescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}