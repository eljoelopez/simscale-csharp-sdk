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
    /// Lanczos
    /// </summary>
    [DataContract]
    public partial class Lanczos : OneOfSolidNumericsEigenSolver, IEquatable<Lanczos>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lanczos" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Lanczos() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Lanczos" /> class.
        /// </summary>
        /// <param name="type">Schema name: Lanczos (required) (default to &quot;TRI_DIAG&quot;).</param>
        /// <param name="precOrtho">precOrtho (default to 1.0E-12M).</param>
        /// <param name="nmaxIterOrtho">nmaxIterOrtho (default to 5).</param>
        /// <param name="precLanczos">precLanczos (default to 1.0E-8M).</param>
        /// <param name="maxIterQR">maxIterQR (default to 30).</param>
        /// <param name="modeRigid">modeRigid (default to true).</param>
        public Lanczos(string type = "TRI_DIAG", decimal? precOrtho = default(decimal?), int? nmaxIterOrtho = default(int?), decimal? precLanczos = default(decimal?), int? maxIterQR = default(int?), bool? modeRigid = default(bool?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for Lanczos and cannot be null");
            this.PrecOrtho = precOrtho;
            this.NmaxIterOrtho = nmaxIterOrtho;
            this.PrecLanczos = precLanczos;
            this.MaxIterQR = maxIterQR;
            this.ModeRigid = modeRigid;
        }
        
        /// <summary>
        /// Schema name: Lanczos
        /// </summary>
        /// <value>Schema name: Lanczos</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PrecOrtho
        /// </summary>
        [DataMember(Name="precOrtho", EmitDefaultValue=false)]
        public decimal? PrecOrtho { get; set; }

        /// <summary>
        /// Gets or Sets NmaxIterOrtho
        /// </summary>
        [DataMember(Name="nmaxIterOrtho", EmitDefaultValue=false)]
        public int? NmaxIterOrtho { get; set; }

        /// <summary>
        /// Gets or Sets PrecLanczos
        /// </summary>
        [DataMember(Name="precLanczos", EmitDefaultValue=false)]
        public decimal? PrecLanczos { get; set; }

        /// <summary>
        /// Gets or Sets MaxIterQR
        /// </summary>
        [DataMember(Name="maxIterQR", EmitDefaultValue=false)]
        public int? MaxIterQR { get; set; }

        /// <summary>
        /// Gets or Sets ModeRigid
        /// </summary>
        [DataMember(Name="modeRigid", EmitDefaultValue=false)]
        public bool? ModeRigid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Lanczos {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PrecOrtho: ").Append(PrecOrtho).Append("\n");
            sb.Append("  NmaxIterOrtho: ").Append(NmaxIterOrtho).Append("\n");
            sb.Append("  PrecLanczos: ").Append(PrecLanczos).Append("\n");
            sb.Append("  MaxIterQR: ").Append(MaxIterQR).Append("\n");
            sb.Append("  ModeRigid: ").Append(ModeRigid).Append("\n");
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
            return this.Equals(input as Lanczos);
        }

        /// <summary>
        /// Returns true if Lanczos instances are equal
        /// </summary>
        /// <param name="input">Instance of Lanczos to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Lanczos input)
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
                    this.PrecOrtho == input.PrecOrtho ||
                    (this.PrecOrtho != null &&
                    this.PrecOrtho.Equals(input.PrecOrtho))
                ) && 
                (
                    this.NmaxIterOrtho == input.NmaxIterOrtho ||
                    (this.NmaxIterOrtho != null &&
                    this.NmaxIterOrtho.Equals(input.NmaxIterOrtho))
                ) && 
                (
                    this.PrecLanczos == input.PrecLanczos ||
                    (this.PrecLanczos != null &&
                    this.PrecLanczos.Equals(input.PrecLanczos))
                ) && 
                (
                    this.MaxIterQR == input.MaxIterQR ||
                    (this.MaxIterQR != null &&
                    this.MaxIterQR.Equals(input.MaxIterQR))
                ) && 
                (
                    this.ModeRigid == input.ModeRigid ||
                    (this.ModeRigid != null &&
                    this.ModeRigid.Equals(input.ModeRigid))
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
                if (this.PrecOrtho != null)
                    hashCode = hashCode * 59 + this.PrecOrtho.GetHashCode();
                if (this.NmaxIterOrtho != null)
                    hashCode = hashCode * 59 + this.NmaxIterOrtho.GetHashCode();
                if (this.PrecLanczos != null)
                    hashCode = hashCode * 59 + this.PrecLanczos.GetHashCode();
                if (this.MaxIterQR != null)
                    hashCode = hashCode * 59 + this.MaxIterQR.GetHashCode();
                if (this.ModeRigid != null)
                    hashCode = hashCode * 59 + this.ModeRigid.GetHashCode();
                return hashCode;
            }
        }

    }

}
