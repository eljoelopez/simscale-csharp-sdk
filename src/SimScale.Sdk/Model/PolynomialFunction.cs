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
    /// PolynomialFunction
    /// </summary>
    [DataContract]
    public partial class PolynomialFunction : OneOfComponentVectorFunctionX, OneOfComponentVectorFunctionY, OneOfComponentVectorFunctionZ, OneOfDimensionalFunctionAccelerationValue, OneOfDimensionalFunctionAngleValue, OneOfDimensionalFunctionDensityValue, OneOfDimensionalFunctionDimensionlessValue, OneOfDimensionalFunctionDynamicViscosityValue, OneOfDimensionalFunctionHeatFluxValue, OneOfDimensionalFunctionLengthValue, OneOfDimensionalFunctionMassFlowRateValue, OneOfDimensionalFunctionPowerValue, OneOfDimensionalFunctionPressureValue, OneOfDimensionalFunctionRotationSpeedValue, OneOfDimensionalFunctionSpecificHeatValue, OneOfDimensionalFunctionSpecificTurbulenceDissipationRateValue, OneOfDimensionalFunctionSpeedValue, OneOfDimensionalFunctionTemperatureGradientValue, OneOfDimensionalFunctionTemperatureValue, OneOfDimensionalFunctionThermalConductivityValue, OneOfDimensionalFunctionThermalExpansionRateValue, OneOfDimensionalFunctionThermalTransmittanceValue, OneOfDimensionalFunctionTurbulenceKineticEnergyValue, OneOfDimensionalFunctionTurbulentDissipationValue, OneOfDimensionalFunctionVolumetricFlowRateValue, OneOfDimensionalFunctionVolumetricPowerValue, OneOfIsotropicDirectionalDependencyPoissonsRatio, OneOfIsotropicPlasticHardeningPoissonsRatio, OneOfPrescribedOptionalFunctionValue, OneOfRestrictedDimensionalFunctionFrequencyValue, OneOfRestrictedDimensionalFunctionTimeValue, OneOfStressTensorPressureSigmaXX, OneOfStressTensorPressureSigmaXY, OneOfStressTensorPressureSigmaXZ, OneOfStressTensorPressureSigmaYY, OneOfStressTensorPressureSigmaYZ, OneOfStressTensorPressureSigmaZZ, IEquatable<PolynomialFunction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolynomialFunction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PolynomialFunction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolynomialFunction" /> class.
        /// </summary>
        /// <param name="type">Schema name: PolynomialFunction (required) (default to &quot;POLYNOMIAL&quot;).</param>
        /// <param name="coefficients">coefficients.</param>
        /// <param name="parameterBaseUnit">parameterBaseUnit (required).</param>
        public PolynomialFunction(string type = "POLYNOMIAL", List<decimal?> coefficients = default(List<decimal?>), string parameterBaseUnit = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PolynomialFunction and cannot be null");
            // to ensure "parameterBaseUnit" is required (not null)
            this.ParameterBaseUnit = parameterBaseUnit ?? throw new ArgumentNullException("parameterBaseUnit is a required property for PolynomialFunction and cannot be null");
            this.Coefficients = coefficients;
        }
        
        /// <summary>
        /// Schema name: PolynomialFunction
        /// </summary>
        /// <value>Schema name: PolynomialFunction</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Coefficients
        /// </summary>
        [DataMember(Name="coefficients", EmitDefaultValue=false)]
        public List<decimal?> Coefficients { get; set; }

        /// <summary>
        /// Gets or Sets ParameterBaseUnit
        /// </summary>
        [DataMember(Name="parameterBaseUnit", EmitDefaultValue=false)]
        public string ParameterBaseUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolynomialFunction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Coefficients: ").Append(Coefficients).Append("\n");
            sb.Append("  ParameterBaseUnit: ").Append(ParameterBaseUnit).Append("\n");
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
            return this.Equals(input as PolynomialFunction);
        }

        /// <summary>
        /// Returns true if PolynomialFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of PolynomialFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolynomialFunction input)
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
                    this.Coefficients == input.Coefficients ||
                    this.Coefficients != null &&
                    input.Coefficients != null &&
                    this.Coefficients.SequenceEqual(input.Coefficients)
                ) && 
                (
                    this.ParameterBaseUnit == input.ParameterBaseUnit ||
                    (this.ParameterBaseUnit != null &&
                    this.ParameterBaseUnit.Equals(input.ParameterBaseUnit))
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
                if (this.Coefficients != null)
                    hashCode = hashCode * 59 + this.Coefficients.GetHashCode();
                if (this.ParameterBaseUnit != null)
                    hashCode = hashCode * 59 + this.ParameterBaseUnit.GetHashCode();
                return hashCode;
            }
        }

    }

}
