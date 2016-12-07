//-----------------------------------------------------------------------
// <copyright file="IPropertyNameGenerator.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/rsuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema.CodeGeneration
{
    /// <summary>Generates the property name for a given <see cref="JsonProperty"/>.</summary>
    public interface IPropertyNameGenerator
    {
        /// <summary>Generates the property name.</summary>
        /// <param name="property">The property.</param>
        /// <returns>The new name.</returns>
        string Generate(JsonProperty property);


        // PT HACK - die funktion um string erweitern
        /// <summary>Generates the property name.</summary>
        /// <param name="propertyName">The property.</param>
        /// <returns>The new name.</returns>
        string Generate(string propertyName);
        //END PT HACK
    }
}