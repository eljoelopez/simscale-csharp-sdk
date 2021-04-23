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
    /// FrictionAugmentedLagrangeCoef
    /// </summary>
    [DataContract]
    public partial class FrictionAugmentedLagrangeCoef : OneOfFrictionContactFrictionCoefficient, IEquatable<FrictionAugmentedLagrangeCoef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionAugmentedLagrangeCoef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrictionAugmentedLagrangeCoef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionAugmentedLagrangeCoef" /> class.
        /// </summary>
        /// <param name="type">Schema name: FrictionAugmentedLagrangeCoef (required) (default to &quot;FRICTION_AUGMENTATION_COEF&quot;).</param>
        /// <param name="frictionAugmentationCoefficient">frictionAugmentationCoefficient.</param>
        /// <param name="coulombCoefficient">coulombCoefficient (default to 0.1M).</param>
        public FrictionAugmentedLagrangeCoef(string type = "FRICTION_AUGMENTATION_COEF", DimensionalFrictionAugmentation frictionAugmentationCoefficient = default(DimensionalFrictionAugmentation), decimal? coulombCoefficient = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FrictionAugmentedLagrangeCoef and cannot be null");
            this.FrictionAugmentationCoefficient = frictionAugmentationCoefficient;
            this.CoulombCoefficient = coulombCoefficient;
        }
        
        /// <summary>
        /// Schema name: FrictionAugmentedLagrangeCoef
        /// </summary>
        /// <value>Schema name: FrictionAugmentedLagrangeCoef</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FrictionAugmentationCoefficient
        /// </summary>
        [DataMember(Name="frictionAugmentationCoefficient", EmitDefaultValue=false)]
        public DimensionalFrictionAugmentation FrictionAugmentationCoefficient { get; set; }

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
            sb.Append("class FrictionAugmentedLagrangeCoef {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FrictionAugmentationCoefficient: ").Append(FrictionAugmentationCoefficient).Append("\n");
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
            return this.Equals(input as FrictionAugmentedLagrangeCoef);
        }

        /// <summary>
        /// Returns true if FrictionAugmentedLagrangeCoef instances are equal
        /// </summary>
        /// <param name="input">Instance of FrictionAugmentedLagrangeCoef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FrictionAugmentedLagrangeCoef input)
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
                    this.FrictionAugmentationCoefficient == input.FrictionAugmentationCoefficient ||
                    (this.FrictionAugmentationCoefficient != null &&
                    this.FrictionAugmentationCoefficient.Equals(input.FrictionAugmentationCoefficient))
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
                if (this.FrictionAugmentationCoefficient != null)
                    hashCode = hashCode * 59 + this.FrictionAugmentationCoefficient.GetHashCode();
                if (this.CoulombCoefficient != null)
                    hashCode = hashCode * 59 + this.CoulombCoefficient.GetHashCode();
                return hashCode;
            }
        }

    }

}
