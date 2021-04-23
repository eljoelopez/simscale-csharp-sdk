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
    /// ConstantFunction
    /// </summary>
    [DataContract]
    public partial class ConstantFunction : OneOfComponentVectorFunctionX, OneOfComponentVectorFunctionY, OneOfComponentVectorFunctionZ, OneOfDimensionalFunctionAccelerationValue, OneOfDimensionalFunctionAngleValue, OneOfDimensionalFunctionDensityValue, OneOfDimensionalFunctionDimensionlessValue, OneOfDimensionalFunctionHeatFluxValue, OneOfDimensionalFunctionLengthValue, OneOfDimensionalFunctionMassFlowRateValue, OneOfDimensionalFunctionPowerValue, OneOfDimensionalFunctionPressureValue, OneOfDimensionalFunctionRotationSpeedValue, OneOfDimensionalFunctionSpecificHeatValue, OneOfDimensionalFunctionSpecificTurbulenceDissipationRateValue, OneOfDimensionalFunctionSpeedValue, OneOfDimensionalFunctionTemperatureGradientValue, OneOfDimensionalFunctionTemperatureValue, OneOfDimensionalFunctionThermalConductivityValue, OneOfDimensionalFunctionThermalExpansionRateValue, OneOfDimensionalFunctionThermalTransmittanceValue, OneOfDimensionalFunctionTurbulenceKineticEnergyValue, OneOfDimensionalFunctionTurbulentDissipationValue, OneOfDimensionalFunctionVolumetricFlowRateValue, OneOfDimensionalFunctionVolumetricPowerValue, OneOfIsotropicDirectionalDependencyPoissonsRatio, OneOfIsotropicPlasticHardeningPoissonsRatio, OneOfPrescribedOptionalFunctionValue, OneOfRestrictedDimensionalFunctionFrequencyValue, OneOfRestrictedDimensionalFunctionTimeValue, OneOfStressTensorPressureSigmaXX, OneOfStressTensorPressureSigmaXY, OneOfStressTensorPressureSigmaXZ, OneOfStressTensorPressureSigmaYY, OneOfStressTensorPressureSigmaYZ, OneOfStressTensorPressureSigmaZZ, IEquatable<ConstantFunction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantFunction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConstantFunction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantFunction" /> class.
        /// </summary>
        /// <param name="type">Schema name: ConstantFunction (required) (default to &quot;CONSTANT&quot;).</param>
        /// <param name="value">value.</param>
        public ConstantFunction(string type = "CONSTANT", decimal? value = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ConstantFunction and cannot be null");
            this.Value = value;
        }
        
        /// <summary>
        /// Schema name: ConstantFunction
        /// </summary>
        /// <value>Schema name: ConstantFunction</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstantFunction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ConstantFunction);
        }

        /// <summary>
        /// Returns true if ConstantFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstantFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstantFunction input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
