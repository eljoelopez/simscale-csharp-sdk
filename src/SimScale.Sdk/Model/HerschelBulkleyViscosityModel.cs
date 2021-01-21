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
    /// Choose a viscosity model.
    /// </summary>
    [DataContract]
    public partial class HerschelBulkleyViscosityModel : OneOfIncompressibleMaterialViscosityModel, IEquatable<HerschelBulkleyViscosityModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HerschelBulkleyViscosityModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HerschelBulkleyViscosityModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HerschelBulkleyViscosityModel" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;HERSCHEL_BULKLEY&quot;).</param>
        /// <param name="k">k.</param>
        /// <param name="n">n.</param>
        /// <param name="tau0">tau0.</param>
        /// <param name="nu0">nu0.</param>
        public HerschelBulkleyViscosityModel(string type = "HERSCHEL_BULKLEY", DimensionalKinematicViscosity k = default(DimensionalKinematicViscosity), DimensionalDimensionless n = default(DimensionalDimensionless), DimensionalTurbulenceKineticEnergy tau0 = default(DimensionalTurbulenceKineticEnergy), DimensionalKinematicViscosity nu0 = default(DimensionalKinematicViscosity))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HerschelBulkleyViscosityModel and cannot be null");
            this.K = k;
            this.N = n;
            this.Tau0 = tau0;
            this.Nu0 = nu0;
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
        /// Gets or Sets Tau0
        /// </summary>
        [DataMember(Name="tau0", EmitDefaultValue=false)]
        public DimensionalTurbulenceKineticEnergy Tau0 { get; set; }

        /// <summary>
        /// Gets or Sets Nu0
        /// </summary>
        [DataMember(Name="nu0", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity Nu0 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HerschelBulkleyViscosityModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Tau0: ").Append(Tau0).Append("\n");
            sb.Append("  Nu0: ").Append(Nu0).Append("\n");
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
            return this.Equals(input as HerschelBulkleyViscosityModel);
        }

        /// <summary>
        /// Returns true if HerschelBulkleyViscosityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of HerschelBulkleyViscosityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HerschelBulkleyViscosityModel input)
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
                    this.Tau0 == input.Tau0 ||
                    (this.Tau0 != null &&
                    this.Tau0.Equals(input.Tau0))
                ) && 
                (
                    this.Nu0 == input.Nu0 ||
                    (this.Nu0 != null &&
                    this.Nu0.Equals(input.Nu0))
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
                if (this.Tau0 != null)
                    hashCode = hashCode * 59 + this.Tau0.GetHashCode();
                if (this.Nu0 != null)
                    hashCode = hashCode * 59 + this.Nu0.GetHashCode();
                return hashCode;
            }
        }

    }

}
