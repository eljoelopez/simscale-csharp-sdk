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
    /// AutomaticMeshSizingSimmetrix
    /// </summary>
    [DataContract]
    public partial class AutomaticMeshSizingSimmetrix : OneOfSimmetrixMeshingFluidSizing, OneOfSimmetrixMeshingSolidSizing, IEquatable<AutomaticMeshSizingSimmetrix>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticMeshSizingSimmetrix" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticMeshSizingSimmetrix() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticMeshSizingSimmetrix" /> class.
        /// </summary>
        /// <param name="type">Schema name: AutomaticMeshSizingSimmetrix (required) (default to &quot;AUTOMATIC_V9&quot;).</param>
        /// <param name="fineness">&lt;p&gt;Adjust the overall mesh sizing from coarse (value: 0) to fine (10).&lt;/p&gt; (default to 5M).</param>
        public AutomaticMeshSizingSimmetrix(string type = "AUTOMATIC_V9", decimal? fineness = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AutomaticMeshSizingSimmetrix and cannot be null");
            this.Fineness = fineness;
        }
        
        /// <summary>
        /// Schema name: AutomaticMeshSizingSimmetrix
        /// </summary>
        /// <value>Schema name: AutomaticMeshSizingSimmetrix</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Adjust the overall mesh sizing from coarse (value: 0) to fine (10).&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Adjust the overall mesh sizing from coarse (value: 0) to fine (10).&lt;/p&gt;</value>
        [DataMember(Name="fineness", EmitDefaultValue=false)]
        public decimal? Fineness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticMeshSizingSimmetrix {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fineness: ").Append(Fineness).Append("\n");
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
            return this.Equals(input as AutomaticMeshSizingSimmetrix);
        }

        /// <summary>
        /// Returns true if AutomaticMeshSizingSimmetrix instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticMeshSizingSimmetrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticMeshSizingSimmetrix input)
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
                    this.Fineness == input.Fineness ||
                    (this.Fineness != null &&
                    this.Fineness.Equals(input.Fineness))
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
                if (this.Fineness != null)
                    hashCode = hashCode * 59 + this.Fineness.GetHashCode();
                return hashCode;
            }
        }

    }

}
