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
    /// WithFictitiousClearance
    /// </summary>
    [DataContract]
    public partial class WithFictitiousClearance : OneOfFrictionContactFictitiousClearance, OneOfFrictionlessContactFictitiousClearance, IEquatable<WithFictitiousClearance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithFictitiousClearance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WithFictitiousClearance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithFictitiousClearance" /> class.
        /// </summary>
        /// <param name="type">Schema name: WithFictitiousClearance (required) (default to &quot;WITH_FICTITIOUS_CLEARANCE&quot;).</param>
        /// <param name="masterClearance">masterClearance.</param>
        /// <param name="slaveClearance">slaveClearance.</param>
        public WithFictitiousClearance(string type = "WITH_FICTITIOUS_CLEARANCE", DimensionalFunctionLength masterClearance = default(DimensionalFunctionLength), DimensionalFunctionLength slaveClearance = default(DimensionalFunctionLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for WithFictitiousClearance and cannot be null");
            this.MasterClearance = masterClearance;
            this.SlaveClearance = slaveClearance;
        }
        
        /// <summary>
        /// Schema name: WithFictitiousClearance
        /// </summary>
        /// <value>Schema name: WithFictitiousClearance</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MasterClearance
        /// </summary>
        [DataMember(Name="masterClearance", EmitDefaultValue=false)]
        public DimensionalFunctionLength MasterClearance { get; set; }

        /// <summary>
        /// Gets or Sets SlaveClearance
        /// </summary>
        [DataMember(Name="slaveClearance", EmitDefaultValue=false)]
        public DimensionalFunctionLength SlaveClearance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WithFictitiousClearance {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MasterClearance: ").Append(MasterClearance).Append("\n");
            sb.Append("  SlaveClearance: ").Append(SlaveClearance).Append("\n");
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
            return this.Equals(input as WithFictitiousClearance);
        }

        /// <summary>
        /// Returns true if WithFictitiousClearance instances are equal
        /// </summary>
        /// <param name="input">Instance of WithFictitiousClearance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithFictitiousClearance input)
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
                    this.MasterClearance == input.MasterClearance ||
                    (this.MasterClearance != null &&
                    this.MasterClearance.Equals(input.MasterClearance))
                ) && 
                (
                    this.SlaveClearance == input.SlaveClearance ||
                    (this.SlaveClearance != null &&
                    this.SlaveClearance.Equals(input.SlaveClearance))
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
                if (this.MasterClearance != null)
                    hashCode = hashCode * 59 + this.MasterClearance.GetHashCode();
                if (this.SlaveClearance != null)
                    hashCode = hashCode * 59 + this.SlaveClearance.GetHashCode();
                return hashCode;
            }
        }

    }

}
