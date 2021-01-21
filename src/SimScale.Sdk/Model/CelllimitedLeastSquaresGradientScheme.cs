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
    /// CelllimitedLeastSquaresGradientScheme
    /// </summary>
    [DataContract]
    public partial class CelllimitedLeastSquaresGradientScheme : OneOfGradientSchemesForDefault, OneOfGradientSchemesGradDensity, OneOfGradientSchemesGradEnthalpy, OneOfGradientSchemesGradEpsilonDissipationRate, OneOfGradientSchemesGradInternalEnergy, OneOfGradientSchemesGradNuTilda, OneOfGradientSchemesGradOmegaDissipationRate, OneOfGradientSchemesGradPressure, OneOfGradientSchemesGradPressureRgh, OneOfGradientSchemesGradRhok, OneOfGradientSchemesGradTemperature, OneOfGradientSchemesGradTurbulentKineticEnergy, OneOfGradientSchemesGradVelocity, IEquatable<CelllimitedLeastSquaresGradientScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CelllimitedLeastSquaresGradientScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CelllimitedLeastSquaresGradientScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CelllimitedLeastSquaresGradientScheme" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;CELLLIMITED_LEASTSQUARES&quot;).</param>
        /// <param name="limiterCoefficient">This property defines a limiter coefficient for the scheme. 1 ensures boundedness while 0 applies no limiting. (default to 1M).</param>
        public CelllimitedLeastSquaresGradientScheme(string type = "CELLLIMITED_LEASTSQUARES", decimal? limiterCoefficient = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CelllimitedLeastSquaresGradientScheme and cannot be null");
            this.LimiterCoefficient = limiterCoefficient;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// This property defines a limiter coefficient for the scheme. 1 ensures boundedness while 0 applies no limiting.
        /// </summary>
        /// <value>This property defines a limiter coefficient for the scheme. 1 ensures boundedness while 0 applies no limiting.</value>
        [DataMember(Name="limiterCoefficient", EmitDefaultValue=false)]
        public decimal? LimiterCoefficient { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CelllimitedLeastSquaresGradientScheme {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LimiterCoefficient: ").Append(LimiterCoefficient).Append("\n");
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
            return this.Equals(input as CelllimitedLeastSquaresGradientScheme);
        }

        /// <summary>
        /// Returns true if CelllimitedLeastSquaresGradientScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of CelllimitedLeastSquaresGradientScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CelllimitedLeastSquaresGradientScheme input)
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
                    this.LimiterCoefficient == input.LimiterCoefficient ||
                    (this.LimiterCoefficient != null &&
                    this.LimiterCoefficient.Equals(input.LimiterCoefficient))
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
                if (this.LimiterCoefficient != null)
                    hashCode = hashCode * 59 + this.LimiterCoefficient.GetHashCode();
                return hashCode;
            }
        }

    }

}
