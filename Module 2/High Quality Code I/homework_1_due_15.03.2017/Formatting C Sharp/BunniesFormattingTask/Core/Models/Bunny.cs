////-------------------------------------------------------------------------------------------------
//// <copyright file="Bunny.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask.Core.Models
{
    using System;
    using System.Text;
    using Enumerations;
    using Extensions;
    using Interfaces;

    /// <summary>
    /// Models a real-life bunny.
    /// </summary>
    [Serializable]
    public class Bunny
    {
        /// <summary>
        /// Gets or sets the age value of a <see cref="Bunny"/>-class object.
        /// </summary>
        public int Age
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name value of a <see cref="Bunny"/>-class object.
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FurType value of a <see cref="Bunny"/>-class object.
        /// </summary>
        public FurType FurType
        {
            get;
            set;
        }

        /// <summary>
        /// Introduces a <see cref="Bunny"/>-class object using the standard writer functionality.
        /// </summary>
        /// <param name="writer">A <see cref="IWriter"/>-type object.</param>
        public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        }

        /// <summary>
        /// Converts a <see cref="Bunny"/>-class object to its standard <see cref="string"/>-form representation.
        /// </summary>
        /// <returns>A new <see cref="string"/>-format bunny object.</returns>
        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }
}
