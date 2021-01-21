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
    /// TableFunctionParameter
    /// </summary>
    [DataContract]
    public partial class TableFunctionParameter : IEquatable<TableFunctionParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableFunctionParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TableFunctionParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableFunctionParameter" /> class.
        /// </summary>
        /// <param name="reference">reference (required).</param>
        /// <param name="_parameter">_parameter.</param>
        /// <param name="unit">unit (required).</param>
        public TableFunctionParameter(int? reference = default(int?), string _parameter = default(string), string unit = default(string))
        {
            // to ensure "reference" is required (not null)
            this.Reference = reference ?? throw new ArgumentNullException("reference is a required property for TableFunctionParameter and cannot be null");
            // to ensure "unit" is required (not null)
            this.Unit = unit ?? throw new ArgumentNullException("unit is a required property for TableFunctionParameter and cannot be null");
            this.Parameter = _parameter;
        }
        
        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public int? Reference { get; set; }

        /// <summary>
        /// Gets or Sets Parameter
        /// </summary>
        [DataMember(Name="parameter", EmitDefaultValue=false)]
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableFunctionParameter {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as TableFunctionParameter);
        }

        /// <summary>
        /// Returns true if TableFunctionParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of TableFunctionParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableFunctionParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Parameter != null)
                    hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }

    }

}
