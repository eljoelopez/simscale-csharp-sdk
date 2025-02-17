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
    /// RelaxationFactor
    /// </summary>
    [DataContract]
    public partial class RelaxationFactor : IEquatable<RelaxationFactor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelaxationFactor" /> class.
        /// </summary>
        /// <param name="pressureField">&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;.</param>
        /// <param name="pressureRghField">pressureRghField (default to 0.7M).</param>
        /// <param name="passiveScalarEquation">passiveScalarEquation.</param>
        /// <param name="velocityEquation">&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;.</param>
        /// <param name="temperatureEquation">temperatureEquation.</param>
        /// <param name="densityField">&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;.</param>
        /// <param name="enthalpyEquation">&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;.</param>
        /// <param name="internalEnergyEquation">&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;.</param>
        /// <param name="turbulentKineticEnergyEquation">turbulentKineticEnergyEquation.</param>
        /// <param name="omegaDissipationRateEquation">omegaDissipationRateEquation.</param>
        /// <param name="epsilonDissipationRateEquation">epsilonDissipationRateEquation.</param>
        /// <param name="nuTildaEquation">nuTildaEquation.</param>
        /// <param name="netRadiativeHeatFluxField">netRadiativeHeatFluxField (default to 0.3M).</param>
        /// <param name="radiativeIntensityRayEquation">radiativeIntensityRayEquation (default to 0.5M).</param>
        public RelaxationFactor(decimal? pressureField = default(decimal?), decimal? pressureRghField = default(decimal?), decimal? passiveScalarEquation = default(decimal?), decimal? velocityEquation = default(decimal?), decimal? temperatureEquation = default(decimal?), decimal? densityField = default(decimal?), decimal? enthalpyEquation = default(decimal?), decimal? internalEnergyEquation = default(decimal?), decimal? turbulentKineticEnergyEquation = default(decimal?), decimal? omegaDissipationRateEquation = default(decimal?), decimal? epsilonDissipationRateEquation = default(decimal?), decimal? nuTildaEquation = default(decimal?), decimal? netRadiativeHeatFluxField = default(decimal?), decimal? radiativeIntensityRayEquation = default(decimal?))
        {
            this.PressureField = pressureField;
            this.PressureRghField = pressureRghField;
            this.PassiveScalarEquation = passiveScalarEquation;
            this.VelocityEquation = velocityEquation;
            this.TemperatureEquation = temperatureEquation;
            this.DensityField = densityField;
            this.EnthalpyEquation = enthalpyEquation;
            this.InternalEnergyEquation = internalEnergyEquation;
            this.TurbulentKineticEnergyEquation = turbulentKineticEnergyEquation;
            this.OmegaDissipationRateEquation = omegaDissipationRateEquation;
            this.EpsilonDissipationRateEquation = epsilonDissipationRateEquation;
            this.NuTildaEquation = nuTildaEquation;
            this.NetRadiativeHeatFluxField = netRadiativeHeatFluxField;
            this.RadiativeIntensityRayEquation = radiativeIntensityRayEquation;
        }
        
        /// <summary>
        /// &lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;</value>
        [DataMember(Name="pressureField", EmitDefaultValue=false)]
        public decimal? PressureField { get; set; }

        /// <summary>
        /// Gets or Sets PressureRghField
        /// </summary>
        [DataMember(Name="pressureRghField", EmitDefaultValue=false)]
        public decimal? PressureRghField { get; set; }

        /// <summary>
        /// Gets or Sets PassiveScalarEquation
        /// </summary>
        [DataMember(Name="passiveScalarEquation", EmitDefaultValue=false)]
        public decimal? PassiveScalarEquation { get; set; }

        /// <summary>
        /// &lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;</value>
        [DataMember(Name="velocityEquation", EmitDefaultValue=false)]
        public decimal? VelocityEquation { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureEquation
        /// </summary>
        [DataMember(Name="temperatureEquation", EmitDefaultValue=false)]
        public decimal? TemperatureEquation { get; set; }

        /// <summary>
        /// &lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;</value>
        [DataMember(Name="densityField", EmitDefaultValue=false)]
        public decimal? DensityField { get; set; }

        /// <summary>
        /// &lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;</value>
        [DataMember(Name="enthalpyEquation", EmitDefaultValue=false)]
        public decimal? EnthalpyEquation { get; set; }

        /// <summary>
        /// &lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;With this parameter you can initialize the under-relaxation of a field or equation. The solver will dynamically adapt this factor to improve stability.&lt;/p&gt;</value>
        [DataMember(Name="internalEnergyEquation", EmitDefaultValue=false)]
        public decimal? InternalEnergyEquation { get; set; }

        /// <summary>
        /// Gets or Sets TurbulentKineticEnergyEquation
        /// </summary>
        [DataMember(Name="turbulentKineticEnergyEquation", EmitDefaultValue=false)]
        public decimal? TurbulentKineticEnergyEquation { get; set; }

        /// <summary>
        /// Gets or Sets OmegaDissipationRateEquation
        /// </summary>
        [DataMember(Name="omegaDissipationRateEquation", EmitDefaultValue=false)]
        public decimal? OmegaDissipationRateEquation { get; set; }

        /// <summary>
        /// Gets or Sets EpsilonDissipationRateEquation
        /// </summary>
        [DataMember(Name="epsilonDissipationRateEquation", EmitDefaultValue=false)]
        public decimal? EpsilonDissipationRateEquation { get; set; }

        /// <summary>
        /// Gets or Sets NuTildaEquation
        /// </summary>
        [DataMember(Name="nuTildaEquation", EmitDefaultValue=false)]
        public decimal? NuTildaEquation { get; set; }

        /// <summary>
        /// Gets or Sets NetRadiativeHeatFluxField
        /// </summary>
        [DataMember(Name="netRadiativeHeatFluxField", EmitDefaultValue=false)]
        public decimal? NetRadiativeHeatFluxField { get; set; }

        /// <summary>
        /// Gets or Sets RadiativeIntensityRayEquation
        /// </summary>
        [DataMember(Name="radiativeIntensityRayEquation", EmitDefaultValue=false)]
        public decimal? RadiativeIntensityRayEquation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelaxationFactor {\n");
            sb.Append("  PressureField: ").Append(PressureField).Append("\n");
            sb.Append("  PressureRghField: ").Append(PressureRghField).Append("\n");
            sb.Append("  PassiveScalarEquation: ").Append(PassiveScalarEquation).Append("\n");
            sb.Append("  VelocityEquation: ").Append(VelocityEquation).Append("\n");
            sb.Append("  TemperatureEquation: ").Append(TemperatureEquation).Append("\n");
            sb.Append("  DensityField: ").Append(DensityField).Append("\n");
            sb.Append("  EnthalpyEquation: ").Append(EnthalpyEquation).Append("\n");
            sb.Append("  InternalEnergyEquation: ").Append(InternalEnergyEquation).Append("\n");
            sb.Append("  TurbulentKineticEnergyEquation: ").Append(TurbulentKineticEnergyEquation).Append("\n");
            sb.Append("  OmegaDissipationRateEquation: ").Append(OmegaDissipationRateEquation).Append("\n");
            sb.Append("  EpsilonDissipationRateEquation: ").Append(EpsilonDissipationRateEquation).Append("\n");
            sb.Append("  NuTildaEquation: ").Append(NuTildaEquation).Append("\n");
            sb.Append("  NetRadiativeHeatFluxField: ").Append(NetRadiativeHeatFluxField).Append("\n");
            sb.Append("  RadiativeIntensityRayEquation: ").Append(RadiativeIntensityRayEquation).Append("\n");
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
            return this.Equals(input as RelaxationFactor);
        }

        /// <summary>
        /// Returns true if RelaxationFactor instances are equal
        /// </summary>
        /// <param name="input">Instance of RelaxationFactor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelaxationFactor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PressureField == input.PressureField ||
                    (this.PressureField != null &&
                    this.PressureField.Equals(input.PressureField))
                ) && 
                (
                    this.PressureRghField == input.PressureRghField ||
                    (this.PressureRghField != null &&
                    this.PressureRghField.Equals(input.PressureRghField))
                ) && 
                (
                    this.PassiveScalarEquation == input.PassiveScalarEquation ||
                    (this.PassiveScalarEquation != null &&
                    this.PassiveScalarEquation.Equals(input.PassiveScalarEquation))
                ) && 
                (
                    this.VelocityEquation == input.VelocityEquation ||
                    (this.VelocityEquation != null &&
                    this.VelocityEquation.Equals(input.VelocityEquation))
                ) && 
                (
                    this.TemperatureEquation == input.TemperatureEquation ||
                    (this.TemperatureEquation != null &&
                    this.TemperatureEquation.Equals(input.TemperatureEquation))
                ) && 
                (
                    this.DensityField == input.DensityField ||
                    (this.DensityField != null &&
                    this.DensityField.Equals(input.DensityField))
                ) && 
                (
                    this.EnthalpyEquation == input.EnthalpyEquation ||
                    (this.EnthalpyEquation != null &&
                    this.EnthalpyEquation.Equals(input.EnthalpyEquation))
                ) && 
                (
                    this.InternalEnergyEquation == input.InternalEnergyEquation ||
                    (this.InternalEnergyEquation != null &&
                    this.InternalEnergyEquation.Equals(input.InternalEnergyEquation))
                ) && 
                (
                    this.TurbulentKineticEnergyEquation == input.TurbulentKineticEnergyEquation ||
                    (this.TurbulentKineticEnergyEquation != null &&
                    this.TurbulentKineticEnergyEquation.Equals(input.TurbulentKineticEnergyEquation))
                ) && 
                (
                    this.OmegaDissipationRateEquation == input.OmegaDissipationRateEquation ||
                    (this.OmegaDissipationRateEquation != null &&
                    this.OmegaDissipationRateEquation.Equals(input.OmegaDissipationRateEquation))
                ) && 
                (
                    this.EpsilonDissipationRateEquation == input.EpsilonDissipationRateEquation ||
                    (this.EpsilonDissipationRateEquation != null &&
                    this.EpsilonDissipationRateEquation.Equals(input.EpsilonDissipationRateEquation))
                ) && 
                (
                    this.NuTildaEquation == input.NuTildaEquation ||
                    (this.NuTildaEquation != null &&
                    this.NuTildaEquation.Equals(input.NuTildaEquation))
                ) && 
                (
                    this.NetRadiativeHeatFluxField == input.NetRadiativeHeatFluxField ||
                    (this.NetRadiativeHeatFluxField != null &&
                    this.NetRadiativeHeatFluxField.Equals(input.NetRadiativeHeatFluxField))
                ) && 
                (
                    this.RadiativeIntensityRayEquation == input.RadiativeIntensityRayEquation ||
                    (this.RadiativeIntensityRayEquation != null &&
                    this.RadiativeIntensityRayEquation.Equals(input.RadiativeIntensityRayEquation))
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
                if (this.PressureField != null)
                    hashCode = hashCode * 59 + this.PressureField.GetHashCode();
                if (this.PressureRghField != null)
                    hashCode = hashCode * 59 + this.PressureRghField.GetHashCode();
                if (this.PassiveScalarEquation != null)
                    hashCode = hashCode * 59 + this.PassiveScalarEquation.GetHashCode();
                if (this.VelocityEquation != null)
                    hashCode = hashCode * 59 + this.VelocityEquation.GetHashCode();
                if (this.TemperatureEquation != null)
                    hashCode = hashCode * 59 + this.TemperatureEquation.GetHashCode();
                if (this.DensityField != null)
                    hashCode = hashCode * 59 + this.DensityField.GetHashCode();
                if (this.EnthalpyEquation != null)
                    hashCode = hashCode * 59 + this.EnthalpyEquation.GetHashCode();
                if (this.InternalEnergyEquation != null)
                    hashCode = hashCode * 59 + this.InternalEnergyEquation.GetHashCode();
                if (this.TurbulentKineticEnergyEquation != null)
                    hashCode = hashCode * 59 + this.TurbulentKineticEnergyEquation.GetHashCode();
                if (this.OmegaDissipationRateEquation != null)
                    hashCode = hashCode * 59 + this.OmegaDissipationRateEquation.GetHashCode();
                if (this.EpsilonDissipationRateEquation != null)
                    hashCode = hashCode * 59 + this.EpsilonDissipationRateEquation.GetHashCode();
                if (this.NuTildaEquation != null)
                    hashCode = hashCode * 59 + this.NuTildaEquation.GetHashCode();
                if (this.NetRadiativeHeatFluxField != null)
                    hashCode = hashCode * 59 + this.NetRadiativeHeatFluxField.GetHashCode();
                if (this.RadiativeIntensityRayEquation != null)
                    hashCode = hashCode * 59 + this.RadiativeIntensityRayEquation.GetHashCode();
                return hashCode;
            }
        }

    }

}
