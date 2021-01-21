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
    /// AccelerationResultControlItem
    /// </summary>
    [DataContract]
    public partial class AccelerationResultControlItem : OneOfSolidResultControlSolutionFields, IEquatable<AccelerationResultControlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccelerationResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccelerationResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccelerationResultControlItem" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;ACCELERATION&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="accelerationType">accelerationType.</param>
        public AccelerationResultControlItem(string type = "ACCELERATION", string name = default(string), GlobalAccelerationType accelerationType = default(GlobalAccelerationType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AccelerationResultControlItem and cannot be null");
            this.Name = name;
            this.AccelerationType = accelerationType;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AccelerationType
        /// </summary>
        [DataMember(Name="accelerationType", EmitDefaultValue=false)]
        public GlobalAccelerationType AccelerationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccelerationResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccelerationType: ").Append(AccelerationType).Append("\n");
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
            return this.Equals(input as AccelerationResultControlItem);
        }

        /// <summary>
        /// Returns true if AccelerationResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AccelerationResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccelerationResultControlItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccelerationType == input.AccelerationType ||
                    (this.AccelerationType != null &&
                    this.AccelerationType.Equals(input.AccelerationType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AccelerationType != null)
                    hashCode = hashCode * 59 + this.AccelerationType.GetHashCode();
                return hashCode;
            }
        }

    }

}
