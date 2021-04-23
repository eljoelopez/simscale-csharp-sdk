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
    /// ZeroGradientEVBC
    /// </summary>
    [DataContract]
    public partial class ZeroGradientEVBC : OneOfCustomFluidBCEddyViscosity, IEquatable<ZeroGradientEVBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroGradientEVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZeroGradientEVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroGradientEVBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: ZeroGradientEVBC (required) (default to &quot;ZERO_GRADIENT&quot;).</param>
        public ZeroGradientEVBC(string type = "ZERO_GRADIENT")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ZeroGradientEVBC and cannot be null");
        }
        
        /// <summary>
        /// Schema name: ZeroGradientEVBC
        /// </summary>
        /// <value>Schema name: ZeroGradientEVBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZeroGradientEVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ZeroGradientEVBC);
        }

        /// <summary>
        /// Returns true if ZeroGradientEVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of ZeroGradientEVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZeroGradientEVBC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                return hashCode;
            }
        }

    }

}
