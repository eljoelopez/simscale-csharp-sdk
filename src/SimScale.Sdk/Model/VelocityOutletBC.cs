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
    /// &lt;br&gt;This boundary condition imposes a known flow rate or velocity at an outlet.&lt;p&gt;The sub-types for a &lt;b&gt;Velocity Outlet&lt;/b&gt; boundary are as follows:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;Fixed value:&lt;/b&gt; defines a constant or time/space dependent velocity values. The flow direction is based on input values.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Mean value:&lt;/b&gt; defines a mean or time/space dependent velocity values across the surface(s) selected. The flow direction is based on input values.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Free stream:&lt;/b&gt; defines a Inflow/Outflow condition at boundaries far away from the object. The flow direction is based on input values.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Flow rate:&lt;/b&gt; defines a target flow rate. &lt;b&gt;Flow rate value must be positive.&lt;/b&gt;&lt;/li&gt;&lt;li&gt;&lt;b&gt;Face normal value:&lt;/b&gt; defines a target face normal mean outlet velocity. &lt;b&gt;Velocity value must be positive.&lt;/b&gt;&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class VelocityOutletBC : OneOfCompressibleBoundaryConditions, OneOfConjugateHeatTransferBoundaryConditions, OneOfConvectiveHeatTransferBoundaryConditions, OneOfIncompressibleBoundaryConditions, OneOfMultiphaseBoundaryConditions, OneOfSimericsAnalysisBoundaryConditions, IEquatable<VelocityOutletBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VelocityOutletBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VelocityOutletBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VelocityOutletBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;VELOCITY_OUTLET_V7&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="velocity">velocity.</param>
        /// <param name="phaseFraction">phaseFraction.</param>
        /// <param name="netRadiativeHeatFlux">netRadiativeHeatFlux.</param>
        /// <param name="radiativeIntensityRay">radiativeIntensityRay.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public VelocityOutletBC(string type = "VELOCITY_OUTLET_V7", string name = default(string), OneOfVelocityOutletBCVelocity velocity = default(OneOfVelocityOutletBCVelocity), OneOfVelocityOutletBCPhaseFraction phaseFraction = default(OneOfVelocityOutletBCPhaseFraction), OneOfVelocityOutletBCNetRadiativeHeatFlux netRadiativeHeatFlux = default(OneOfVelocityOutletBCNetRadiativeHeatFlux), OneOfVelocityOutletBCRadiativeIntensityRay radiativeIntensityRay = default(OneOfVelocityOutletBCRadiativeIntensityRay), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for VelocityOutletBC and cannot be null");
            this.Name = name;
            this.Velocity = velocity;
            this.PhaseFraction = phaseFraction;
            this.NetRadiativeHeatFlux = netRadiativeHeatFlux;
            this.RadiativeIntensityRay = radiativeIntensityRay;
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
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name="velocity", EmitDefaultValue=false)]
        public OneOfVelocityOutletBCVelocity Velocity { get; set; }

        /// <summary>
        /// Gets or Sets PhaseFraction
        /// </summary>
        [DataMember(Name="phaseFraction", EmitDefaultValue=false)]
        public OneOfVelocityOutletBCPhaseFraction PhaseFraction { get; set; }

        /// <summary>
        /// Gets or Sets NetRadiativeHeatFlux
        /// </summary>
        [DataMember(Name="netRadiativeHeatFlux", EmitDefaultValue=false)]
        public OneOfVelocityOutletBCNetRadiativeHeatFlux NetRadiativeHeatFlux { get; set; }

        /// <summary>
        /// Gets or Sets RadiativeIntensityRay
        /// </summary>
        [DataMember(Name="radiativeIntensityRay", EmitDefaultValue=false)]
        public OneOfVelocityOutletBCRadiativeIntensityRay RadiativeIntensityRay { get; set; }

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
            sb.Append("class VelocityOutletBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  PhaseFraction: ").Append(PhaseFraction).Append("\n");
            sb.Append("  NetRadiativeHeatFlux: ").Append(NetRadiativeHeatFlux).Append("\n");
            sb.Append("  RadiativeIntensityRay: ").Append(RadiativeIntensityRay).Append("\n");
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
            return this.Equals(input as VelocityOutletBC);
        }

        /// <summary>
        /// Returns true if VelocityOutletBC instances are equal
        /// </summary>
        /// <param name="input">Instance of VelocityOutletBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VelocityOutletBC input)
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
                    this.Velocity == input.Velocity ||
                    (this.Velocity != null &&
                    this.Velocity.Equals(input.Velocity))
                ) && 
                (
                    this.PhaseFraction == input.PhaseFraction ||
                    (this.PhaseFraction != null &&
                    this.PhaseFraction.Equals(input.PhaseFraction))
                ) && 
                (
                    this.NetRadiativeHeatFlux == input.NetRadiativeHeatFlux ||
                    (this.NetRadiativeHeatFlux != null &&
                    this.NetRadiativeHeatFlux.Equals(input.NetRadiativeHeatFlux))
                ) && 
                (
                    this.RadiativeIntensityRay == input.RadiativeIntensityRay ||
                    (this.RadiativeIntensityRay != null &&
                    this.RadiativeIntensityRay.Equals(input.RadiativeIntensityRay))
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
                if (this.Velocity != null)
                    hashCode = hashCode * 59 + this.Velocity.GetHashCode();
                if (this.PhaseFraction != null)
                    hashCode = hashCode * 59 + this.PhaseFraction.GetHashCode();
                if (this.NetRadiativeHeatFlux != null)
                    hashCode = hashCode * 59 + this.NetRadiativeHeatFlux.GetHashCode();
                if (this.RadiativeIntensityRay != null)
                    hashCode = hashCode * 59 + this.RadiativeIntensityRay.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
