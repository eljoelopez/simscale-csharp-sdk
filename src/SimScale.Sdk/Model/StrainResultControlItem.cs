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
    /// StrainResultControlItem
    /// </summary>
    [DataContract]
    public partial class StrainResultControlItem : OneOfSolidResultControlSolutionFields, IEquatable<StrainResultControlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrainResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrainResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrainResultControlItem" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;STRAIN&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="strainType">strainType.</param>
        public StrainResultControlItem(string type = "STRAIN", string name = default(string), OneOfStrainResultControlItemStrainType strainType = default(OneOfStrainResultControlItemStrainType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StrainResultControlItem and cannot be null");
            this.Name = name;
            this.StrainType = strainType;
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
        /// Gets or Sets StrainType
        /// </summary>
        [DataMember(Name="strainType", EmitDefaultValue=false)]
        public OneOfStrainResultControlItemStrainType StrainType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrainResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StrainType: ").Append(StrainType).Append("\n");
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
            return this.Equals(input as StrainResultControlItem);
        }

        /// <summary>
        /// Returns true if StrainResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of StrainResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrainResultControlItem input)
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
                    this.StrainType == input.StrainType ||
                    (this.StrainType != null &&
                    this.StrainType.Equals(input.StrainType))
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
                if (this.StrainType != null)
                    hashCode = hashCode * 59 + this.StrainType.GetHashCode();
                return hashCode;
            }
        }

    }

}
