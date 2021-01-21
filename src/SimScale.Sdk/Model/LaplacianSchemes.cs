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
    /// LaplacianSchemes
    /// </summary>
    [DataContract]
    public partial class LaplacianSchemes : IEquatable<LaplacianSchemes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaplacianSchemes" /> class.
        /// </summary>
        /// <param name="forDefault">forDefault.</param>
        /// <param name="laplacianNuEffVelocity">laplacianNuEffVelocity.</param>
        /// <param name="laplacian1AUPressure">laplacian1AUPressure.</param>
        /// <param name="laplacianNuVelocity">laplacianNuVelocity.</param>
        /// <param name="laplacianDREffR">laplacianDREffR.</param>
        /// <param name="laplacianDnuTildaEffNuTilda">laplacianDnuTildaEffNuTilda.</param>
        /// <param name="laplacianDkEffTurbulentKineticEnergy">laplacianDkEffTurbulentKineticEnergy.</param>
        /// <param name="laplacianAlphaEffEnthalpy">laplacianAlphaEffEnthalpy.</param>
        /// <param name="laplacianAlphaEnthalpy">laplacianAlphaEnthalpy.</param>
        /// <param name="laplacianMuEffVelocity">laplacianMuEffVelocity.</param>
        /// <param name="laplacianAlphaEffInternalEnergy">laplacianAlphaEffInternalEnergy.</param>
        /// <param name="laplacianRhorAUfPressureRgh">laplacianRhorAUfPressureRgh.</param>
        /// <param name="laplacianDepsilonEffEpsilonDissipationRate">laplacianDepsilonEffEpsilonDissipationRate.</param>
        /// <param name="laplacianDomegaEffOmegaDissipationRate">laplacianDomegaEffOmegaDissipationRate.</param>
        /// <param name="laplacianRAUfPressure">laplacianRAUfPressure.</param>
        /// <param name="laplacianDTPassiveScalar">laplacianDTPassiveScalar.</param>
        /// <param name="laplacianDpPressure">laplacianDpPressure.</param>
        /// <param name="laplacianRhorAUfPressure">laplacianRhorAUfPressure.</param>
        /// <param name="laplacianRho1AUPressure">laplacianRho1AUPressure.</param>
        /// <param name="laplacianMutVelocity">laplacianMutVelocity.</param>
        /// <param name="laplacianAlphaEffTemperature">laplacianAlphaEffTemperature.</param>
        /// <param name="laplacianRAUfPressureRgh">laplacianRAUfPressureRgh.</param>
        public LaplacianSchemes(OneOfLaplacianSchemesForDefault forDefault = default(OneOfLaplacianSchemesForDefault), OneOfLaplacianSchemesLaplacianNuEffVelocity laplacianNuEffVelocity = default(OneOfLaplacianSchemesLaplacianNuEffVelocity), OneOfLaplacianSchemesLaplacian1AUPressure laplacian1AUPressure = default(OneOfLaplacianSchemesLaplacian1AUPressure), OneOfLaplacianSchemesLaplacianNuVelocity laplacianNuVelocity = default(OneOfLaplacianSchemesLaplacianNuVelocity), OneOfLaplacianSchemesLaplacianDREffR laplacianDREffR = default(OneOfLaplacianSchemesLaplacianDREffR), OneOfLaplacianSchemesLaplacianDnuTildaEffNuTilda laplacianDnuTildaEffNuTilda = default(OneOfLaplacianSchemesLaplacianDnuTildaEffNuTilda), OneOfLaplacianSchemesLaplacianDkEffTurbulentKineticEnergy laplacianDkEffTurbulentKineticEnergy = default(OneOfLaplacianSchemesLaplacianDkEffTurbulentKineticEnergy), OneOfLaplacianSchemesLaplacianAlphaEffEnthalpy laplacianAlphaEffEnthalpy = default(OneOfLaplacianSchemesLaplacianAlphaEffEnthalpy), OneOfLaplacianSchemesLaplacianAlphaEnthalpy laplacianAlphaEnthalpy = default(OneOfLaplacianSchemesLaplacianAlphaEnthalpy), OneOfLaplacianSchemesLaplacianMuEffVelocity laplacianMuEffVelocity = default(OneOfLaplacianSchemesLaplacianMuEffVelocity), OneOfLaplacianSchemesLaplacianAlphaEffInternalEnergy laplacianAlphaEffInternalEnergy = default(OneOfLaplacianSchemesLaplacianAlphaEffInternalEnergy), OneOfLaplacianSchemesLaplacianRhorAUfPressureRgh laplacianRhorAUfPressureRgh = default(OneOfLaplacianSchemesLaplacianRhorAUfPressureRgh), OneOfLaplacianSchemesLaplacianDepsilonEffEpsilonDissipationRate laplacianDepsilonEffEpsilonDissipationRate = default(OneOfLaplacianSchemesLaplacianDepsilonEffEpsilonDissipationRate), OneOfLaplacianSchemesLaplacianDomegaEffOmegaDissipationRate laplacianDomegaEffOmegaDissipationRate = default(OneOfLaplacianSchemesLaplacianDomegaEffOmegaDissipationRate), OneOfLaplacianSchemesLaplacianRAUfPressure laplacianRAUfPressure = default(OneOfLaplacianSchemesLaplacianRAUfPressure), OneOfLaplacianSchemesLaplacianDTPassiveScalar laplacianDTPassiveScalar = default(OneOfLaplacianSchemesLaplacianDTPassiveScalar), OneOfLaplacianSchemesLaplacianDpPressure laplacianDpPressure = default(OneOfLaplacianSchemesLaplacianDpPressure), OneOfLaplacianSchemesLaplacianRhorAUfPressure laplacianRhorAUfPressure = default(OneOfLaplacianSchemesLaplacianRhorAUfPressure), OneOfLaplacianSchemesLaplacianRho1AUPressure laplacianRho1AUPressure = default(OneOfLaplacianSchemesLaplacianRho1AUPressure), OneOfLaplacianSchemesLaplacianMutVelocity laplacianMutVelocity = default(OneOfLaplacianSchemesLaplacianMutVelocity), OneOfLaplacianSchemesLaplacianAlphaEffTemperature laplacianAlphaEffTemperature = default(OneOfLaplacianSchemesLaplacianAlphaEffTemperature), OneOfLaplacianSchemesLaplacianRAUfPressureRgh laplacianRAUfPressureRgh = default(OneOfLaplacianSchemesLaplacianRAUfPressureRgh))
        {
            this.ForDefault = forDefault;
            this.LaplacianNuEffVelocity = laplacianNuEffVelocity;
            this.Laplacian1AUPressure = laplacian1AUPressure;
            this.LaplacianNuVelocity = laplacianNuVelocity;
            this.LaplacianDREffR = laplacianDREffR;
            this.LaplacianDnuTildaEffNuTilda = laplacianDnuTildaEffNuTilda;
            this.LaplacianDkEffTurbulentKineticEnergy = laplacianDkEffTurbulentKineticEnergy;
            this.LaplacianAlphaEffEnthalpy = laplacianAlphaEffEnthalpy;
            this.LaplacianAlphaEnthalpy = laplacianAlphaEnthalpy;
            this.LaplacianMuEffVelocity = laplacianMuEffVelocity;
            this.LaplacianAlphaEffInternalEnergy = laplacianAlphaEffInternalEnergy;
            this.LaplacianRhorAUfPressureRgh = laplacianRhorAUfPressureRgh;
            this.LaplacianDepsilonEffEpsilonDissipationRate = laplacianDepsilonEffEpsilonDissipationRate;
            this.LaplacianDomegaEffOmegaDissipationRate = laplacianDomegaEffOmegaDissipationRate;
            this.LaplacianRAUfPressure = laplacianRAUfPressure;
            this.LaplacianDTPassiveScalar = laplacianDTPassiveScalar;
            this.LaplacianDpPressure = laplacianDpPressure;
            this.LaplacianRhorAUfPressure = laplacianRhorAUfPressure;
            this.LaplacianRho1AUPressure = laplacianRho1AUPressure;
            this.LaplacianMutVelocity = laplacianMutVelocity;
            this.LaplacianAlphaEffTemperature = laplacianAlphaEffTemperature;
            this.LaplacianRAUfPressureRgh = laplacianRAUfPressureRgh;
        }
        
        /// <summary>
        /// Gets or Sets ForDefault
        /// </summary>
        [DataMember(Name="forDefault", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesForDefault ForDefault { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianNuEffVelocity
        /// </summary>
        [DataMember(Name="laplacian_NuEff_velocity", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianNuEffVelocity LaplacianNuEffVelocity { get; set; }

        /// <summary>
        /// Gets or Sets Laplacian1AUPressure
        /// </summary>
        [DataMember(Name="laplacian_1A_U_pressure", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacian1AUPressure Laplacian1AUPressure { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianNuVelocity
        /// </summary>
        [DataMember(Name="laplacian_Nu_velocity", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianNuVelocity LaplacianNuVelocity { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDREffR
        /// </summary>
        [DataMember(Name="laplacian_DREff_R", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDREffR LaplacianDREffR { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDnuTildaEffNuTilda
        /// </summary>
        [DataMember(Name="laplacian_DnuTildaEff_nuTilda", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDnuTildaEffNuTilda LaplacianDnuTildaEffNuTilda { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDkEffTurbulentKineticEnergy
        /// </summary>
        [DataMember(Name="laplacian_DkEff_turbulentKineticEnergy", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDkEffTurbulentKineticEnergy LaplacianDkEffTurbulentKineticEnergy { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianAlphaEffEnthalpy
        /// </summary>
        [DataMember(Name="laplacian_alphaEff_enthalpy", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianAlphaEffEnthalpy LaplacianAlphaEffEnthalpy { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianAlphaEnthalpy
        /// </summary>
        [DataMember(Name="laplacian_alpha_enthalpy", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianAlphaEnthalpy LaplacianAlphaEnthalpy { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianMuEffVelocity
        /// </summary>
        [DataMember(Name="laplacian_muEff_velocity", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianMuEffVelocity LaplacianMuEffVelocity { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianAlphaEffInternalEnergy
        /// </summary>
        [DataMember(Name="laplacian_alphaEff_internalEnergy", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianAlphaEffInternalEnergy LaplacianAlphaEffInternalEnergy { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianRhorAUfPressureRgh
        /// </summary>
        [DataMember(Name="laplacian_rhorAUf_pressureRgh", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianRhorAUfPressureRgh LaplacianRhorAUfPressureRgh { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDepsilonEffEpsilonDissipationRate
        /// </summary>
        [DataMember(Name="laplacian_DepsilonEff_epsilonDissipationRate", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDepsilonEffEpsilonDissipationRate LaplacianDepsilonEffEpsilonDissipationRate { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDomegaEffOmegaDissipationRate
        /// </summary>
        [DataMember(Name="laplacian_DomegaEff_omegaDissipationRate", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDomegaEffOmegaDissipationRate LaplacianDomegaEffOmegaDissipationRate { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianRAUfPressure
        /// </summary>
        [DataMember(Name="laplacian_rAUf_pressure", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianRAUfPressure LaplacianRAUfPressure { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDTPassiveScalar
        /// </summary>
        [DataMember(Name="laplacian_DT_passiveScalar", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDTPassiveScalar LaplacianDTPassiveScalar { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianDpPressure
        /// </summary>
        [DataMember(Name="laplacian_Dp_pressure", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianDpPressure LaplacianDpPressure { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianRhorAUfPressure
        /// </summary>
        [DataMember(Name="laplacian_rhorAUf_pressure", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianRhorAUfPressure LaplacianRhorAUfPressure { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianRho1AUPressure
        /// </summary>
        [DataMember(Name="laplacian_rho_1_A_U_pressure", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianRho1AUPressure LaplacianRho1AUPressure { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianMutVelocity
        /// </summary>
        [DataMember(Name="laplacian_mut_velocity", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianMutVelocity LaplacianMutVelocity { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianAlphaEffTemperature
        /// </summary>
        [DataMember(Name="laplacian_alphaEff_temperature", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianAlphaEffTemperature LaplacianAlphaEffTemperature { get; set; }

        /// <summary>
        /// Gets or Sets LaplacianRAUfPressureRgh
        /// </summary>
        [DataMember(Name="laplacian_rAUf_pressureRgh", EmitDefaultValue=false)]
        public OneOfLaplacianSchemesLaplacianRAUfPressureRgh LaplacianRAUfPressureRgh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LaplacianSchemes {\n");
            sb.Append("  ForDefault: ").Append(ForDefault).Append("\n");
            sb.Append("  LaplacianNuEffVelocity: ").Append(LaplacianNuEffVelocity).Append("\n");
            sb.Append("  Laplacian1AUPressure: ").Append(Laplacian1AUPressure).Append("\n");
            sb.Append("  LaplacianNuVelocity: ").Append(LaplacianNuVelocity).Append("\n");
            sb.Append("  LaplacianDREffR: ").Append(LaplacianDREffR).Append("\n");
            sb.Append("  LaplacianDnuTildaEffNuTilda: ").Append(LaplacianDnuTildaEffNuTilda).Append("\n");
            sb.Append("  LaplacianDkEffTurbulentKineticEnergy: ").Append(LaplacianDkEffTurbulentKineticEnergy).Append("\n");
            sb.Append("  LaplacianAlphaEffEnthalpy: ").Append(LaplacianAlphaEffEnthalpy).Append("\n");
            sb.Append("  LaplacianAlphaEnthalpy: ").Append(LaplacianAlphaEnthalpy).Append("\n");
            sb.Append("  LaplacianMuEffVelocity: ").Append(LaplacianMuEffVelocity).Append("\n");
            sb.Append("  LaplacianAlphaEffInternalEnergy: ").Append(LaplacianAlphaEffInternalEnergy).Append("\n");
            sb.Append("  LaplacianRhorAUfPressureRgh: ").Append(LaplacianRhorAUfPressureRgh).Append("\n");
            sb.Append("  LaplacianDepsilonEffEpsilonDissipationRate: ").Append(LaplacianDepsilonEffEpsilonDissipationRate).Append("\n");
            sb.Append("  LaplacianDomegaEffOmegaDissipationRate: ").Append(LaplacianDomegaEffOmegaDissipationRate).Append("\n");
            sb.Append("  LaplacianRAUfPressure: ").Append(LaplacianRAUfPressure).Append("\n");
            sb.Append("  LaplacianDTPassiveScalar: ").Append(LaplacianDTPassiveScalar).Append("\n");
            sb.Append("  LaplacianDpPressure: ").Append(LaplacianDpPressure).Append("\n");
            sb.Append("  LaplacianRhorAUfPressure: ").Append(LaplacianRhorAUfPressure).Append("\n");
            sb.Append("  LaplacianRho1AUPressure: ").Append(LaplacianRho1AUPressure).Append("\n");
            sb.Append("  LaplacianMutVelocity: ").Append(LaplacianMutVelocity).Append("\n");
            sb.Append("  LaplacianAlphaEffTemperature: ").Append(LaplacianAlphaEffTemperature).Append("\n");
            sb.Append("  LaplacianRAUfPressureRgh: ").Append(LaplacianRAUfPressureRgh).Append("\n");
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
            return this.Equals(input as LaplacianSchemes);
        }

        /// <summary>
        /// Returns true if LaplacianSchemes instances are equal
        /// </summary>
        /// <param name="input">Instance of LaplacianSchemes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LaplacianSchemes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForDefault == input.ForDefault ||
                    (this.ForDefault != null &&
                    this.ForDefault.Equals(input.ForDefault))
                ) && 
                (
                    this.LaplacianNuEffVelocity == input.LaplacianNuEffVelocity ||
                    (this.LaplacianNuEffVelocity != null &&
                    this.LaplacianNuEffVelocity.Equals(input.LaplacianNuEffVelocity))
                ) && 
                (
                    this.Laplacian1AUPressure == input.Laplacian1AUPressure ||
                    (this.Laplacian1AUPressure != null &&
                    this.Laplacian1AUPressure.Equals(input.Laplacian1AUPressure))
                ) && 
                (
                    this.LaplacianNuVelocity == input.LaplacianNuVelocity ||
                    (this.LaplacianNuVelocity != null &&
                    this.LaplacianNuVelocity.Equals(input.LaplacianNuVelocity))
                ) && 
                (
                    this.LaplacianDREffR == input.LaplacianDREffR ||
                    (this.LaplacianDREffR != null &&
                    this.LaplacianDREffR.Equals(input.LaplacianDREffR))
                ) && 
                (
                    this.LaplacianDnuTildaEffNuTilda == input.LaplacianDnuTildaEffNuTilda ||
                    (this.LaplacianDnuTildaEffNuTilda != null &&
                    this.LaplacianDnuTildaEffNuTilda.Equals(input.LaplacianDnuTildaEffNuTilda))
                ) && 
                (
                    this.LaplacianDkEffTurbulentKineticEnergy == input.LaplacianDkEffTurbulentKineticEnergy ||
                    (this.LaplacianDkEffTurbulentKineticEnergy != null &&
                    this.LaplacianDkEffTurbulentKineticEnergy.Equals(input.LaplacianDkEffTurbulentKineticEnergy))
                ) && 
                (
                    this.LaplacianAlphaEffEnthalpy == input.LaplacianAlphaEffEnthalpy ||
                    (this.LaplacianAlphaEffEnthalpy != null &&
                    this.LaplacianAlphaEffEnthalpy.Equals(input.LaplacianAlphaEffEnthalpy))
                ) && 
                (
                    this.LaplacianAlphaEnthalpy == input.LaplacianAlphaEnthalpy ||
                    (this.LaplacianAlphaEnthalpy != null &&
                    this.LaplacianAlphaEnthalpy.Equals(input.LaplacianAlphaEnthalpy))
                ) && 
                (
                    this.LaplacianMuEffVelocity == input.LaplacianMuEffVelocity ||
                    (this.LaplacianMuEffVelocity != null &&
                    this.LaplacianMuEffVelocity.Equals(input.LaplacianMuEffVelocity))
                ) && 
                (
                    this.LaplacianAlphaEffInternalEnergy == input.LaplacianAlphaEffInternalEnergy ||
                    (this.LaplacianAlphaEffInternalEnergy != null &&
                    this.LaplacianAlphaEffInternalEnergy.Equals(input.LaplacianAlphaEffInternalEnergy))
                ) && 
                (
                    this.LaplacianRhorAUfPressureRgh == input.LaplacianRhorAUfPressureRgh ||
                    (this.LaplacianRhorAUfPressureRgh != null &&
                    this.LaplacianRhorAUfPressureRgh.Equals(input.LaplacianRhorAUfPressureRgh))
                ) && 
                (
                    this.LaplacianDepsilonEffEpsilonDissipationRate == input.LaplacianDepsilonEffEpsilonDissipationRate ||
                    (this.LaplacianDepsilonEffEpsilonDissipationRate != null &&
                    this.LaplacianDepsilonEffEpsilonDissipationRate.Equals(input.LaplacianDepsilonEffEpsilonDissipationRate))
                ) && 
                (
                    this.LaplacianDomegaEffOmegaDissipationRate == input.LaplacianDomegaEffOmegaDissipationRate ||
                    (this.LaplacianDomegaEffOmegaDissipationRate != null &&
                    this.LaplacianDomegaEffOmegaDissipationRate.Equals(input.LaplacianDomegaEffOmegaDissipationRate))
                ) && 
                (
                    this.LaplacianRAUfPressure == input.LaplacianRAUfPressure ||
                    (this.LaplacianRAUfPressure != null &&
                    this.LaplacianRAUfPressure.Equals(input.LaplacianRAUfPressure))
                ) && 
                (
                    this.LaplacianDTPassiveScalar == input.LaplacianDTPassiveScalar ||
                    (this.LaplacianDTPassiveScalar != null &&
                    this.LaplacianDTPassiveScalar.Equals(input.LaplacianDTPassiveScalar))
                ) && 
                (
                    this.LaplacianDpPressure == input.LaplacianDpPressure ||
                    (this.LaplacianDpPressure != null &&
                    this.LaplacianDpPressure.Equals(input.LaplacianDpPressure))
                ) && 
                (
                    this.LaplacianRhorAUfPressure == input.LaplacianRhorAUfPressure ||
                    (this.LaplacianRhorAUfPressure != null &&
                    this.LaplacianRhorAUfPressure.Equals(input.LaplacianRhorAUfPressure))
                ) && 
                (
                    this.LaplacianRho1AUPressure == input.LaplacianRho1AUPressure ||
                    (this.LaplacianRho1AUPressure != null &&
                    this.LaplacianRho1AUPressure.Equals(input.LaplacianRho1AUPressure))
                ) && 
                (
                    this.LaplacianMutVelocity == input.LaplacianMutVelocity ||
                    (this.LaplacianMutVelocity != null &&
                    this.LaplacianMutVelocity.Equals(input.LaplacianMutVelocity))
                ) && 
                (
                    this.LaplacianAlphaEffTemperature == input.LaplacianAlphaEffTemperature ||
                    (this.LaplacianAlphaEffTemperature != null &&
                    this.LaplacianAlphaEffTemperature.Equals(input.LaplacianAlphaEffTemperature))
                ) && 
                (
                    this.LaplacianRAUfPressureRgh == input.LaplacianRAUfPressureRgh ||
                    (this.LaplacianRAUfPressureRgh != null &&
                    this.LaplacianRAUfPressureRgh.Equals(input.LaplacianRAUfPressureRgh))
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
                if (this.ForDefault != null)
                    hashCode = hashCode * 59 + this.ForDefault.GetHashCode();
                if (this.LaplacianNuEffVelocity != null)
                    hashCode = hashCode * 59 + this.LaplacianNuEffVelocity.GetHashCode();
                if (this.Laplacian1AUPressure != null)
                    hashCode = hashCode * 59 + this.Laplacian1AUPressure.GetHashCode();
                if (this.LaplacianNuVelocity != null)
                    hashCode = hashCode * 59 + this.LaplacianNuVelocity.GetHashCode();
                if (this.LaplacianDREffR != null)
                    hashCode = hashCode * 59 + this.LaplacianDREffR.GetHashCode();
                if (this.LaplacianDnuTildaEffNuTilda != null)
                    hashCode = hashCode * 59 + this.LaplacianDnuTildaEffNuTilda.GetHashCode();
                if (this.LaplacianDkEffTurbulentKineticEnergy != null)
                    hashCode = hashCode * 59 + this.LaplacianDkEffTurbulentKineticEnergy.GetHashCode();
                if (this.LaplacianAlphaEffEnthalpy != null)
                    hashCode = hashCode * 59 + this.LaplacianAlphaEffEnthalpy.GetHashCode();
                if (this.LaplacianAlphaEnthalpy != null)
                    hashCode = hashCode * 59 + this.LaplacianAlphaEnthalpy.GetHashCode();
                if (this.LaplacianMuEffVelocity != null)
                    hashCode = hashCode * 59 + this.LaplacianMuEffVelocity.GetHashCode();
                if (this.LaplacianAlphaEffInternalEnergy != null)
                    hashCode = hashCode * 59 + this.LaplacianAlphaEffInternalEnergy.GetHashCode();
                if (this.LaplacianRhorAUfPressureRgh != null)
                    hashCode = hashCode * 59 + this.LaplacianRhorAUfPressureRgh.GetHashCode();
                if (this.LaplacianDepsilonEffEpsilonDissipationRate != null)
                    hashCode = hashCode * 59 + this.LaplacianDepsilonEffEpsilonDissipationRate.GetHashCode();
                if (this.LaplacianDomegaEffOmegaDissipationRate != null)
                    hashCode = hashCode * 59 + this.LaplacianDomegaEffOmegaDissipationRate.GetHashCode();
                if (this.LaplacianRAUfPressure != null)
                    hashCode = hashCode * 59 + this.LaplacianRAUfPressure.GetHashCode();
                if (this.LaplacianDTPassiveScalar != null)
                    hashCode = hashCode * 59 + this.LaplacianDTPassiveScalar.GetHashCode();
                if (this.LaplacianDpPressure != null)
                    hashCode = hashCode * 59 + this.LaplacianDpPressure.GetHashCode();
                if (this.LaplacianRhorAUfPressure != null)
                    hashCode = hashCode * 59 + this.LaplacianRhorAUfPressure.GetHashCode();
                if (this.LaplacianRho1AUPressure != null)
                    hashCode = hashCode * 59 + this.LaplacianRho1AUPressure.GetHashCode();
                if (this.LaplacianMutVelocity != null)
                    hashCode = hashCode * 59 + this.LaplacianMutVelocity.GetHashCode();
                if (this.LaplacianAlphaEffTemperature != null)
                    hashCode = hashCode * 59 + this.LaplacianAlphaEffTemperature.GetHashCode();
                if (this.LaplacianRAUfPressureRgh != null)
                    hashCode = hashCode * 59 + this.LaplacianRAUfPressureRgh.GetHashCode();
                return hashCode;
            }
        }

    }

}
