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
    /// VectorRotation
    /// </summary>
    [DataContract]
    public partial class VectorRotation : OneOfRotatingMotionTypeRotation, OneOfRotatingSBMRotation, IEquatable<VectorRotation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorRotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VectorRotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorRotation" /> class.
        /// </summary>
        /// <param name="type">Schema name: VectorRotation (required) (default to &quot;VECTOR_ROTATION&quot;).</param>
        /// <param name="rotationCenter">rotationCenter.</param>
        /// <param name="angularVelocity">angularVelocity.</param>
        public VectorRotation(string type = "VECTOR_ROTATION", DimensionalVectorLength rotationCenter = default(DimensionalVectorLength), DimensionalVectorRotationSpeed angularVelocity = default(DimensionalVectorRotationSpeed))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for VectorRotation and cannot be null");
            this.RotationCenter = rotationCenter;
            this.AngularVelocity = angularVelocity;
        }
        
        /// <summary>
        /// Schema name: VectorRotation
        /// </summary>
        /// <value>Schema name: VectorRotation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RotationCenter
        /// </summary>
        [DataMember(Name="rotationCenter", EmitDefaultValue=false)]
        public DimensionalVectorLength RotationCenter { get; set; }

        /// <summary>
        /// Gets or Sets AngularVelocity
        /// </summary>
        [DataMember(Name="angularVelocity", EmitDefaultValue=false)]
        public DimensionalVectorRotationSpeed AngularVelocity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VectorRotation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RotationCenter: ").Append(RotationCenter).Append("\n");
            sb.Append("  AngularVelocity: ").Append(AngularVelocity).Append("\n");
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
            return this.Equals(input as VectorRotation);
        }

        /// <summary>
        /// Returns true if VectorRotation instances are equal
        /// </summary>
        /// <param name="input">Instance of VectorRotation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VectorRotation input)
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
                    this.RotationCenter == input.RotationCenter ||
                    (this.RotationCenter != null &&
                    this.RotationCenter.Equals(input.RotationCenter))
                ) && 
                (
                    this.AngularVelocity == input.AngularVelocity ||
                    (this.AngularVelocity != null &&
                    this.AngularVelocity.Equals(input.AngularVelocity))
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
                if (this.RotationCenter != null)
                    hashCode = hashCode * 59 + this.RotationCenter.GetHashCode();
                if (this.AngularVelocity != null)
                    hashCode = hashCode * 59 + this.AngularVelocity.GetHashCode();
                return hashCode;
            }
        }

    }

}
