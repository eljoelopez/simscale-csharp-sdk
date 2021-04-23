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
    /// PlaneTree
    /// </summary>
    [DataContract]
    public partial class PlaneTree : OneOfPorousTreeTreeType, IEquatable<PlaneTree>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTree" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlaneTree() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaneTree" /> class.
        /// </summary>
        /// <param name="type">Schema name: PlaneTree (required) (default to &quot;PLANE_TREE&quot;).</param>
        /// <param name="averageTreeHeight">averageTreeHeight.</param>
        public PlaneTree(string type = "PLANE_TREE", DimensionalLength averageTreeHeight = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PlaneTree and cannot be null");
            this.AverageTreeHeight = averageTreeHeight;
        }
        
        /// <summary>
        /// Schema name: PlaneTree
        /// </summary>
        /// <value>Schema name: PlaneTree</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AverageTreeHeight
        /// </summary>
        [DataMember(Name="averageTreeHeight", EmitDefaultValue=false)]
        public DimensionalLength AverageTreeHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlaneTree {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AverageTreeHeight: ").Append(AverageTreeHeight).Append("\n");
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
            return this.Equals(input as PlaneTree);
        }

        /// <summary>
        /// Returns true if PlaneTree instances are equal
        /// </summary>
        /// <param name="input">Instance of PlaneTree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlaneTree input)
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
                    this.AverageTreeHeight == input.AverageTreeHeight ||
                    (this.AverageTreeHeight != null &&
                    this.AverageTreeHeight.Equals(input.AverageTreeHeight))
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
                if (this.AverageTreeHeight != null)
                    hashCode = hashCode * 59 + this.AverageTreeHeight.GetHashCode();
                return hashCode;
            }
        }

    }

}
