using System;

namespace Problem_11
{

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface
    | AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)]

    [VersionAttribute(1, 11)]
    /// <summary>
    /// Represents a version attribute for custom attributes.
    /// </summary>
    public class VersionAttribute : System.Attribute
    {
        // fields
        /// <summary>
        /// Holds the minor version attribute value.
        /// </summary>
        private int minor;

        /// <summary>
        /// Holds the major version attribute value.
        /// </summary>
        private int major;

        // properties       
        /// <summary>
        /// Represents the major version attribute value.
        /// </summary>
        public int Major
        {
            get { return this.major; }
            private set { this.major = value; }
        }

        /// <summary>
        /// Represents the minor version attribute value.
        /// </summary>
        public int Minor
        {
            get { return this.minor; }
            private set { this.minor = value; }
        }

        // constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionAttribute"/> class.
        /// </summary>
        /// <param name="major">Major version attribute parameter value.</param>
        /// <param name="minor">Minor version attribute parameter value.</param>
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
