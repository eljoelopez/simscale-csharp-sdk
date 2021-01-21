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
    /// TopologicalReference
    /// </summary>
    [DataContract]
    public partial class TopologicalReference : IEquatable<TopologicalReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologicalReference" /> class.
        /// </summary>
        /// <param name="entities">entities.</param>
        /// <param name="sets">sets.</param>
        public TopologicalReference(List<string> entities = default(List<string>), List<Guid?> sets = default(List<Guid?>))
        {
            this.Entities = entities;
            this.Sets = sets;
        }
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Gets or Sets Sets
        /// </summary>
        [DataMember(Name="sets", EmitDefaultValue=false)]
        public List<Guid?> Sets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopologicalReference {\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Sets: ").Append(Sets).Append("\n");
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
            return this.Equals(input as TopologicalReference);
        }

        /// <summary>
        /// Returns true if TopologicalReference instances are equal
        /// </summary>
        /// <param name="input">Instance of TopologicalReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopologicalReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
                ) && 
                (
                    this.Sets == input.Sets ||
                    this.Sets != null &&
                    input.Sets != null &&
                    this.Sets.SequenceEqual(input.Sets)
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
                if (this.Entities != null)
                    hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.Sets != null)
                    hashCode = hashCode * 59 + this.Sets.GetHashCode();
                return hashCode;
            }
        }

    }

}
