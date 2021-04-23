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
    /// NoSlipVBC
    /// </summary>
    [DataContract]
    public partial class NoSlipVBC : OneOfCustomFluidBCVelocity, OneOfWallBCVelocity, IEquatable<NoSlipVBC>
    {
        /// <summary>
        /// Defines TurbulenceWall
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TurbulenceWallEnum
        {
            /// <summary>
            /// Enum WALLFUNCTION for value: WALL_FUNCTION
            /// </summary>
            [EnumMember(Value = "WALL_FUNCTION")]
            WALLFUNCTION = 1,

            /// <summary>
            /// Enum FULLRESOLUTION for value: FULL_RESOLUTION
            /// </summary>
            [EnumMember(Value = "FULL_RESOLUTION")]
            FULLRESOLUTION = 2

        }

        /// <summary>
        /// Gets or Sets TurbulenceWall
        /// </summary>
        [DataMember(Name="turbulenceWall", EmitDefaultValue=false)]
        public TurbulenceWallEnum? TurbulenceWall { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSlipVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoSlipVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoSlipVBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: NoSlipVBC (required) (default to &quot;NO_SLIP&quot;).</param>
        /// <param name="turbulenceWall">turbulenceWall (default to TurbulenceWallEnum.WALLFUNCTION).</param>
        /// <param name="surfaceRoughness">surfaceRoughness.</param>
        public NoSlipVBC(string type = "NO_SLIP", TurbulenceWallEnum? turbulenceWall = default(TurbulenceWallEnum?), DimensionalLength surfaceRoughness = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NoSlipVBC and cannot be null");
            this.TurbulenceWall = turbulenceWall;
            this.SurfaceRoughness = surfaceRoughness;
        }
        
        /// <summary>
        /// Schema name: NoSlipVBC
        /// </summary>
        /// <value>Schema name: NoSlipVBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceRoughness
        /// </summary>
        [DataMember(Name="surfaceRoughness", EmitDefaultValue=false)]
        public DimensionalLength SurfaceRoughness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoSlipVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TurbulenceWall: ").Append(TurbulenceWall).Append("\n");
            sb.Append("  SurfaceRoughness: ").Append(SurfaceRoughness).Append("\n");
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
            return this.Equals(input as NoSlipVBC);
        }

        /// <summary>
        /// Returns true if NoSlipVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of NoSlipVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoSlipVBC input)
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
                    this.TurbulenceWall == input.TurbulenceWall ||
                    this.TurbulenceWall.Equals(input.TurbulenceWall)
                ) && 
                (
                    this.SurfaceRoughness == input.SurfaceRoughness ||
                    (this.SurfaceRoughness != null &&
                    this.SurfaceRoughness.Equals(input.SurfaceRoughness))
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
                hashCode = hashCode * 59 + this.TurbulenceWall.GetHashCode();
                if (this.SurfaceRoughness != null)
                    hashCode = hashCode * 59 + this.SurfaceRoughness.GetHashCode();
                return hashCode;
            }
        }

    }

}
