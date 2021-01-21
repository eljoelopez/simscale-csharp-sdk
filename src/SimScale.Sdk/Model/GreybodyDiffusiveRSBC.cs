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
    /// GreybodyDiffusiveRSBC
    /// </summary>
    [DataContract]
    public partial class GreybodyDiffusiveRSBC : OneOfCustomFluidBCNetRadiativeHeatFlux, OneOfNaturalConvectionInletOutletBCNetRadiativeHeatFlux, OneOfPressureInletBCNetRadiativeHeatFlux, OneOfPressureOutletBCNetRadiativeHeatFlux, OneOfVelocityInletBCNetRadiativeHeatFlux, OneOfVelocityOutletBCNetRadiativeHeatFlux, OneOfWallBCNetRadiativeHeatFlux, IEquatable<GreybodyDiffusiveRSBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GreybodyDiffusiveRSBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GreybodyDiffusiveRSBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GreybodyDiffusiveRSBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;GREYBODY_DIFFUSIVE&quot;).</param>
        /// <param name="emissivity">emissivity.</param>
        public GreybodyDiffusiveRSBC(string type = "GREYBODY_DIFFUSIVE", DimensionalDimensionless emissivity = default(DimensionalDimensionless))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GreybodyDiffusiveRSBC and cannot be null");
            this.Emissivity = emissivity;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Emissivity
        /// </summary>
        [DataMember(Name="emissivity", EmitDefaultValue=false)]
        public DimensionalDimensionless Emissivity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GreybodyDiffusiveRSBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Emissivity: ").Append(Emissivity).Append("\n");
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
            return this.Equals(input as GreybodyDiffusiveRSBC);
        }

        /// <summary>
        /// Returns true if GreybodyDiffusiveRSBC instances are equal
        /// </summary>
        /// <param name="input">Instance of GreybodyDiffusiveRSBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GreybodyDiffusiveRSBC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Emissivity == input.Emissivity ||
                    (this.Emissivity != null &&
                    this.Emissivity.Equals(input.Emissivity))
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
                if (this.Emissivity != null)
                    hashCode = hashCode * 59 + this.Emissivity.GetHashCode();
                return hashCode;
            }
        }

    }

}
