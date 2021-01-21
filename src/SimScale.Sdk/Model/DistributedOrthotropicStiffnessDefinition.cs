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
    /// DistributedOrthotropicStiffnessDefinition
    /// </summary>
    [DataContract]
    public partial class DistributedOrthotropicStiffnessDefinition : OneOfOrthotropicSpringStiffnessStiffnessDefinition, IEquatable<DistributedOrthotropicStiffnessDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedOrthotropicStiffnessDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DistributedOrthotropicStiffnessDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedOrthotropicStiffnessDefinition" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;DISTRIBUTED_ORTHOTROPIC&quot;).</param>
        /// <param name="distributed">distributed.</param>
        public DistributedOrthotropicStiffnessDefinition(string type = "DISTRIBUTED_ORTHOTROPIC", DimensionalVectorVolumeForce distributed = default(DimensionalVectorVolumeForce))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for DistributedOrthotropicStiffnessDefinition and cannot be null");
            this.Distributed = distributed;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Distributed
        /// </summary>
        [DataMember(Name="distributed", EmitDefaultValue=false)]
        public DimensionalVectorVolumeForce Distributed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistributedOrthotropicStiffnessDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Distributed: ").Append(Distributed).Append("\n");
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
            return this.Equals(input as DistributedOrthotropicStiffnessDefinition);
        }

        /// <summary>
        /// Returns true if DistributedOrthotropicStiffnessDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DistributedOrthotropicStiffnessDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DistributedOrthotropicStiffnessDefinition input)
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
                    this.Distributed == input.Distributed ||
                    (this.Distributed != null &&
                    this.Distributed.Equals(input.Distributed))
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
                if (this.Distributed != null)
                    hashCode = hashCode * 59 + this.Distributed.GetHashCode();
                return hashCode;
            }
        }

    }

}
