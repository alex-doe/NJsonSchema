//-----------------------------------------------------------------------
// <copyright file="CSharpPropertyNameGenerator.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/rsuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.CodeGeneration.CSharp
{
    /// <summary></summary>
    public class CSharpPropertyNameGenerator : IPropertyNameGenerator {
        /// <summary>Generates the property name.</summary>
        /// <param name="property">The property.</param>
        /// <returns>The new name.</returns>
        public virtual string Generate(JsonProperty property) {
            //return ConversionUtilities.ConvertToLowerCamelCase(property.Name, true).Replace("-", "_"); <-- im PT HACK DRY GEMACHT
            //PT HACK
            return Generate(property.Name);
            //END PT HACK
        }

        //PT HACK - da wir die funktion Generate(JsonProperty xx) nicht benutzen können wurde hier um eine mit stringparam erweitert
        //Ich habe die obige funktion angepasst damit wir hier nicht duplicate code haben
        /// <summary>Generates the property name from string.</summary>
        /// <param name="propertyName">The property name string.</param>
        /// <returns>The new name.</returns>
        public virtual string Generate(string propertyName) {
            return ConversionUtilities.ConvertToLowerCamelCase(propertyName, true).Replace("-", "_");
        }
        // END PT HACK
    }
}