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
    /// SolidSimulationControl
    /// </summary>
    [DataContract]
    public partial class SolidSimulationControl : IEquatable<SolidSimulationControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidSimulationControl" /> class.
        /// </summary>
        /// <param name="timestepDefinition">timestepDefinition.</param>
        /// <param name="pseudoTimeStepping">pseudoTimeStepping.</param>
        /// <param name="writeControlDefinition">writeControlDefinition.</param>
        /// <param name="excitationFrequencies">excitationFrequencies.</param>
        /// <param name="eigenfrequencyScope">eigenfrequencyScope.</param>
        /// <param name="processors">processors.</param>
        /// <param name="maxRunTime">maxRunTime.</param>
        public SolidSimulationControl(OneOfSolidSimulationControlTimestepDefinition timestepDefinition = default(OneOfSolidSimulationControlTimestepDefinition), OneOfSolidSimulationControlPseudoTimeStepping pseudoTimeStepping = default(OneOfSolidSimulationControlPseudoTimeStepping), OneOfSolidSimulationControlWriteControlDefinition writeControlDefinition = default(OneOfSolidSimulationControlWriteControlDefinition), OneOfSolidSimulationControlExcitationFrequencies excitationFrequencies = default(OneOfSolidSimulationControlExcitationFrequencies), OneOfSolidSimulationControlEigenfrequencyScope eigenfrequencyScope = default(OneOfSolidSimulationControlEigenfrequencyScope), ComputingCore processors = default(ComputingCore), DimensionalTime maxRunTime = default(DimensionalTime))
        {
            this.TimestepDefinition = timestepDefinition;
            this.PseudoTimeStepping = pseudoTimeStepping;
            this.WriteControlDefinition = writeControlDefinition;
            this.ExcitationFrequencies = excitationFrequencies;
            this.EigenfrequencyScope = eigenfrequencyScope;
            this.Processors = processors;
            this.MaxRunTime = maxRunTime;
        }
        
        /// <summary>
        /// Gets or Sets TimestepDefinition
        /// </summary>
        [DataMember(Name="timestepDefinition", EmitDefaultValue=false)]
        public OneOfSolidSimulationControlTimestepDefinition TimestepDefinition { get; set; }

        /// <summary>
        /// Gets or Sets PseudoTimeStepping
        /// </summary>
        [DataMember(Name="pseudoTimeStepping", EmitDefaultValue=false)]
        public OneOfSolidSimulationControlPseudoTimeStepping PseudoTimeStepping { get; set; }

        /// <summary>
        /// Gets or Sets WriteControlDefinition
        /// </summary>
        [DataMember(Name="writeControlDefinition", EmitDefaultValue=false)]
        public OneOfSolidSimulationControlWriteControlDefinition WriteControlDefinition { get; set; }

        /// <summary>
        /// Gets or Sets ExcitationFrequencies
        /// </summary>
        [DataMember(Name="excitationFrequencies", EmitDefaultValue=false)]
        public OneOfSolidSimulationControlExcitationFrequencies ExcitationFrequencies { get; set; }

        /// <summary>
        /// Gets or Sets EigenfrequencyScope
        /// </summary>
        [DataMember(Name="eigenfrequencyScope", EmitDefaultValue=false)]
        public OneOfSolidSimulationControlEigenfrequencyScope EigenfrequencyScope { get; set; }

        /// <summary>
        /// Gets or Sets Processors
        /// </summary>
        [DataMember(Name="processors", EmitDefaultValue=false)]
        public ComputingCore Processors { get; set; }

        /// <summary>
        /// Gets or Sets MaxRunTime
        /// </summary>
        [DataMember(Name="maxRunTime", EmitDefaultValue=false)]
        public DimensionalTime MaxRunTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolidSimulationControl {\n");
            sb.Append("  TimestepDefinition: ").Append(TimestepDefinition).Append("\n");
            sb.Append("  PseudoTimeStepping: ").Append(PseudoTimeStepping).Append("\n");
            sb.Append("  WriteControlDefinition: ").Append(WriteControlDefinition).Append("\n");
            sb.Append("  ExcitationFrequencies: ").Append(ExcitationFrequencies).Append("\n");
            sb.Append("  EigenfrequencyScope: ").Append(EigenfrequencyScope).Append("\n");
            sb.Append("  Processors: ").Append(Processors).Append("\n");
            sb.Append("  MaxRunTime: ").Append(MaxRunTime).Append("\n");
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
            return this.Equals(input as SolidSimulationControl);
        }

        /// <summary>
        /// Returns true if SolidSimulationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of SolidSimulationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolidSimulationControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimestepDefinition == input.TimestepDefinition ||
                    (this.TimestepDefinition != null &&
                    this.TimestepDefinition.Equals(input.TimestepDefinition))
                ) && 
                (
                    this.PseudoTimeStepping == input.PseudoTimeStepping ||
                    (this.PseudoTimeStepping != null &&
                    this.PseudoTimeStepping.Equals(input.PseudoTimeStepping))
                ) && 
                (
                    this.WriteControlDefinition == input.WriteControlDefinition ||
                    (this.WriteControlDefinition != null &&
                    this.WriteControlDefinition.Equals(input.WriteControlDefinition))
                ) && 
                (
                    this.ExcitationFrequencies == input.ExcitationFrequencies ||
                    (this.ExcitationFrequencies != null &&
                    this.ExcitationFrequencies.Equals(input.ExcitationFrequencies))
                ) && 
                (
                    this.EigenfrequencyScope == input.EigenfrequencyScope ||
                    (this.EigenfrequencyScope != null &&
                    this.EigenfrequencyScope.Equals(input.EigenfrequencyScope))
                ) && 
                (
                    this.Processors == input.Processors ||
                    (this.Processors != null &&
                    this.Processors.Equals(input.Processors))
                ) && 
                (
                    this.MaxRunTime == input.MaxRunTime ||
                    (this.MaxRunTime != null &&
                    this.MaxRunTime.Equals(input.MaxRunTime))
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
                if (this.TimestepDefinition != null)
                    hashCode = hashCode * 59 + this.TimestepDefinition.GetHashCode();
                if (this.PseudoTimeStepping != null)
                    hashCode = hashCode * 59 + this.PseudoTimeStepping.GetHashCode();
                if (this.WriteControlDefinition != null)
                    hashCode = hashCode * 59 + this.WriteControlDefinition.GetHashCode();
                if (this.ExcitationFrequencies != null)
                    hashCode = hashCode * 59 + this.ExcitationFrequencies.GetHashCode();
                if (this.EigenfrequencyScope != null)
                    hashCode = hashCode * 59 + this.EigenfrequencyScope.GetHashCode();
                if (this.Processors != null)
                    hashCode = hashCode * 59 + this.Processors.GetHashCode();
                if (this.MaxRunTime != null)
                    hashCode = hashCode * 59 + this.MaxRunTime.GetHashCode();
                return hashCode;
            }
        }

    }

}
