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
    /// &lt;p&gt;This boundary provides several Solid Wall conditions.&lt;/P&gt;The default &lt;b&gt;no-slip&lt;/b&gt; corresponds to friction wall with no movement. The &lt;b&gt;slip wall&lt;/b&gt; models a surface with no friction. The &lt;b&gt;rotating wall&lt;/b&gt; and &lt;b&gt;moving wall&lt;/b&gt; models rotation and translation by prescribing velocities at the wall. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/wall/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class WallBC : OneOfCompressibleBoundaryConditions, OneOfConjugateHeatTransferBoundaryConditions, OneOfConvectiveHeatTransferBoundaryConditions, OneOfCoupledConjugateHeatTransferBoundaryConditions, OneOfFlowDomainBoundariesXMAX, OneOfFlowDomainBoundariesXMIN, OneOfFlowDomainBoundariesYMAX, OneOfFlowDomainBoundariesYMIN, OneOfFlowDomainBoundariesZMAX, OneOfFlowDomainBoundariesZMIN, OneOfIncompressibleBoundaryConditions, OneOfMultiphaseBoundaryConditions, OneOfSimericsAnalysisBoundaryConditions, IEquatable<WallBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WallBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WallBC" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;This boundary provides several Solid Wall conditions.&lt;/P&gt;The default &lt;b&gt;no-slip&lt;/b&gt; corresponds to friction wall with no movement. The &lt;b&gt;slip wall&lt;/b&gt; models a surface with no friction. The &lt;b&gt;rotating wall&lt;/b&gt; and &lt;b&gt;moving wall&lt;/b&gt; models rotation and translation by prescribing velocities at the wall. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/wall/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: WallBC (required) (default to &quot;WALL_V34&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="velocity">velocity.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="phaseFraction">phaseFraction.</param>
        /// <param name="netRadiativeHeatFlux">netRadiativeHeatFlux.</param>
        /// <param name="radiativeIntensityRay">radiativeIntensityRay.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public WallBC(string type = "WALL_V34", string name = default(string), OneOfWallBCVelocity velocity = default(OneOfWallBCVelocity), OneOfWallBCTemperature temperature = default(OneOfWallBCTemperature), OneOfWallBCPhaseFraction phaseFraction = default(OneOfWallBCPhaseFraction), OneOfWallBCNetRadiativeHeatFlux netRadiativeHeatFlux = default(OneOfWallBCNetRadiativeHeatFlux), OneOfWallBCRadiativeIntensityRay radiativeIntensityRay = default(OneOfWallBCRadiativeIntensityRay), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for WallBC and cannot be null");
            this.Name = name;
            this.Velocity = velocity;
            this.Temperature = temperature;
            this.PhaseFraction = phaseFraction;
            this.NetRadiativeHeatFlux = netRadiativeHeatFlux;
            this.RadiativeIntensityRay = radiativeIntensityRay;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// &lt;p&gt;This boundary provides several Solid Wall conditions.&lt;/P&gt;The default &lt;b&gt;no-slip&lt;/b&gt; corresponds to friction wall with no movement. The &lt;b&gt;slip wall&lt;/b&gt; models a surface with no friction. The &lt;b&gt;rotating wall&lt;/b&gt; and &lt;b&gt;moving wall&lt;/b&gt; models rotation and translation by prescribing velocities at the wall. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/wall/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: WallBC
        /// </summary>
        /// <value>&lt;p&gt;This boundary provides several Solid Wall conditions.&lt;/P&gt;The default &lt;b&gt;no-slip&lt;/b&gt; corresponds to friction wall with no movement. The &lt;b&gt;slip wall&lt;/b&gt; models a surface with no friction. The &lt;b&gt;rotating wall&lt;/b&gt; and &lt;b&gt;moving wall&lt;/b&gt; models rotation and translation by prescribing velocities at the wall. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/wall/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: WallBC</value>
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
        public OneOfWallBCVelocity Velocity { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public OneOfWallBCTemperature Temperature { get; set; }

        /// <summary>
        /// Gets or Sets PhaseFraction
        /// </summary>
        [DataMember(Name="phaseFraction", EmitDefaultValue=false)]
        public OneOfWallBCPhaseFraction PhaseFraction { get; set; }

        /// <summary>
        /// Gets or Sets NetRadiativeHeatFlux
        /// </summary>
        [DataMember(Name="netRadiativeHeatFlux", EmitDefaultValue=false)]
        public OneOfWallBCNetRadiativeHeatFlux NetRadiativeHeatFlux { get; set; }

        /// <summary>
        /// Gets or Sets RadiativeIntensityRay
        /// </summary>
        [DataMember(Name="radiativeIntensityRay", EmitDefaultValue=false)]
        public OneOfWallBCRadiativeIntensityRay RadiativeIntensityRay { get; set; }

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
            sb.Append("class WallBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
            return this.Equals(input as WallBC);
        }

        /// <summary>
        /// Returns true if WallBC instances are equal
        /// </summary>
        /// <param name="input">Instance of WallBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WallBC input)
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
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
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
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
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
