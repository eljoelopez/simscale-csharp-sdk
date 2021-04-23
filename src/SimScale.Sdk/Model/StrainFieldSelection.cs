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
    /// StrainFieldSelection
    /// </summary>
    [DataContract]
    public partial class StrainFieldSelection : OneOfAverageFieldsCalculationResultControlItemFieldSelection, OneOfMinMaxFieldsCalculationResultControlItemFieldSelection, OneOfSumFieldsCalculationResultControlItemFieldSelection, OneOfTemporalResponseResultControlItemFieldSelection, IEquatable<StrainFieldSelection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StrainFieldSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StrainFieldSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StrainFieldSelection" /> class.
        /// </summary>
        /// <param name="type">Schema name: StrainFieldSelection (required) (default to &quot;STRAIN&quot;).</param>
        /// <param name="strainType">strainType.</param>
        public StrainFieldSelection(string type = "STRAIN", OneOfStrainFieldSelectionStrainType strainType = default(OneOfStrainFieldSelectionStrainType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StrainFieldSelection and cannot be null");
            this.StrainType = strainType;
        }
        
        /// <summary>
        /// Schema name: StrainFieldSelection
        /// </summary>
        /// <value>Schema name: StrainFieldSelection</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets StrainType
        /// </summary>
        [DataMember(Name="strainType", EmitDefaultValue=false)]
        public OneOfStrainFieldSelectionStrainType StrainType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrainFieldSelection {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as StrainFieldSelection);
        }

        /// <summary>
        /// Returns true if StrainFieldSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of StrainFieldSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StrainFieldSelection input)
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
                if (this.StrainType != null)
                    hashCode = hashCode * 59 + this.StrainType.GetHashCode();
                return hashCode;
            }
        }

    }

}
