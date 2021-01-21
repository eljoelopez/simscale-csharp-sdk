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
    /// SubdomainStressInitialCondition
    /// </summary>
    [DataContract]
    public partial class SubdomainStressInitialCondition : IEquatable<SubdomainStressInitialCondition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubdomainStressInitialCondition" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="subdomainValue">subdomainValue.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public SubdomainStressInitialCondition(string name = default(string), StressTensorPressure subdomainValue = default(StressTensorPressure), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            this.Name = name;
            this.SubdomainValue = subdomainValue;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SubdomainValue
        /// </summary>
        [DataMember(Name="subdomainValue", EmitDefaultValue=false)]
        public StressTensorPressure SubdomainValue { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubdomainStressInitialCondition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubdomainValue: ").Append(SubdomainValue).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as SubdomainStressInitialCondition);
        }

        /// <summary>
        /// Returns true if SubdomainStressInitialCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of SubdomainStressInitialCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubdomainStressInitialCondition input)
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
                    this.SubdomainValue == input.SubdomainValue ||
                    (this.SubdomainValue != null &&
                    this.SubdomainValue.Equals(input.SubdomainValue))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.SubdomainValue != null)
                    hashCode = hashCode * 59 + this.SubdomainValue.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
