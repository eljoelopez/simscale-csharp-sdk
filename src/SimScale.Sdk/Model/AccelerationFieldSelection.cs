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
    /// AccelerationFieldSelection
    /// </summary>
    [DataContract]
    public partial class AccelerationFieldSelection : OneOfAverageFieldsCalculationResultControlItemFieldSelection, OneOfHarmonicResponseResultControlItemFieldSelection, OneOfMinMaxFieldsCalculationResultControlItemFieldSelection, OneOfSumFieldsCalculationResultControlItemFieldSelection, OneOfTemporalResponseResultControlItemFieldSelection, IEquatable<AccelerationFieldSelection>
    {
        /// <summary>
        /// Defines ComponentSelection
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComponentSelectionEnum
        {
            /// <summary>
            /// Enum X for value: X
            /// </summary>
            [EnumMember(Value = "X")]
            X = 1,

            /// <summary>
            /// Enum Y for value: Y
            /// </summary>
            [EnumMember(Value = "Y")]
            Y = 2,

            /// <summary>
            /// Enum Z for value: Z
            /// </summary>
            [EnumMember(Value = "Z")]
            Z = 3,

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 4

        }

        /// <summary>
        /// Gets or Sets ComponentSelection
        /// </summary>
        [DataMember(Name="componentSelection", EmitDefaultValue=false)]
        public ComponentSelectionEnum? ComponentSelection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccelerationFieldSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccelerationFieldSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccelerationFieldSelection" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;ACCELERATION&quot;).</param>
        /// <param name="componentSelection">componentSelection (default to ComponentSelectionEnum.ALL).</param>
        public AccelerationFieldSelection(string type = "ACCELERATION", ComponentSelectionEnum? componentSelection = default(ComponentSelectionEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AccelerationFieldSelection and cannot be null");
            this.ComponentSelection = componentSelection;
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
            sb.Append("class AccelerationFieldSelection {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ComponentSelection: ").Append(ComponentSelection).Append("\n");
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
            return this.Equals(input as AccelerationFieldSelection);
        }

        /// <summary>
        /// Returns true if AccelerationFieldSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of AccelerationFieldSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccelerationFieldSelection input)
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
                    this.ComponentSelection == input.ComponentSelection ||
                    this.ComponentSelection.Equals(input.ComponentSelection)
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
                hashCode = hashCode * 59 + this.ComponentSelection.GetHashCode();
                return hashCode;
            }
        }

    }

}
