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
    /// OriginalEntityReference
    /// </summary>
    [DataContract]
    public partial class OriginalEntityReference : IEquatable<OriginalEntityReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginalEntityReference" /> class.
        /// </summary>
        /// <param name="path">The path from the root of the model..</param>
        /// <param name="body">The original body name..</param>
        /// <param name="entity">The original entity name..</param>
        /// <param name="attributeList">The attributes assigned to the entity..</param>
        public OriginalEntityReference(List<BodyPath> path = default(List<BodyPath>), string body = default(string), string entity = default(string), List<EntityAttribute> attributeList = default(List<EntityAttribute>))
        {
            this.Path = path;
            this.Body = body;
            this.Entity = entity;
            this.AttributeList = attributeList;
        }
        
        /// <summary>
        /// The path from the root of the model.
        /// </summary>
        /// <value>The path from the root of the model.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public List<BodyPath> Path { get; set; }

        /// <summary>
        /// The original body name.
        /// </summary>
        /// <value>The original body name.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// The original entity name.
        /// </summary>
        /// <value>The original entity name.</value>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public string Entity { get; set; }

        /// <summary>
        /// The attributes assigned to the entity.
        /// </summary>
        /// <value>The attributes assigned to the entity.</value>
        [DataMember(Name="attributeList", EmitDefaultValue=false)]
        public List<EntityAttribute> AttributeList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginalEntityReference {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  AttributeList: ").Append(AttributeList).Append("\n");
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
            return this.Equals(input as OriginalEntityReference);
        }

        /// <summary>
        /// Returns true if OriginalEntityReference instances are equal
        /// </summary>
        /// <param name="input">Instance of OriginalEntityReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OriginalEntityReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    this.Path != null &&
                    input.Path != null &&
                    this.Path.SequenceEqual(input.Path)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.AttributeList == input.AttributeList ||
                    this.AttributeList != null &&
                    input.AttributeList != null &&
                    this.AttributeList.SequenceEqual(input.AttributeList)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.AttributeList != null)
                    hashCode = hashCode * 59 + this.AttributeList.GetHashCode();
                return hashCode;
            }
        }

    }

}
