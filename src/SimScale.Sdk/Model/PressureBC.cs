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
    /// This is a &lt;b&gt;pressure&lt;/b&gt; boundary condition representing a distributed load on the selection. It is applied normal to the surface of all face elements in the deformed configuration.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;The applied total force depends on the surface area of the selection&lt;/li&gt;&lt;li&gt;This is a nonlinear boundary condition as the update of the geometry is only possible for nonlinear analyses. In a linear analysis it becomes a simple &lt;b&gt;pressure&lt;/b&gt; boundary condition&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class PressureBC : OneOfDynamicAnalysisBoundaryConditions, OneOfHarmonicAnalysisBoundaryConditions, OneOfStaticAnalysisBoundaryConditions, OneOfThermalMechanicalBoundaryConditions, IEquatable<PressureBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PressureBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;PRESSURE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="pressure">pressure.</param>
        /// <param name="phaseAngle">phaseAngle.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public PressureBC(string type = "PRESSURE", string name = default(string), DimensionalFunctionPressure pressure = default(DimensionalFunctionPressure), DimensionalAngle phaseAngle = default(DimensionalAngle), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PressureBC and cannot be null");
            this.Name = name;
            this.Pressure = pressure;
            this.PhaseAngle = phaseAngle;
            this.TopologicalReference = topologicalReference;
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
        /// Gets or Sets Pressure
        /// </summary>
        [DataMember(Name="pressure", EmitDefaultValue=false)]
        public DimensionalFunctionPressure Pressure { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAngle
        /// </summary>
        [DataMember(Name="phaseAngle", EmitDefaultValue=false)]
        public DimensionalAngle PhaseAngle { get; set; }

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
            sb.Append("class PressureBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  PhaseAngle: ").Append(PhaseAngle).Append("\n");
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
            return this.Equals(input as PressureBC);
        }

        /// <summary>
        /// Returns true if PressureBC instances are equal
        /// </summary>
        /// <param name="input">Instance of PressureBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PressureBC input)
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
                    this.Pressure == input.Pressure ||
                    (this.Pressure != null &&
                    this.Pressure.Equals(input.Pressure))
                ) && 
                (
                    this.PhaseAngle == input.PhaseAngle ||
                    (this.PhaseAngle != null &&
                    this.PhaseAngle.Equals(input.PhaseAngle))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pressure != null)
                    hashCode = hashCode * 59 + this.Pressure.GetHashCode();
                if (this.PhaseAngle != null)
                    hashCode = hashCode * 59 + this.PhaseAngle.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
