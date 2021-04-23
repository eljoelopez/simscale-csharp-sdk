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
    /// FrictionPenaltyCoef
    /// </summary>
    [DataContract]
    public partial class FrictionPenaltyCoef : OneOfFrictionContactFrictionCoefficient, IEquatable<FrictionPenaltyCoef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionPenaltyCoef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrictionPenaltyCoef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionPenaltyCoef" /> class.
        /// </summary>
        /// <param name="type">Schema name: FrictionPenaltyCoef (required) (default to &quot;FRICTION_PENALTY_COEF&quot;).</param>
        /// <param name="frictionPenaltyCoefficient">frictionPenaltyCoefficient (default to 100000M).</param>
        /// <param name="coulombCoefficient">coulombCoefficient (default to 0.1M).</param>
        public FrictionPenaltyCoef(string type = "FRICTION_PENALTY_COEF", decimal? frictionPenaltyCoefficient = default(decimal?), decimal? coulombCoefficient = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FrictionPenaltyCoef and cannot be null");
            this.FrictionPenaltyCoefficient = frictionPenaltyCoefficient;
            this.CoulombCoefficient = coulombCoefficient;
        }
        
        /// <summary>
        /// Schema name: FrictionPenaltyCoef
        /// </summary>
        /// <value>Schema name: FrictionPenaltyCoef</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FrictionPenaltyCoefficient
        /// </summary>
        [DataMember(Name="frictionPenaltyCoefficient", EmitDefaultValue=false)]
        public decimal? FrictionPenaltyCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets CoulombCoefficient
        /// </summary>
        [DataMember(Name="coulombCoefficient", EmitDefaultValue=false)]
        public decimal? CoulombCoefficient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrictionPenaltyCoef {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FrictionPenaltyCoefficient: ").Append(FrictionPenaltyCoefficient).Append("\n");
            sb.Append("  CoulombCoefficient: ").Append(CoulombCoefficient).Append("\n");
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
            return this.Equals(input as FrictionPenaltyCoef);
        }

        /// <summary>
        /// Returns true if FrictionPenaltyCoef instances are equal
        /// </summary>
        /// <param name="input">Instance of FrictionPenaltyCoef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FrictionPenaltyCoef input)
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
                    this.FrictionPenaltyCoefficient == input.FrictionPenaltyCoefficient ||
                    (this.FrictionPenaltyCoefficient != null &&
                    this.FrictionPenaltyCoefficient.Equals(input.FrictionPenaltyCoefficient))
                ) && 
                (
                    this.CoulombCoefficient == input.CoulombCoefficient ||
                    (this.CoulombCoefficient != null &&
                    this.CoulombCoefficient.Equals(input.CoulombCoefficient))
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
                if (this.FrictionPenaltyCoefficient != null)
                    hashCode = hashCode * 59 + this.FrictionPenaltyCoefficient.GetHashCode();
                if (this.CoulombCoefficient != null)
                    hashCode = hashCode * 59 + this.CoulombCoefficient.GetHashCode();
                return hashCode;
            }
        }

    }

}
