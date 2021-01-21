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
    /// MultipliedSlaveNodesIterationControl
    /// </summary>
    [DataContract]
    public partial class MultipliedSlaveNodesIterationControl : OneOfFixedPointContactNonLinearityResolutionIterationControl, IEquatable<MultipliedSlaveNodesIterationControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipliedSlaveNodesIterationControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultipliedSlaveNodesIterationControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipliedSlaveNodesIterationControl" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;MULTIPLIED_SLAVE_NODE&quot;).</param>
        /// <param name="multipleValue">multipleValue (default to 4).</param>
        public MultipliedSlaveNodesIterationControl(string type = "MULTIPLIED_SLAVE_NODE", int? multipleValue = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MultipliedSlaveNodesIterationControl and cannot be null");
            this.MultipleValue = multipleValue;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MultipleValue
        /// </summary>
        [DataMember(Name="multipleValue", EmitDefaultValue=false)]
        public int? MultipleValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipliedSlaveNodesIterationControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MultipleValue: ").Append(MultipleValue).Append("\n");
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
            return this.Equals(input as MultipliedSlaveNodesIterationControl);
        }

        /// <summary>
        /// Returns true if MultipliedSlaveNodesIterationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipliedSlaveNodesIterationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipliedSlaveNodesIterationControl input)
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
                    this.MultipleValue == input.MultipleValue ||
                    (this.MultipleValue != null &&
                    this.MultipleValue.Equals(input.MultipleValue))
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
                if (this.MultipleValue != null)
                    hashCode = hashCode * 59 + this.MultipleValue.GetHashCode();
                return hashCode;
            }
        }

    }

}
