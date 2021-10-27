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
    /// Color
    /// </summary>
    [DataContract]
    public partial class Color : IEquatable<Color>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Color() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        /// <param name="r">r (required).</param>
        /// <param name="g">g (required).</param>
        /// <param name="b">b (required).</param>
        public Color(float? r = default(float?), float? g = default(float?), float? b = default(float?))
        {
            // to ensure "r" is required (not null)
            this.R = r ?? throw new ArgumentNullException("r is a required property for Color and cannot be null");
            // to ensure "g" is required (not null)
            this.G = g ?? throw new ArgumentNullException("g is a required property for Color and cannot be null");
            // to ensure "b" is required (not null)
            this.B = b ?? throw new ArgumentNullException("b is a required property for Color and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets R
        /// </summary>
        [DataMember(Name="r", EmitDefaultValue=false)]
        public float? R { get; set; }

        /// <summary>
        /// Gets or Sets G
        /// </summary>
        [DataMember(Name="g", EmitDefaultValue=false)]
        public float? G { get; set; }

        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name="b", EmitDefaultValue=false)]
        public float? B { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Color {\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  G: ").Append(G).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
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
            return this.Equals(input as Color);
        }

        /// <summary>
        /// Returns true if Color instances are equal
        /// </summary>
        /// <param name="input">Instance of Color to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Color input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.G == input.G ||
                    (this.G != null &&
                    this.G.Equals(input.G))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
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
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.G != null)
                    hashCode = hashCode * 59 + this.G.GetHashCode();
                if (this.B != null)
                    hashCode = hashCode * 59 + this.B.GetHashCode();
                return hashCode;
            }
        }

    }

}
