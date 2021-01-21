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
    /// SimulationRuns
    /// </summary>
    [DataContract]
    public partial class SimulationRuns : IEquatable<SimulationRuns>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRuns" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="meta">meta.</param>
        /// <param name="embedded">embedded.</param>
        public SimulationRuns(CollectionLinks links = default(CollectionLinks), CollectionMeta meta = default(CollectionMeta), List<SimulationRun> embedded = default(List<SimulationRun>))
        {
            this.Links = links;
            this.Meta = meta;
            this.Embedded = embedded;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public CollectionLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="_meta", EmitDefaultValue=false)]
        public CollectionMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public List<SimulationRun> Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationRuns {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(input as SimulationRuns);
        }

        /// <summary>
        /// Returns true if SimulationRuns instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationRuns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationRuns input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    this.Embedded != null &&
                    input.Embedded != null &&
                    this.Embedded.SequenceEqual(input.Embedded)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Embedded != null)
                    hashCode = hashCode * 59 + this.Embedded.GetHashCode();
                return hashCode;
            }
        }

    }

}
