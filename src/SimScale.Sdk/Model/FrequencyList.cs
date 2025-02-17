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
    /// &lt;p&gt;Set the frequencies for the harmonic excitation. Setting it to &lt;b&gt;single frequency&lt;/b&gt; will only compute harmonic excitation on that frequency. To have harmonic excitations on multiple frequencies, please choose &lt;b&gt;frequency list&lt;/b&gt;. &lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class FrequencyList : OneOfSolidSimulationControlExcitationFrequencies, IEquatable<FrequencyList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrequencyList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyList" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Set the frequencies for the harmonic excitation. Setting it to &lt;b&gt;single frequency&lt;/b&gt; will only compute harmonic excitation on that frequency. To have harmonic excitations on multiple frequencies, please choose &lt;b&gt;frequency list&lt;/b&gt;. &lt;/p&gt;  Schema name: FrequencyList (required) (default to &quot;LIST_V20&quot;).</param>
        /// <param name="startFrequency">startFrequency.</param>
        /// <param name="endFrequency">endFrequency.</param>
        /// <param name="frequencyStepping">frequencyStepping.</param>
        public FrequencyList(string type = "LIST_V20", DimensionalFrequency startFrequency = default(DimensionalFrequency), DimensionalFrequency endFrequency = default(DimensionalFrequency), RestrictedDimensionalFunctionFrequency frequencyStepping = default(RestrictedDimensionalFunctionFrequency))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FrequencyList and cannot be null");
            this.StartFrequency = startFrequency;
            this.EndFrequency = endFrequency;
            this.FrequencyStepping = frequencyStepping;
        }
        
        /// <summary>
        /// &lt;p&gt;Set the frequencies for the harmonic excitation. Setting it to &lt;b&gt;single frequency&lt;/b&gt; will only compute harmonic excitation on that frequency. To have harmonic excitations on multiple frequencies, please choose &lt;b&gt;frequency list&lt;/b&gt;. &lt;/p&gt;  Schema name: FrequencyList
        /// </summary>
        /// <value>&lt;p&gt;Set the frequencies for the harmonic excitation. Setting it to &lt;b&gt;single frequency&lt;/b&gt; will only compute harmonic excitation on that frequency. To have harmonic excitations on multiple frequencies, please choose &lt;b&gt;frequency list&lt;/b&gt;. &lt;/p&gt;  Schema name: FrequencyList</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets StartFrequency
        /// </summary>
        [DataMember(Name="startFrequency", EmitDefaultValue=false)]
        public DimensionalFrequency StartFrequency { get; set; }

        /// <summary>
        /// Gets or Sets EndFrequency
        /// </summary>
        [DataMember(Name="endFrequency", EmitDefaultValue=false)]
        public DimensionalFrequency EndFrequency { get; set; }

        /// <summary>
        /// Gets or Sets FrequencyStepping
        /// </summary>
        [DataMember(Name="frequencyStepping", EmitDefaultValue=false)]
        public RestrictedDimensionalFunctionFrequency FrequencyStepping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrequencyList {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartFrequency: ").Append(StartFrequency).Append("\n");
            sb.Append("  EndFrequency: ").Append(EndFrequency).Append("\n");
            sb.Append("  FrequencyStepping: ").Append(FrequencyStepping).Append("\n");
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
            return this.Equals(input as FrequencyList);
        }

        /// <summary>
        /// Returns true if FrequencyList instances are equal
        /// </summary>
        /// <param name="input">Instance of FrequencyList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FrequencyList input)
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
                    this.StartFrequency == input.StartFrequency ||
                    (this.StartFrequency != null &&
                    this.StartFrequency.Equals(input.StartFrequency))
                ) && 
                (
                    this.EndFrequency == input.EndFrequency ||
                    (this.EndFrequency != null &&
                    this.EndFrequency.Equals(input.EndFrequency))
                ) && 
                (
                    this.FrequencyStepping == input.FrequencyStepping ||
                    (this.FrequencyStepping != null &&
                    this.FrequencyStepping.Equals(input.FrequencyStepping))
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
                if (this.StartFrequency != null)
                    hashCode = hashCode * 59 + this.StartFrequency.GetHashCode();
                if (this.EndFrequency != null)
                    hashCode = hashCode * 59 + this.EndFrequency.GetHashCode();
                if (this.FrequencyStepping != null)
                    hashCode = hashCode * 59 + this.FrequencyStepping.GetHashCode();
                return hashCode;
            }
        }

    }

}
