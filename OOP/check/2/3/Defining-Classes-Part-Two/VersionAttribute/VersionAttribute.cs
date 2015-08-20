namespace MyAttributes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string vers)
        {
            this.Version = vers;
        }
        public string Version { get; set; }
    }
}
