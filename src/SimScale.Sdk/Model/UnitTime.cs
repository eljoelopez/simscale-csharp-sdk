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
    /// UnitTime
    /// </summary>
    [DataContract]
    public partial class UnitTime : IEquatable<UnitTime>
    {
        /// <summary>
        /// Defines Unit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum S for value: s
            /// </summary>
            [EnumMember(Value = "s")]
            S = 1

        }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTime" /> class.
        /// </summary>
        /// <param name="unit">unit.</param>
        public UnitTime(UnitEnum? unit = default(UnitEnum?))
        {
            this.Unit = unit;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnitTime {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as UnitTime);
        }

        /// <summary>
        /// Returns true if UnitTime instances are equal
        /// </summary>
        /// <param name="input">Instance of UnitTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnitTime input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
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
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }

    }

}
