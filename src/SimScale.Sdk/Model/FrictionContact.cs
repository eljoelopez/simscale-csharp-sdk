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
    /// FrictionContact
    /// </summary>
    [DataContract]
    public partial class FrictionContact : OneOfPhysicalContactConnections, IEquatable<FrictionContact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrictionContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrictionContact" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FRICTION_CONTACT&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="contactSolutionMethod">contactSolutionMethod.</param>
        /// <param name="frictionCoefficient">frictionCoefficient.</param>
        /// <param name="fictitiousClearance">fictitiousClearance.</param>
        /// <param name="masterTopologicalReference">masterTopologicalReference.</param>
        /// <param name="slaveTopologicalReference">slaveTopologicalReference.</param>
        public FrictionContact(string type = "FRICTION_CONTACT", string name = default(string), OneOfFrictionContactContactSolutionMethod contactSolutionMethod = default(OneOfFrictionContactContactSolutionMethod), OneOfFrictionContactFrictionCoefficient frictionCoefficient = default(OneOfFrictionContactFrictionCoefficient), OneOfFrictionContactFictitiousClearance fictitiousClearance = default(OneOfFrictionContactFictitiousClearance), TopologicalReference masterTopologicalReference = default(TopologicalReference), TopologicalReference slaveTopologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FrictionContact and cannot be null");
            this.Name = name;
            this.ContactSolutionMethod = contactSolutionMethod;
            this.FrictionCoefficient = frictionCoefficient;
            this.FictitiousClearance = fictitiousClearance;
            this.MasterTopologicalReference = masterTopologicalReference;
            this.SlaveTopologicalReference = slaveTopologicalReference;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ContactSolutionMethod
        /// </summary>
        [DataMember(Name="contactSolutionMethod", EmitDefaultValue=false)]
        public OneOfFrictionContactContactSolutionMethod ContactSolutionMethod { get; set; }

        /// <summary>
        /// Gets or Sets FrictionCoefficient
        /// </summary>
        [DataMember(Name="frictionCoefficient", EmitDefaultValue=false)]
        public OneOfFrictionContactFrictionCoefficient FrictionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets FictitiousClearance
        /// </summary>
        [DataMember(Name="fictitiousClearance", EmitDefaultValue=false)]
        public OneOfFrictionContactFictitiousClearance FictitiousClearance { get; set; }

        /// <summary>
        /// Gets or Sets MasterTopologicalReference
        /// </summary>
        [DataMember(Name="masterTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference MasterTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets SlaveTopologicalReference
        /// </summary>
        [DataMember(Name="slaveTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference SlaveTopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrictionContact {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactSolutionMethod: ").Append(ContactSolutionMethod).Append("\n");
            sb.Append("  FrictionCoefficient: ").Append(FrictionCoefficient).Append("\n");
            sb.Append("  FictitiousClearance: ").Append(FictitiousClearance).Append("\n");
            sb.Append("  MasterTopologicalReference: ").Append(MasterTopologicalReference).Append("\n");
            sb.Append("  SlaveTopologicalReference: ").Append(SlaveTopologicalReference).Append("\n");
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
            return this.Equals(input as FrictionContact);
        }

        /// <summary>
        /// Returns true if FrictionContact instances are equal
        /// </summary>
        /// <param name="input">Instance of FrictionContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FrictionContact input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactSolutionMethod == input.ContactSolutionMethod ||
                    (this.ContactSolutionMethod != null &&
                    this.ContactSolutionMethod.Equals(input.ContactSolutionMethod))
                ) && 
                (
                    this.FrictionCoefficient == input.FrictionCoefficient ||
                    (this.FrictionCoefficient != null &&
                    this.FrictionCoefficient.Equals(input.FrictionCoefficient))
                ) && 
                (
                    this.FictitiousClearance == input.FictitiousClearance ||
                    (this.FictitiousClearance != null &&
                    this.FictitiousClearance.Equals(input.FictitiousClearance))
                ) && 
                (
                    this.MasterTopologicalReference == input.MasterTopologicalReference ||
                    (this.MasterTopologicalReference != null &&
                    this.MasterTopologicalReference.Equals(input.MasterTopologicalReference))
                ) && 
                (
                    this.SlaveTopologicalReference == input.SlaveTopologicalReference ||
                    (this.SlaveTopologicalReference != null &&
                    this.SlaveTopologicalReference.Equals(input.SlaveTopologicalReference))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContactSolutionMethod != null)
                    hashCode = hashCode * 59 + this.ContactSolutionMethod.GetHashCode();
                if (this.FrictionCoefficient != null)
                    hashCode = hashCode * 59 + this.FrictionCoefficient.GetHashCode();
                if (this.FictitiousClearance != null)
                    hashCode = hashCode * 59 + this.FictitiousClearance.GetHashCode();
                if (this.MasterTopologicalReference != null)
                    hashCode = hashCode * 59 + this.MasterTopologicalReference.GetHashCode();
                if (this.SlaveTopologicalReference != null)
                    hashCode = hashCode * 59 + this.SlaveTopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
