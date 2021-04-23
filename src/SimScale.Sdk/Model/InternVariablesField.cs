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
    /// &lt;p&gt;Select the field which should have a limited de-/increase within one increment.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class InternVariablesField : OneOfFieldChangeRetimingEventFieldSelection, IEquatable<InternVariablesField>
    {
        /// <summary>
        /// &lt;p&gt;Choose a field component for which the data schould be extracted.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose a field component for which the data schould be extracted.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComponentSelectionEnum
        {
            /// <summary>
            /// Enum V1 for value: V1
            /// </summary>
            [EnumMember(Value = "V1")]
            V1 = 1,

            /// <summary>
            /// Enum V2 for value: V2
            /// </summary>
            [EnumMember(Value = "V2")]
            V2 = 2,

            /// <summary>
            /// Enum V3 for value: V3
            /// </summary>
            [EnumMember(Value = "V3")]
            V3 = 3

        }

        /// <summary>
        /// &lt;p&gt;Choose a field component for which the data schould be extracted.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose a field component for which the data schould be extracted.&lt;/p&gt;</value>
        [DataMember(Name="componentSelection", EmitDefaultValue=false)]
        public ComponentSelectionEnum? ComponentSelection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternVariablesField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InternVariablesField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternVariablesField" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Select the field which should have a limited de-/increase within one increment.&lt;/p&gt;  Schema name: InternVariablesField (required) (default to &quot;INTERN_VARIABLES&quot;).</param>
        /// <param name="componentSelection">&lt;p&gt;Choose a field component for which the data schould be extracted.&lt;/p&gt; (default to ComponentSelectionEnum.V1).</param>
        public InternVariablesField(string type = "INTERN_VARIABLES", ComponentSelectionEnum? componentSelection = default(ComponentSelectionEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for InternVariablesField and cannot be null");
            this.ComponentSelection = componentSelection;
        }
        
        /// <summary>
        /// &lt;p&gt;Select the field which should have a limited de-/increase within one increment.&lt;/p&gt;  Schema name: InternVariablesField
        /// </summary>
        /// <value>&lt;p&gt;Select the field which should have a limited de-/increase within one increment.&lt;/p&gt;  Schema name: InternVariablesField</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InternVariablesField {\n");
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
            return this.Equals(input as InternVariablesField);
        }

        /// <summary>
        /// Returns true if InternVariablesField instances are equal
        /// </summary>
        /// <param name="input">Instance of InternVariablesField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternVariablesField input)
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
