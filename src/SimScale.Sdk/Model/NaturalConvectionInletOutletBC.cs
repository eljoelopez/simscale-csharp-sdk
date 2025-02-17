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
    /// &lt;p&gt;This boundary condition is suitable for an &lt;b&gt;open boundary&lt;/b&gt; where the air can enter or exit freely from or to the &lt;b&gt;atmosphere&lt;b&gt;. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/natural-convection-inlet-outlet/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/P&gt;
    /// </summary>
    [DataContract]
    public partial class NaturalConvectionInletOutletBC : OneOfConjugateHeatTransferBoundaryConditions, OneOfConvectiveHeatTransferBoundaryConditions, OneOfCoupledConjugateHeatTransferBoundaryConditions, IEquatable<NaturalConvectionInletOutletBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalConvectionInletOutletBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NaturalConvectionInletOutletBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalConvectionInletOutletBC" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;This boundary condition is suitable for an &lt;b&gt;open boundary&lt;/b&gt; where the air can enter or exit freely from or to the &lt;b&gt;atmosphere&lt;b&gt;. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/natural-convection-inlet-outlet/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/P&gt;  Schema name: NaturalConvectionInletOutletBC (required) (default to &quot;NATURAL_CONVECTION_INLET_OUTLET&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="pressureRgh">pressureRgh.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="netRadiativeHeatFlux">netRadiativeHeatFlux.</param>
        /// <param name="radiativeIntensityRay">radiativeIntensityRay.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public NaturalConvectionInletOutletBC(string type = "NATURAL_CONVECTION_INLET_OUTLET", string name = default(string), AmbientPBC pressureRgh = default(AmbientPBC), AmbientTBC temperature = default(AmbientTBC), OneOfNaturalConvectionInletOutletBCNetRadiativeHeatFlux netRadiativeHeatFlux = default(OneOfNaturalConvectionInletOutletBCNetRadiativeHeatFlux), OpenBoundaryRayBC radiativeIntensityRay = default(OpenBoundaryRayBC), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NaturalConvectionInletOutletBC and cannot be null");
            this.Name = name;
            this.PressureRgh = pressureRgh;
            this.Temperature = temperature;
            this.NetRadiativeHeatFlux = netRadiativeHeatFlux;
            this.RadiativeIntensityRay = radiativeIntensityRay;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// &lt;p&gt;This boundary condition is suitable for an &lt;b&gt;open boundary&lt;/b&gt; where the air can enter or exit freely from or to the &lt;b&gt;atmosphere&lt;b&gt;. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/natural-convection-inlet-outlet/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/P&gt;  Schema name: NaturalConvectionInletOutletBC
        /// </summary>
        /// <value>&lt;p&gt;This boundary condition is suitable for an &lt;b&gt;open boundary&lt;/b&gt; where the air can enter or exit freely from or to the &lt;b&gt;atmosphere&lt;b&gt;. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/natural-convection-inlet-outlet/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/P&gt;  Schema name: NaturalConvectionInletOutletBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PressureRgh
        /// </summary>
        [DataMember(Name="pressureRgh", EmitDefaultValue=false)]
        public AmbientPBC PressureRgh { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public AmbientTBC Temperature { get; set; }

        /// <summary>
        /// Gets or Sets NetRadiativeHeatFlux
        /// </summary>
        [DataMember(Name="netRadiativeHeatFlux", EmitDefaultValue=false)]
        public OneOfNaturalConvectionInletOutletBCNetRadiativeHeatFlux NetRadiativeHeatFlux { get; set; }

        /// <summary>
        /// Gets or Sets RadiativeIntensityRay
        /// </summary>
        [DataMember(Name="radiativeIntensityRay", EmitDefaultValue=false)]
        public OpenBoundaryRayBC RadiativeIntensityRay { get; set; }

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
            sb.Append("class NaturalConvectionInletOutletBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PressureRgh: ").Append(PressureRgh).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
            return this.Equals(input as NaturalConvectionInletOutletBC);
        }

        /// <summary>
        /// Returns true if NaturalConvectionInletOutletBC instances are equal
        /// </summary>
        /// <param name="input">Instance of NaturalConvectionInletOutletBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaturalConvectionInletOutletBC input)
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
                    this.PressureRgh == input.PressureRgh ||
                    (this.PressureRgh != null &&
                    this.PressureRgh.Equals(input.PressureRgh))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
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
                if (this.PressureRgh != null)
                    hashCode = hashCode * 59 + this.PressureRgh.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
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
