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
    /// PBICGSolver
    /// </summary>
    [DataContract]
    public partial class PBICGSolver : OneOfFluidSolversEnthalpyFinalSolver, OneOfFluidSolversEnthalpySolver, OneOfFluidSolversEpsilonDissipationRateFinalSolver, OneOfFluidSolversEpsilonDissipationRateSolver, OneOfFluidSolversInternalEnergyFinalSolver, OneOfFluidSolversInternalEnergySolver, OneOfFluidSolversNuTildaFinalSolver, OneOfFluidSolversNuTildaSolver, OneOfFluidSolversOmegaDissipationRateFinalSolver, OneOfFluidSolversOmegaDissipationRateSolver, OneOfFluidSolversPassiveScalarSolver, OneOfFluidSolversRadiativeIntensityRaySolver, OneOfFluidSolversTemperatureFinalSolver, OneOfFluidSolversTemperatureSolver, OneOfFluidSolversTurbulentKineticEnergyFinalSolver, OneOfFluidSolversTurbulentKineticEnergySolver, OneOfFluidSolversVelocityFinalSolver, OneOfFluidSolversVelocitySolver, OneOfTrueSemiImplicitSolver, IEquatable<PBICGSolver>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PBICGSolver" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PBICGSolver() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PBICGSolver" /> class.
        /// </summary>
        /// <param name="type">Schema name: PBICGSolver (required) (default to &quot;PBICG&quot;).</param>
        /// <param name="absoluteTolerance">&lt;p&gt;Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls below the absolute tolerance.&lt;/p&gt; (default to 0.000010M).</param>
        /// <param name="relativeTolerance">&lt;p&gt;Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of current to initial residual falls below the relative tolerance.&lt;/p&gt;.</param>
        /// <param name="preconditioner">preconditioner.</param>
        public PBICGSolver(string type = "PBICG", decimal? absoluteTolerance = default(decimal?), decimal? relativeTolerance = default(decimal?), OneOfPBICGSolverPreconditioner preconditioner = default(OneOfPBICGSolverPreconditioner))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PBICGSolver and cannot be null");
            this.AbsoluteTolerance = absoluteTolerance;
            this.RelativeTolerance = relativeTolerance;
            this.Preconditioner = preconditioner;
        }
        
        /// <summary>
        /// Schema name: PBICGSolver
        /// </summary>
        /// <value>Schema name: PBICGSolver</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls below the absolute tolerance.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the absolute tolerance for the residual. The convergence process will be stopped as soon as the residual falls below the absolute tolerance.&lt;/p&gt;</value>
        [DataMember(Name="absoluteTolerance", EmitDefaultValue=false)]
        public decimal? AbsoluteTolerance { get; set; }

        /// <summary>
        /// &lt;p&gt;Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of current to initial residual falls below the relative tolerance.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose the relative tolerance for the residual. The convergence process will be stopped as soon as the ratio of current to initial residual falls below the relative tolerance.&lt;/p&gt;</value>
        [DataMember(Name="relativeTolerance", EmitDefaultValue=false)]
        public decimal? RelativeTolerance { get; set; }

        /// <summary>
        /// Gets or Sets Preconditioner
        /// </summary>
        [DataMember(Name="preconditioner", EmitDefaultValue=false)]
        public OneOfPBICGSolverPreconditioner Preconditioner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PBICGSolver {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AbsoluteTolerance: ").Append(AbsoluteTolerance).Append("\n");
            sb.Append("  RelativeTolerance: ").Append(RelativeTolerance).Append("\n");
            sb.Append("  Preconditioner: ").Append(Preconditioner).Append("\n");
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
            return this.Equals(input as PBICGSolver);
        }

        /// <summary>
        /// Returns true if PBICGSolver instances are equal
        /// </summary>
        /// <param name="input">Instance of PBICGSolver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PBICGSolver input)
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
                    this.AbsoluteTolerance == input.AbsoluteTolerance ||
                    (this.AbsoluteTolerance != null &&
                    this.AbsoluteTolerance.Equals(input.AbsoluteTolerance))
                ) && 
                (
                    this.RelativeTolerance == input.RelativeTolerance ||
                    (this.RelativeTolerance != null &&
                    this.RelativeTolerance.Equals(input.RelativeTolerance))
                ) && 
                (
                    this.Preconditioner == input.Preconditioner ||
                    (this.Preconditioner != null &&
                    this.Preconditioner.Equals(input.Preconditioner))
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
                if (this.AbsoluteTolerance != null)
                    hashCode = hashCode * 59 + this.AbsoluteTolerance.GetHashCode();
                if (this.RelativeTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeTolerance.GetHashCode();
                if (this.Preconditioner != null)
                    hashCode = hashCode * 59 + this.Preconditioner.GetHashCode();
                return hashCode;
            }
        }

    }

}
