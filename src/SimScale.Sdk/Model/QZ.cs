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
    /// QZ
    /// </summary>
    [DataContract]
    public partial class QZ : OneOfSolidNumericsEigenSolver, IEquatable<QZ>
    {
        /// <summary>
        /// Defines TypeQZ
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeQZEnum
        {
            /// <summary>
            /// Enum SIMPLE for value: QZ_SIMPLE
            /// </summary>
            [EnumMember(Value = "QZ_SIMPLE")]
            SIMPLE = 1,

            /// <summary>
            /// Enum EQUI for value: QZ_EQUI
            /// </summary>
            [EnumMember(Value = "QZ_EQUI")]
            EQUI = 2,

            /// <summary>
            /// Enum QR for value: QZ_QR
            /// </summary>
            [EnumMember(Value = "QZ_QR")]
            QR = 3

        }

        /// <summary>
        /// Gets or Sets TypeQZ
        /// </summary>
        [DataMember(Name="typeQZ", EmitDefaultValue=false)]
        public TypeQZEnum? TypeQZ { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QZ" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QZ() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QZ" /> class.
        /// </summary>
        /// <param name="type">Schema name: QZ (required) (default to &quot;QZ&quot;).</param>
        /// <param name="typeQZ">typeQZ (default to TypeQZEnum.SIMPLE).</param>
        public QZ(string type = "QZ", TypeQZEnum? typeQZ = default(TypeQZEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for QZ and cannot be null");
            this.TypeQZ = typeQZ;
        }
        
        /// <summary>
        /// Schema name: QZ
        /// </summary>
        /// <value>Schema name: QZ</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QZ {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeQZ: ").Append(TypeQZ).Append("\n");
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
            return this.Equals(input as QZ);
        }

        /// <summary>
        /// Returns true if QZ instances are equal
        /// </summary>
        /// <param name="input">Instance of QZ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QZ input)
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
                    this.TypeQZ == input.TypeQZ ||
                    this.TypeQZ.Equals(input.TypeQZ)
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
                hashCode = hashCode * 59 + this.TypeQZ.GetHashCode();
                return hashCode;
            }
        }

    }

}
