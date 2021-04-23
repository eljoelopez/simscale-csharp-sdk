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
    /// This option controls how the simulation results are written and how frequently.
    /// </summary>
    [DataContract]
    public partial class AdjustableRuntimeWriteControl : OneOfFluidSimulationControlWriteControl, IEquatable<AdjustableRuntimeWriteControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustableRuntimeWriteControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdjustableRuntimeWriteControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustableRuntimeWriteControl" /> class.
        /// </summary>
        /// <param name="type">This option controls how the simulation results are written and how frequently.  Schema name: AdjustableRuntimeWriteControl (required) (default to &quot;ADJUSTABLE_RUNTIME&quot;).</param>
        /// <param name="writeInterval">writeInterval.</param>
        public AdjustableRuntimeWriteControl(string type = "ADJUSTABLE_RUNTIME", DimensionalTime writeInterval = default(DimensionalTime))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AdjustableRuntimeWriteControl and cannot be null");
            this.WriteInterval = writeInterval;
        }
        
        /// <summary>
        /// This option controls how the simulation results are written and how frequently.  Schema name: AdjustableRuntimeWriteControl
        /// </summary>
        /// <value>This option controls how the simulation results are written and how frequently.  Schema name: AdjustableRuntimeWriteControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets WriteInterval
        /// </summary>
        [DataMember(Name="writeInterval", EmitDefaultValue=false)]
        public DimensionalTime WriteInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdjustableRuntimeWriteControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WriteInterval: ").Append(WriteInterval).Append("\n");
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
            return this.Equals(input as AdjustableRuntimeWriteControl);
        }

        /// <summary>
        /// Returns true if AdjustableRuntimeWriteControl instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustableRuntimeWriteControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustableRuntimeWriteControl input)
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
                    this.WriteInterval == input.WriteInterval ||
                    (this.WriteInterval != null &&
                    this.WriteInterval.Equals(input.WriteInterval))
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
                if (this.WriteInterval != null)
                    hashCode = hashCode * 59 + this.WriteInterval.GetHashCode();
                return hashCode;
            }
        }

    }

}
