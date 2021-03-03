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
    /// Choose between &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/#newtonian-model&#39; target&#x3D;&#39;_blank&#39;&gt;Newtonian&lt;/a&gt; and &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/non-newtonian-models/&#39; target&#x3D;&#39;_blank&#39;&gt;Non-Newtonian&lt;/a&gt; viscosity models.
    /// </summary>
    [DataContract]
    public partial class PowerLawViscosityModel : OneOfIncompressibleMaterialViscosityModel, IEquatable<PowerLawViscosityModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerLawViscosityModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PowerLawViscosityModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerLawViscosityModel" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;POWER_LAW&quot;).</param>
        /// <param name="k">k.</param>
        /// <param name="n">n.</param>
        /// <param name="nuMin">nuMin.</param>
        /// <param name="nuMax">nuMax.</param>
        public PowerLawViscosityModel(string type = "POWER_LAW", DimensionalKinematicViscosity k = default(DimensionalKinematicViscosity), DimensionalDimensionless n = default(DimensionalDimensionless), DimensionalKinematicViscosity nuMin = default(DimensionalKinematicViscosity), DimensionalKinematicViscosity nuMax = default(DimensionalKinematicViscosity))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PowerLawViscosityModel and cannot be null");
            this.K = k;
            this.N = n;
            this.NuMin = nuMin;
            this.NuMax = nuMax;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets K
        /// </summary>
        [DataMember(Name="k", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity K { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public DimensionalDimensionless N { get; set; }

        /// <summary>
        /// Gets or Sets NuMin
        /// </summary>
        [DataMember(Name="nuMin", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity NuMin { get; set; }

        /// <summary>
        /// Gets or Sets NuMax
        /// </summary>
        [DataMember(Name="nuMax", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity NuMax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerLawViscosityModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  NuMin: ").Append(NuMin).Append("\n");
            sb.Append("  NuMax: ").Append(NuMax).Append("\n");
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
            return this.Equals(input as PowerLawViscosityModel);
        }

        /// <summary>
        /// Returns true if PowerLawViscosityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PowerLawViscosityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerLawViscosityModel input)
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
                    this.K == input.K ||
                    (this.K != null &&
                    this.K.Equals(input.K))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.NuMin == input.NuMin ||
                    (this.NuMin != null &&
                    this.NuMin.Equals(input.NuMin))
                ) && 
                (
                    this.NuMax == input.NuMax ||
                    (this.NuMax != null &&
                    this.NuMax.Equals(input.NuMax))
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
                if (this.K != null)
                    hashCode = hashCode * 59 + this.K.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.NuMin != null)
                    hashCode = hashCode * 59 + this.NuMin.GetHashCode();
                if (this.NuMax != null)
                    hashCode = hashCode * 59 + this.NuMax.GetHashCode();
                return hashCode;
            }
        }

    }

}
