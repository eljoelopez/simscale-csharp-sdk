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
    /// TableImportRequestLocation
    /// </summary>
    [DataContract]
    public partial class TableImportRequestLocation : IEquatable<TableImportRequestLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportRequestLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TableImportRequestLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableImportRequestLocation" /> class.
        /// </summary>
        /// <param name="storageId">The storage ID of the temporary storage location where the table has been uploaded. (required).</param>
        public TableImportRequestLocation(string storageId = default(string))
        {
            // to ensure "storageId" is required (not null)
            this.StorageId = storageId ?? throw new ArgumentNullException("storageId is a required property for TableImportRequestLocation and cannot be null");
        }
        
        /// <summary>
        /// The storage ID of the temporary storage location where the table has been uploaded.
        /// </summary>
        /// <value>The storage ID of the temporary storage location where the table has been uploaded.</value>
        [DataMember(Name="storageId", EmitDefaultValue=false)]
        public string StorageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableImportRequestLocation {\n");
            sb.Append("  StorageId: ").Append(StorageId).Append("\n");
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
            return this.Equals(input as TableImportRequestLocation);
        }

        /// <summary>
        /// Returns true if TableImportRequestLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of TableImportRequestLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableImportRequestLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageId == input.StorageId ||
                    (this.StorageId != null &&
                    this.StorageId.Equals(input.StorageId))
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
                if (this.StorageId != null)
                    hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                return hashCode;
            }
        }

    }

}
