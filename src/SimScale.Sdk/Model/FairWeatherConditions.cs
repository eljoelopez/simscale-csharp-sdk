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
    /// FairWeatherConditions
    /// </summary>
    [DataContract]
    public partial class FairWeatherConditions : OneOfSolarCalculatorSolarLoad, IEquatable<FairWeatherConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FairWeatherConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FairWeatherConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FairWeatherConditions" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FAIR_WEATHER_CONDITIONS&quot;).</param>
        /// <param name="skyCloudCoverFraction">skyCloudCoverFraction (default to 0M).</param>
        /// <param name="groundReflectivity">groundReflectivity (default to 0.2M).</param>
        /// <param name="a">a (default to 1230M).</param>
        /// <param name="b">b (default to 0.142M).</param>
        /// <param name="c">c (default to 0.058M).</param>
        public FairWeatherConditions(string type = "FAIR_WEATHER_CONDITIONS", decimal? skyCloudCoverFraction = default(decimal?), decimal? groundReflectivity = default(decimal?), decimal? a = default(decimal?), decimal? b = default(decimal?), decimal? c = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FairWeatherConditions and cannot be null");
            this.SkyCloudCoverFraction = skyCloudCoverFraction;
            this.GroundReflectivity = groundReflectivity;
            this.A = a;
            this.B = b;
            this.C = c;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SkyCloudCoverFraction
        /// </summary>
        [DataMember(Name="skyCloudCoverFraction", EmitDefaultValue=false)]
        public decimal? SkyCloudCoverFraction { get; set; }

        /// <summary>
        /// Gets or Sets GroundReflectivity
        /// </summary>
        [DataMember(Name="groundReflectivity", EmitDefaultValue=false)]
        public decimal? GroundReflectivity { get; set; }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name="A", EmitDefaultValue=false)]
        public decimal? A { get; set; }

        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name="B", EmitDefaultValue=false)]
        public decimal? B { get; set; }

        /// <summary>
        /// Gets or Sets C
        /// </summary>
        [DataMember(Name="C", EmitDefaultValue=false)]
        public decimal? C { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FairWeatherConditions {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SkyCloudCoverFraction: ").Append(SkyCloudCoverFraction).Append("\n");
            sb.Append("  GroundReflectivity: ").Append(GroundReflectivity).Append("\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
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
            return this.Equals(input as FairWeatherConditions);
        }

        /// <summary>
        /// Returns true if FairWeatherConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of FairWeatherConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FairWeatherConditions input)
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
                    this.SkyCloudCoverFraction == input.SkyCloudCoverFraction ||
                    (this.SkyCloudCoverFraction != null &&
                    this.SkyCloudCoverFraction.Equals(input.SkyCloudCoverFraction))
                ) && 
                (
                    this.GroundReflectivity == input.GroundReflectivity ||
                    (this.GroundReflectivity != null &&
                    this.GroundReflectivity.Equals(input.GroundReflectivity))
                ) && 
                (
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
                ) && 
                (
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
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
                if (this.SkyCloudCoverFraction != null)
                    hashCode = hashCode * 59 + this.SkyCloudCoverFraction.GetHashCode();
                if (this.GroundReflectivity != null)
                    hashCode = hashCode * 59 + this.GroundReflectivity.GetHashCode();
                if (this.A != null)
                    hashCode = hashCode * 59 + this.A.GetHashCode();
                if (this.B != null)
                    hashCode = hashCode * 59 + this.B.GetHashCode();
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
                return hashCode;
            }
        }

    }

}
