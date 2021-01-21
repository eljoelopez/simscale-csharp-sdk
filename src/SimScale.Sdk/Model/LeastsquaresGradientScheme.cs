/* 
 * SimScale API
 *
 * The version of the OpenAPI document: 0.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// LeastsquaresGradientScheme
    /// </summary>
    [DataContract]
    public partial class LeastsquaresGradientScheme : OneOfGradientSchemesForDefault, OneOfGradientSchemesGradDensity, OneOfGradientSchemesGradEnthalpy, OneOfGradientSchemesGradEpsilonDissipationRate, OneOfGradientSchemesGradInternalEnergy, OneOfGradientSchemesGradNuTilda, OneOfGradientSchemesGradOmegaDissipationRate, OneOfGradientSchemesGradPressure, OneOfGradientSchemesGradPressureRgh, OneOfGradientSchemesGradRhok, OneOfGradientSchemesGradTemperature, OneOfGradientSchemesGradTurbulentKineticEnergy, OneOfGradientSchemesGradVelocity, IEquatable<LeastsquaresGradientScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeastsquaresGradientScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LeastsquaresGradientScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LeastsquaresGradientScheme" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;LEASTSQUARES&quot;).</param>
        public LeastsquaresGradientScheme(string type = "LEASTSQUARES")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for LeastsquaresGradientScheme and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeastsquaresGradientScheme {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LeastsquaresGradientScheme);
        }

        /// <summary>
        /// Returns true if LeastsquaresGradientScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of LeastsquaresGradientScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeastsquaresGradientScheme input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
