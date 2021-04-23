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
    /// CubicInterpolationScheme
    /// </summary>
    [DataContract]
    public partial class CubicInterpolationScheme : OneOfInterpolationSchemesForDefault, OneOfInterpolationSchemesInterpolateGradEnthalpy, OneOfInterpolationSchemesInterpolateHbyA, OneOfInterpolationSchemesInterpolateKappa, OneOfInterpolationSchemesInterpolateMapKappa, OneOfInterpolationSchemesInterpolateRAU, OneOfInterpolationSchemesInterpolateRho, OneOfInterpolationSchemesInterpolateRho0Velocity0, OneOfInterpolationSchemesInterpolateRhoHbya, OneOfInterpolationSchemesInterpolateRhoRAU, OneOfInterpolationSchemesInterpolateThermoRhoCp, OneOfInterpolationSchemesInterpolateVelocity, OneOfInterpolationSchemesInterpolateVelocity0, OneOfInterpolationSchemesReconstructRho, OneOfInterpolationSchemesReconstructTemperature, OneOfInterpolationSchemesReconstructVelocity, IEquatable<CubicInterpolationScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CubicInterpolationScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CubicInterpolationScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CubicInterpolationScheme" /> class.
        /// </summary>
        /// <param name="type">Schema name: CubicInterpolationScheme (required) (default to &quot;CUBIC&quot;).</param>
        public CubicInterpolationScheme(string type = "CUBIC")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CubicInterpolationScheme and cannot be null");
        }
        
        /// <summary>
        /// Schema name: CubicInterpolationScheme
        /// </summary>
        /// <value>Schema name: CubicInterpolationScheme</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CubicInterpolationScheme {\n");
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
            return this.Equals(input as CubicInterpolationScheme);
        }

        /// <summary>
        /// Returns true if CubicInterpolationScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of CubicInterpolationScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CubicInterpolationScheme input)
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
