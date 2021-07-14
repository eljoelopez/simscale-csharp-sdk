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
    /// FluidSimulationControl
    /// </summary>
    [DataContract]
    public partial class FluidSimulationControl : IEquatable<FluidSimulationControl>
    {
        /// <summary>
        /// &lt;p&gt;Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will save core hours. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control-fluid/#number-of-processors&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will save core hours. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control-fluid/#number-of-processors&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;</value>
        public enum NumProcessorsEnum
        {
            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8,

            /// <summary>
            /// Enum NUMBER_16 for value: 16
            /// </summary>
            NUMBER_16 = 16,

            /// <summary>
            /// Enum NUMBER_32 for value: 32
            /// </summary>
            NUMBER_32 = 32,

            /// <summary>
            /// Enum NUMBER_64 for value: 64
            /// </summary>
            NUMBER_64 = 64,

            /// <summary>
            /// Enum NUMBER_96 for value: 96
            /// </summary>
            NUMBER_96 = 96

        }

        /// <summary>
        /// &lt;p&gt;Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will save core hours. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control-fluid/#number-of-processors&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will save core hours. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control-fluid/#number-of-processors&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="numProcessors", EmitDefaultValue=false)]
        public NumProcessorsEnum? NumProcessors { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FluidSimulationControl" /> class.
        /// </summary>
        /// <param name="endTime">endTime.</param>
        /// <param name="numberOfIterations">This represents the amount of iterations at which the termination of simulation happens. No more iterations will be executed. &lt;/br&gt; &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;. (default to 500).</param>
        /// <param name="deltaT">deltaT.</param>
        /// <param name="adjustableTimestep">adjustableTimestep.</param>
        /// <param name="writeControl">writeControl.</param>
        /// <param name="numProcessors">&lt;p&gt;Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will save core hours. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control-fluid/#number-of-processors&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt; (default to NumProcessorsEnum.NUMBER_MINUS_1).</param>
        /// <param name="maxRunTime">maxRunTime.</param>
        /// <param name="potentialFoamInitialization">This setting activates the solution of a potential flow field. The potential flow is used as initial condition for the actual simulation. This can accelerate convergence and improve stability during the first time steps. If you experience stability problems, this setting may bring some improvement. (default to false).</param>
        /// <param name="decomposeAlgorithm">decomposeAlgorithm.</param>
        /// <param name="relativeConvergenceCriteria">The simulation is assumed to be converged and will stop if the relative residuals for all equations fall below this number. Relative residual is defined as the residual in the current iteration divided by the initial residual. (default to 0.001M).</param>
        public FluidSimulationControl(DimensionalTime endTime = default(DimensionalTime), int? numberOfIterations = default(int?), DimensionalTime deltaT = default(DimensionalTime), OneOfFluidSimulationControlAdjustableTimestep adjustableTimestep = default(OneOfFluidSimulationControlAdjustableTimestep), OneOfFluidSimulationControlWriteControl writeControl = default(OneOfFluidSimulationControlWriteControl), NumProcessorsEnum? numProcessors = default(NumProcessorsEnum?), DimensionalTime maxRunTime = default(DimensionalTime), bool? potentialFoamInitialization = default(bool?), OneOfFluidSimulationControlDecomposeAlgorithm decomposeAlgorithm = default(OneOfFluidSimulationControlDecomposeAlgorithm), decimal? relativeConvergenceCriteria = default(decimal?))
        {
            this.EndTime = endTime;
            this.NumberOfIterations = numberOfIterations;
            this.DeltaT = deltaT;
            this.AdjustableTimestep = adjustableTimestep;
            this.WriteControl = writeControl;
            this.NumProcessors = numProcessors;
            this.MaxRunTime = maxRunTime;
            this.PotentialFoamInitialization = potentialFoamInitialization;
            this.DecomposeAlgorithm = decomposeAlgorithm;
            this.RelativeConvergenceCriteria = relativeConvergenceCriteria;
        }
        
        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DimensionalTime EndTime { get; set; }

        /// <summary>
        /// This represents the amount of iterations at which the termination of simulation happens. No more iterations will be executed. &lt;/br&gt; &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
        /// </summary>
        /// <value>This represents the amount of iterations at which the termination of simulation happens. No more iterations will be executed. &lt;/br&gt; &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.</value>
        [DataMember(Name="numberOfIterations", EmitDefaultValue=false)]
        public int? NumberOfIterations { get; set; }

        /// <summary>
        /// Gets or Sets DeltaT
        /// </summary>
        [DataMember(Name="deltaT", EmitDefaultValue=false)]
        public DimensionalTime DeltaT { get; set; }

        /// <summary>
        /// Gets or Sets AdjustableTimestep
        /// </summary>
        [DataMember(Name="adjustableTimestep", EmitDefaultValue=false)]
        public OneOfFluidSimulationControlAdjustableTimestep AdjustableTimestep { get; set; }

        /// <summary>
        /// Gets or Sets WriteControl
        /// </summary>
        [DataMember(Name="writeControl", EmitDefaultValue=false)]
        public OneOfFluidSimulationControlWriteControl WriteControl { get; set; }

        /// <summary>
        /// Gets or Sets MaxRunTime
        /// </summary>
        [DataMember(Name="maxRunTime", EmitDefaultValue=false)]
        public DimensionalTime MaxRunTime { get; set; }

        /// <summary>
        /// This setting activates the solution of a potential flow field. The potential flow is used as initial condition for the actual simulation. This can accelerate convergence and improve stability during the first time steps. If you experience stability problems, this setting may bring some improvement.
        /// </summary>
        /// <value>This setting activates the solution of a potential flow field. The potential flow is used as initial condition for the actual simulation. This can accelerate convergence and improve stability during the first time steps. If you experience stability problems, this setting may bring some improvement.</value>
        [DataMember(Name="potentialFoamInitialization", EmitDefaultValue=false)]
        public bool? PotentialFoamInitialization { get; set; }

        /// <summary>
        /// Gets or Sets DecomposeAlgorithm
        /// </summary>
        [DataMember(Name="decomposeAlgorithm", EmitDefaultValue=false)]
        public OneOfFluidSimulationControlDecomposeAlgorithm DecomposeAlgorithm { get; set; }

        /// <summary>
        /// The simulation is assumed to be converged and will stop if the relative residuals for all equations fall below this number. Relative residual is defined as the residual in the current iteration divided by the initial residual.
        /// </summary>
        /// <value>The simulation is assumed to be converged and will stop if the relative residuals for all equations fall below this number. Relative residual is defined as the residual in the current iteration divided by the initial residual.</value>
        [DataMember(Name="relativeConvergenceCriteria", EmitDefaultValue=false)]
        public decimal? RelativeConvergenceCriteria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FluidSimulationControl {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  NumberOfIterations: ").Append(NumberOfIterations).Append("\n");
            sb.Append("  DeltaT: ").Append(DeltaT).Append("\n");
            sb.Append("  AdjustableTimestep: ").Append(AdjustableTimestep).Append("\n");
            sb.Append("  WriteControl: ").Append(WriteControl).Append("\n");
            sb.Append("  NumProcessors: ").Append(NumProcessors).Append("\n");
            sb.Append("  MaxRunTime: ").Append(MaxRunTime).Append("\n");
            sb.Append("  PotentialFoamInitialization: ").Append(PotentialFoamInitialization).Append("\n");
            sb.Append("  DecomposeAlgorithm: ").Append(DecomposeAlgorithm).Append("\n");
            sb.Append("  RelativeConvergenceCriteria: ").Append(RelativeConvergenceCriteria).Append("\n");
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
            return this.Equals(input as FluidSimulationControl);
        }

        /// <summary>
        /// Returns true if FluidSimulationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of FluidSimulationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FluidSimulationControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.NumberOfIterations == input.NumberOfIterations ||
                    (this.NumberOfIterations != null &&
                    this.NumberOfIterations.Equals(input.NumberOfIterations))
                ) && 
                (
                    this.DeltaT == input.DeltaT ||
                    (this.DeltaT != null &&
                    this.DeltaT.Equals(input.DeltaT))
                ) && 
                (
                    this.AdjustableTimestep == input.AdjustableTimestep ||
                    (this.AdjustableTimestep != null &&
                    this.AdjustableTimestep.Equals(input.AdjustableTimestep))
                ) && 
                (
                    this.WriteControl == input.WriteControl ||
                    (this.WriteControl != null &&
                    this.WriteControl.Equals(input.WriteControl))
                ) && 
                (
                    this.NumProcessors == input.NumProcessors ||
                    this.NumProcessors.Equals(input.NumProcessors)
                ) && 
                (
                    this.MaxRunTime == input.MaxRunTime ||
                    (this.MaxRunTime != null &&
                    this.MaxRunTime.Equals(input.MaxRunTime))
                ) && 
                (
                    this.PotentialFoamInitialization == input.PotentialFoamInitialization ||
                    (this.PotentialFoamInitialization != null &&
                    this.PotentialFoamInitialization.Equals(input.PotentialFoamInitialization))
                ) && 
                (
                    this.DecomposeAlgorithm == input.DecomposeAlgorithm ||
                    (this.DecomposeAlgorithm != null &&
                    this.DecomposeAlgorithm.Equals(input.DecomposeAlgorithm))
                ) && 
                (
                    this.RelativeConvergenceCriteria == input.RelativeConvergenceCriteria ||
                    (this.RelativeConvergenceCriteria != null &&
                    this.RelativeConvergenceCriteria.Equals(input.RelativeConvergenceCriteria))
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
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.NumberOfIterations != null)
                    hashCode = hashCode * 59 + this.NumberOfIterations.GetHashCode();
                if (this.DeltaT != null)
                    hashCode = hashCode * 59 + this.DeltaT.GetHashCode();
                if (this.AdjustableTimestep != null)
                    hashCode = hashCode * 59 + this.AdjustableTimestep.GetHashCode();
                if (this.WriteControl != null)
                    hashCode = hashCode * 59 + this.WriteControl.GetHashCode();
                hashCode = hashCode * 59 + this.NumProcessors.GetHashCode();
                if (this.MaxRunTime != null)
                    hashCode = hashCode * 59 + this.MaxRunTime.GetHashCode();
                if (this.PotentialFoamInitialization != null)
                    hashCode = hashCode * 59 + this.PotentialFoamInitialization.GetHashCode();
                if (this.DecomposeAlgorithm != null)
                    hashCode = hashCode * 59 + this.DecomposeAlgorithm.GetHashCode();
                if (this.RelativeConvergenceCriteria != null)
                    hashCode = hashCode * 59 + this.RelativeConvergenceCriteria.GetHashCode();
                return hashCode;
            }
        }

    }

}
