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
    /// VariableGroupTIME
    /// </summary>
    [DataContract]
    public partial class VariableGroupTIME : IEquatable<VariableGroupTIME>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableGroupTIME" /> class.
        /// </summary>
        /// <param name="t">t.</param>
        public VariableGroupTIME(UnitTime t = default(UnitTime))
        {
            this.T = t;
        }
        
        /// <summary>
        /// Gets or Sets T
        /// </summary>
        [DataMember(Name="T", EmitDefaultValue=false)]
        public UnitTime T { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableGroupTIME {\n");
            sb.Append("  T: ").Append(T).Append("\n");
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
            return this.Equals(input as VariableGroupTIME);
        }

        /// <summary>
        /// Returns true if VariableGroupTIME instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableGroupTIME to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableGroupTIME input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.T == input.T ||
                    (this.T != null &&
                    this.T.Equals(input.T))
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
                if (this.T != null)
                    hashCode = hashCode * 59 + this.T.GetHashCode();
                return hashCode;
            }
        }

    }

}
