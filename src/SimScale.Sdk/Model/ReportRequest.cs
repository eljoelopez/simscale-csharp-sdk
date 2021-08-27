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
    /// ReportRequest
    /// </summary>
    [DataContract]
    public partial class ReportRequest : IEquatable<ReportRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="resultIds">resultIds (required).</param>
        /// <param name="reportId">reportId.</param>
        /// <param name="reportProperties">Note: This object is replaced at runtime with the actual report model schema which is fetched from reporting service.  (required).</param>
        public ReportRequest(string name = default(string), string description = default(string), List<Guid?> resultIds = default(List<Guid?>), Guid? reportId = default(Guid?), Object reportProperties = default(Object))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for ReportRequest and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for ReportRequest and cannot be null");
            // to ensure "resultIds" is required (not null)
            this.ResultIds = resultIds ?? throw new ArgumentNullException("resultIds is a required property for ReportRequest and cannot be null");
            // to ensure "reportProperties" is required (not null)
            this.ReportProperties = reportProperties ?? throw new ArgumentNullException("reportProperties is a required property for ReportRequest and cannot be null");
            this.ReportId = reportId;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ResultIds
        /// </summary>
        [DataMember(Name="resultIds", EmitDefaultValue=false)]
        public List<Guid?> ResultIds { get; set; }

        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public Guid? ReportId { get; set; }

        /// <summary>
        /// Note: This object is replaced at runtime with the actual report model schema which is fetched from reporting service. 
        /// </summary>
        /// <value>Note: This object is replaced at runtime with the actual report model schema which is fetched from reporting service. </value>
        [DataMember(Name="reportProperties", EmitDefaultValue=false)]
        public Object ReportProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ResultIds: ").Append(ResultIds).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  ReportProperties: ").Append(ReportProperties).Append("\n");
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
            return this.Equals(input as ReportRequest);
        }

        /// <summary>
        /// Returns true if ReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ResultIds == input.ResultIds ||
                    this.ResultIds != null &&
                    input.ResultIds != null &&
                    this.ResultIds.SequenceEqual(input.ResultIds)
                ) && 
                (
                    this.ReportId == input.ReportId ||
                    (this.ReportId != null &&
                    this.ReportId.Equals(input.ReportId))
                ) && 
                (
                    this.ReportProperties == input.ReportProperties ||
                    (this.ReportProperties != null &&
                    this.ReportProperties.Equals(input.ReportProperties))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ResultIds != null)
                    hashCode = hashCode * 59 + this.ResultIds.GetHashCode();
                if (this.ReportId != null)
                    hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.ReportProperties != null)
                    hashCode = hashCode * 59 + this.ReportProperties.GetHashCode();
                return hashCode;
            }
        }

    }

}
