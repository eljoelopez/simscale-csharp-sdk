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
    /// &lt;p&gt;&lt;b&gt;Specie:&lt;/b&gt; defines the molecular composition of the fluid material. Currently a single specie is available.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class SpecieDefault : IEquatable<SpecieDefault>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecieDefault" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpecieDefault() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecieDefault" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SPECIE&quot;).</param>
        /// <param name="amountOfSubstance">amountOfSubstance.</param>
        /// <param name="molarWeight">molarWeight.</param>
        public SpecieDefault(string type = "SPECIE", DimensionalAmountOfSubstance amountOfSubstance = default(DimensionalAmountOfSubstance), DimensionalMolarMass molarWeight = default(DimensionalMolarMass))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SpecieDefault and cannot be null");
            this.AmountOfSubstance = amountOfSubstance;
            this.MolarWeight = molarWeight;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AmountOfSubstance
        /// </summary>
        [DataMember(Name="amountOfSubstance", EmitDefaultValue=false)]
        public DimensionalAmountOfSubstance AmountOfSubstance { get; set; }

        /// <summary>
        /// Gets or Sets MolarWeight
        /// </summary>
        [DataMember(Name="molarWeight", EmitDefaultValue=false)]
        public DimensionalMolarMass MolarWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecieDefault {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AmountOfSubstance: ").Append(AmountOfSubstance).Append("\n");
            sb.Append("  MolarWeight: ").Append(MolarWeight).Append("\n");
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
            return this.Equals(input as SpecieDefault);
        }

        /// <summary>
        /// Returns true if SpecieDefault instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecieDefault to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecieDefault input)
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
                    this.AmountOfSubstance == input.AmountOfSubstance ||
                    (this.AmountOfSubstance != null &&
                    this.AmountOfSubstance.Equals(input.AmountOfSubstance))
                ) && 
                (
                    this.MolarWeight == input.MolarWeight ||
                    (this.MolarWeight != null &&
                    this.MolarWeight.Equals(input.MolarWeight))
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
                if (this.AmountOfSubstance != null)
                    hashCode = hashCode * 59 + this.AmountOfSubstance.GetHashCode();
                if (this.MolarWeight != null)
                    hashCode = hashCode * 59 + this.MolarWeight.GetHashCode();
                return hashCode;
            }
        }

    }

}
