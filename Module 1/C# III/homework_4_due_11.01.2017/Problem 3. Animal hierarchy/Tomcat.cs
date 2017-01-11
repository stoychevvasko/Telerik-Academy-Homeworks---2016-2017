////-----------------------------------------------------------------------
//// <copyright file="Tomcat.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_03
{
    /// <summary>
    /// Represents a cat.
    /// </summary>
    public class Tomcat : Cat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tomcat"/> class.
        /// </summary>
        /// <param name="age">A tomcat's age.</param>
        /// <param name="name">A tomcat's name.</param>        
        public Tomcat(uint age, string name)
            : base(age, name, Sex.Male)
        {
        }
    }
}
