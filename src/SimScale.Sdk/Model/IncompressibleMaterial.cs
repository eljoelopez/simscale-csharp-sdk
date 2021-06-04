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
    /// IncompressibleMaterial
    /// </summary>
    [DataContract]
    public partial class IncompressibleMaterial : OneOfConvectiveHeatTransferMaterialsFluids, OneOfCoupledConjugateHeatTransferMaterialsFluids, OneOfSimericsFluidMaterialsFluids, IEquatable<IncompressibleMaterial>
    {
        /// <summary>
        /// &lt;p&gt;Select the corresponding phase for this material:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 0&lt;/b&gt; would mean this material is represented by the phase fraction value of 0. Hence, a phase fraction of &#39;0&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 1&lt;/b&gt; would mean this material is represented by the phase fraction value of 1. Hence, a phase fraction of &#39;1&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Select the corresponding phase for this material:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 0&lt;/b&gt; would mean this material is represented by the phase fraction value of 0. Hence, a phase fraction of &#39;0&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 1&lt;/b&gt; would mean this material is represented by the phase fraction value of 1. Hence, a phase fraction of &#39;1&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssociatedPhaseEnum
        {
            /// <summary>
            /// Enum _0 for value: PHASE_0
            /// </summary>
            [EnumMember(Value = "PHASE_0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: PHASE_1
            /// </summary>
            [EnumMember(Value = "PHASE_1")]
            _1 = 2

        }

        /// <summary>
        /// &lt;p&gt;Select the corresponding phase for this material:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 0&lt;/b&gt; would mean this material is represented by the phase fraction value of 0. Hence, a phase fraction of &#39;0&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 1&lt;/b&gt; would mean this material is represented by the phase fraction value of 1. Hence, a phase fraction of &#39;1&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Select the corresponding phase for this material:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 0&lt;/b&gt; would mean this material is represented by the phase fraction value of 0. Hence, a phase fraction of &#39;0&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 1&lt;/b&gt; would mean this material is represented by the phase fraction value of 1. Hence, a phase fraction of &#39;1&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;</value>
        [DataMember(Name="associatedPhase", EmitDefaultValue=false)]
        public AssociatedPhaseEnum? AssociatedPhase { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompressibleMaterial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncompressibleMaterial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompressibleMaterial" /> class.
        /// </summary>
        /// <param name="type">Schema name: IncompressibleMaterial (required) (default to &quot;INCOMPRESSIBLE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="associatedPhase">&lt;p&gt;Select the corresponding phase for this material:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 0&lt;/b&gt; would mean this material is represented by the phase fraction value of 0. Hence, a phase fraction of &#39;0&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Phase 1&lt;/b&gt; would mean this material is represented by the phase fraction value of 1. Hence, a phase fraction of &#39;1&#39; in your setup corresponds to 100% of this fluid material.&lt;/p&gt; (default to AssociatedPhaseEnum._1).</param>
        /// <param name="viscosityModel">viscosityModel.</param>
        /// <param name="density">density.</param>
        /// <param name="thermalExpansionCoefficient">thermalExpansionCoefficient.</param>
        /// <param name="referenceTemperature">referenceTemperature.</param>
        /// <param name="laminarPrandtlNumber">Laminar Prandtl number is used to calculate the heat transfer in the domain..</param>
        /// <param name="turbulentPrandtlNumber">Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain..</param>
        /// <param name="specificHeat">specificHeat.</param>
        /// <param name="molarWeight">molarWeight.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        /// <param name="builtInMaterial">builtInMaterial.</param>
        public IncompressibleMaterial(string type = "INCOMPRESSIBLE", string name = default(string), AssociatedPhaseEnum? associatedPhase = default(AssociatedPhaseEnum?), OneOfIncompressibleMaterialViscosityModel viscosityModel = default(OneOfIncompressibleMaterialViscosityModel), DimensionalDensity density = default(DimensionalDensity), DimensionalThermalExpansionRate thermalExpansionCoefficient = default(DimensionalThermalExpansionRate), DimensionalTemperature referenceTemperature = default(DimensionalTemperature), decimal? laminarPrandtlNumber = default(decimal?), decimal? turbulentPrandtlNumber = default(decimal?), DimensionalSpecificHeat specificHeat = default(DimensionalSpecificHeat), DimensionalMolarMass molarWeight = default(DimensionalMolarMass), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>), string builtInMaterial = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IncompressibleMaterial and cannot be null");
            this.Name = name;
            this.AssociatedPhase = associatedPhase;
            this.ViscosityModel = viscosityModel;
            this.Density = density;
            this.ThermalExpansionCoefficient = thermalExpansionCoefficient;
            this.ReferenceTemperature = referenceTemperature;
            this.LaminarPrandtlNumber = laminarPrandtlNumber;
            this.TurbulentPrandtlNumber = turbulentPrandtlNumber;
            this.SpecificHeat = specificHeat;
            this.MolarWeight = molarWeight;
            this.TopologicalReference = topologicalReference;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
            this.BuiltInMaterial = builtInMaterial;
        }
        
        /// <summary>
        /// Schema name: IncompressibleMaterial
        /// </summary>
        /// <value>Schema name: IncompressibleMaterial</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ViscosityModel
        /// </summary>
        [DataMember(Name="viscosityModel", EmitDefaultValue=false)]
        public OneOfIncompressibleMaterialViscosityModel ViscosityModel { get; set; }

        /// <summary>
        /// Gets or Sets Density
        /// </summary>
        [DataMember(Name="density", EmitDefaultValue=false)]
        public DimensionalDensity Density { get; set; }

        /// <summary>
        /// Gets or Sets ThermalExpansionCoefficient
        /// </summary>
        [DataMember(Name="thermalExpansionCoefficient", EmitDefaultValue=false)]
        public DimensionalThermalExpansionRate ThermalExpansionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceTemperature
        /// </summary>
        [DataMember(Name="referenceTemperature", EmitDefaultValue=false)]
        public DimensionalTemperature ReferenceTemperature { get; set; }

        /// <summary>
        /// Laminar Prandtl number is used to calculate the heat transfer in the domain.
        /// </summary>
        /// <value>Laminar Prandtl number is used to calculate the heat transfer in the domain.</value>
        [DataMember(Name="laminarPrandtlNumber", EmitDefaultValue=false)]
        public decimal? LaminarPrandtlNumber { get; set; }

        /// <summary>
        /// Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.
        /// </summary>
        /// <value>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</value>
        [DataMember(Name="turbulentPrandtlNumber", EmitDefaultValue=false)]
        public decimal? TurbulentPrandtlNumber { get; set; }

        /// <summary>
        /// Gets or Sets SpecificHeat
        /// </summary>
        [DataMember(Name="specificHeat", EmitDefaultValue=false)]
        public DimensionalSpecificHeat SpecificHeat { get; set; }

        /// <summary>
        /// Gets or Sets MolarWeight
        /// </summary>
        [DataMember(Name="molarWeight", EmitDefaultValue=false)]
        public DimensionalMolarMass MolarWeight { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Gets or Sets BuiltInMaterial
        /// </summary>
        [DataMember(Name="builtInMaterial", EmitDefaultValue=false)]
        public string BuiltInMaterial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncompressibleMaterial {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AssociatedPhase: ").Append(AssociatedPhase).Append("\n");
            sb.Append("  ViscosityModel: ").Append(ViscosityModel).Append("\n");
            sb.Append("  Density: ").Append(Density).Append("\n");
            sb.Append("  ThermalExpansionCoefficient: ").Append(ThermalExpansionCoefficient).Append("\n");
            sb.Append("  ReferenceTemperature: ").Append(ReferenceTemperature).Append("\n");
            sb.Append("  LaminarPrandtlNumber: ").Append(LaminarPrandtlNumber).Append("\n");
            sb.Append("  TurbulentPrandtlNumber: ").Append(TurbulentPrandtlNumber).Append("\n");
            sb.Append("  SpecificHeat: ").Append(SpecificHeat).Append("\n");
            sb.Append("  MolarWeight: ").Append(MolarWeight).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
            sb.Append("  BuiltInMaterial: ").Append(BuiltInMaterial).Append("\n");
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
            return this.Equals(input as IncompressibleMaterial);
        }

        /// <summary>
        /// Returns true if IncompressibleMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of IncompressibleMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncompressibleMaterial input)
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
                    this.AssociatedPhase == input.AssociatedPhase ||
                    this.AssociatedPhase.Equals(input.AssociatedPhase)
                ) && 
                (
                    this.ViscosityModel == input.ViscosityModel ||
                    (this.ViscosityModel != null &&
                    this.ViscosityModel.Equals(input.ViscosityModel))
                ) && 
                (
                    this.Density == input.Density ||
                    (this.Density != null &&
                    this.Density.Equals(input.Density))
                ) && 
                (
                    this.ThermalExpansionCoefficient == input.ThermalExpansionCoefficient ||
                    (this.ThermalExpansionCoefficient != null &&
                    this.ThermalExpansionCoefficient.Equals(input.ThermalExpansionCoefficient))
                ) && 
                (
                    this.ReferenceTemperature == input.ReferenceTemperature ||
                    (this.ReferenceTemperature != null &&
                    this.ReferenceTemperature.Equals(input.ReferenceTemperature))
                ) && 
                (
                    this.LaminarPrandtlNumber == input.LaminarPrandtlNumber ||
                    (this.LaminarPrandtlNumber != null &&
                    this.LaminarPrandtlNumber.Equals(input.LaminarPrandtlNumber))
                ) && 
                (
                    this.TurbulentPrandtlNumber == input.TurbulentPrandtlNumber ||
                    (this.TurbulentPrandtlNumber != null &&
                    this.TurbulentPrandtlNumber.Equals(input.TurbulentPrandtlNumber))
                ) && 
                (
                    this.SpecificHeat == input.SpecificHeat ||
                    (this.SpecificHeat != null &&
                    this.SpecificHeat.Equals(input.SpecificHeat))
                ) && 
                (
                    this.MolarWeight == input.MolarWeight ||
                    (this.MolarWeight != null &&
                    this.MolarWeight.Equals(input.MolarWeight))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
                ) && 
                (
                    this.BuiltInMaterial == input.BuiltInMaterial ||
                    (this.BuiltInMaterial != null &&
                    this.BuiltInMaterial.Equals(input.BuiltInMaterial))
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
                hashCode = hashCode * 59 + this.AssociatedPhase.GetHashCode();
                if (this.ViscosityModel != null)
                    hashCode = hashCode * 59 + this.ViscosityModel.GetHashCode();
                if (this.Density != null)
                    hashCode = hashCode * 59 + this.Density.GetHashCode();
                if (this.ThermalExpansionCoefficient != null)
                    hashCode = hashCode * 59 + this.ThermalExpansionCoefficient.GetHashCode();
                if (this.ReferenceTemperature != null)
                    hashCode = hashCode * 59 + this.ReferenceTemperature.GetHashCode();
                if (this.LaminarPrandtlNumber != null)
                    hashCode = hashCode * 59 + this.LaminarPrandtlNumber.GetHashCode();
                if (this.TurbulentPrandtlNumber != null)
                    hashCode = hashCode * 59 + this.TurbulentPrandtlNumber.GetHashCode();
                if (this.SpecificHeat != null)
                    hashCode = hashCode * 59 + this.SpecificHeat.GetHashCode();
                if (this.MolarWeight != null)
                    hashCode = hashCode * 59 + this.MolarWeight.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                if (this.BuiltInMaterial != null)
                    hashCode = hashCode * 59 + this.BuiltInMaterial.GetHashCode();
                return hashCode;
            }
        }

    }

}
