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
    /// TableImportRequest
    /// </summary>
    [DataContract]
    public partial class TableImportRequest : IEquatable<TableImportRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TableImportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportRequest" /> class.
        /// </summary>
        /// <param name="location">location (required).</param>
        public TableImportRequest(TableImportRequestLocation location = default(TableImportRequestLocation))
        {
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for TableImportRequest and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public TableImportRequestLocation Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableImportRequest {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as TableImportRequest);
        }

        /// <summary>
        /// Returns true if TableImportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TableImportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableImportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }

    }

}
