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
    /// &lt;p&gt;Choose a linear equation system solver for your calculation:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Multfront&lt;/b&gt; is a direct solver of the multifrontal type. It is easy to set up and behaves well for most problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;MUMPS&lt;/b&gt; is a general purpose direct solver of the multifrontal type. It provides a lot of parameter settings to allow the best fitting to your problems needs.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;LDLT&lt;/b&gt; is a direct solver which uses a Gaussian Algortihm. It is comparatively slow for big problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PETSC&lt;/b&gt; is an iterative solver specially designed to deal with large systems. It scales very effectively in parallel and is the best choice for large problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCPC&lt;/b&gt; is an iterative solver of the pre-conditioned conjugate gradient type. It scales well in parallel and is also usable for large problems.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class PETSCSolver : OneOfSolidNumericsSolver, IEquatable<PETSCSolver>
    {
        /// <summary>
        /// Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GMRES&lt;/b&gt;: &lt;i&gt;Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.
        /// </summary>
        /// <value>Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GMRES&lt;/b&gt;: &lt;i&gt;Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 1,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 2,

            /// <summary>
            /// Enum GCR for value: GCR
            /// </summary>
            [EnumMember(Value = "GCR")]
            GCR = 3,

            /// <summary>
            /// Enum GMRES for value: GMRES
            /// </summary>
            [EnumMember(Value = "GMRES")]
            GMRES = 4

        }

        /// <summary>
        /// Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GMRES&lt;/b&gt;: &lt;i&gt;Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.
        /// </summary>
        /// <value>Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GMRES&lt;/b&gt;: &lt;i&gt;Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PETSCSolver" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PETSCSolver() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PETSCSolver" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;PETSC&quot;).</param>
        /// <param name="forceSymmetric">Choose if you want to enforce a symmetric matrix. (default to false).</param>
        /// <param name="algorithm">Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GMRES&lt;/b&gt;: &lt;i&gt;Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type..</param>
        /// <param name="preconditioner">preconditioner.</param>
        /// <param name="maxIterations">Set the maximum number of iterations for the iterative solver. If set to 0 PETSC sets an estimate of the maximum number of iterations. (default to 0).</param>
        /// <param name="convergenceThreshold">Set the threshold value for convergence detection for the relative convergence criteria. (default to 0.000010M).</param>
        /// <param name="distributedMatrixStorage">Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. (default to true).</param>
        public PETSCSolver(string type = "PETSC", bool? forceSymmetric = default(bool?), AlgorithmEnum? algorithm = default(AlgorithmEnum?), OneOfPETSCSolverPreconditioner preconditioner = default(OneOfPETSCSolverPreconditioner), int? maxIterations = default(int?), decimal? convergenceThreshold = default(decimal?), bool? distributedMatrixStorage = default(bool?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PETSCSolver and cannot be null");
            this.ForceSymmetric = forceSymmetric;
            this.Algorithm = algorithm;
            this.Preconditioner = preconditioner;
            this.MaxIterations = maxIterations;
            this.ConvergenceThreshold = convergenceThreshold;
            this.DistributedMatrixStorage = distributedMatrixStorage;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Choose if you want to enforce a symmetric matrix.
        /// </summary>
        /// <value>Choose if you want to enforce a symmetric matrix.</value>
        [DataMember(Name="forceSymmetric", EmitDefaultValue=false)]
        public bool? ForceSymmetric { get; set; }

        /// <summary>
        /// Gets or Sets Preconditioner
        /// </summary>
        [DataMember(Name="preconditioner", EmitDefaultValue=false)]
        public OneOfPETSCSolverPreconditioner Preconditioner { get; set; }

        /// <summary>
        /// Set the maximum number of iterations for the iterative solver. If set to 0 PETSC sets an estimate of the maximum number of iterations.
        /// </summary>
        /// <value>Set the maximum number of iterations for the iterative solver. If set to 0 PETSC sets an estimate of the maximum number of iterations.</value>
        [DataMember(Name="maxIterations", EmitDefaultValue=false)]
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Set the threshold value for convergence detection for the relative convergence criteria.
        /// </summary>
        /// <value>Set the threshold value for convergence detection for the relative convergence criteria.</value>
        [DataMember(Name="convergenceThreshold", EmitDefaultValue=false)]
        public decimal? ConvergenceThreshold { get; set; }

        /// <summary>
        /// Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor.
        /// </summary>
        /// <value>Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor.</value>
        [DataMember(Name="distributedMatrixStorage", EmitDefaultValue=false)]
        public bool? DistributedMatrixStorage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PETSCSolver {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ForceSymmetric: ").Append(ForceSymmetric).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Preconditioner: ").Append(Preconditioner).Append("\n");
            sb.Append("  MaxIterations: ").Append(MaxIterations).Append("\n");
            sb.Append("  ConvergenceThreshold: ").Append(ConvergenceThreshold).Append("\n");
            sb.Append("  DistributedMatrixStorage: ").Append(DistributedMatrixStorage).Append("\n");
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
            return this.Equals(input as PETSCSolver);
        }

        /// <summary>
        /// Returns true if PETSCSolver instances are equal
        /// </summary>
        /// <param name="input">Instance of PETSCSolver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PETSCSolver input)
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
                    this.ForceSymmetric == input.ForceSymmetric ||
                    (this.ForceSymmetric != null &&
                    this.ForceSymmetric.Equals(input.ForceSymmetric))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    this.Algorithm.Equals(input.Algorithm)
                ) && 
                (
                    this.Preconditioner == input.Preconditioner ||
                    (this.Preconditioner != null &&
                    this.Preconditioner.Equals(input.Preconditioner))
                ) && 
                (
                    this.MaxIterations == input.MaxIterations ||
                    (this.MaxIterations != null &&
                    this.MaxIterations.Equals(input.MaxIterations))
                ) && 
                (
                    this.ConvergenceThreshold == input.ConvergenceThreshold ||
                    (this.ConvergenceThreshold != null &&
                    this.ConvergenceThreshold.Equals(input.ConvergenceThreshold))
                ) && 
                (
                    this.DistributedMatrixStorage == input.DistributedMatrixStorage ||
                    (this.DistributedMatrixStorage != null &&
                    this.DistributedMatrixStorage.Equals(input.DistributedMatrixStorage))
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
                if (this.ForceSymmetric != null)
                    hashCode = hashCode * 59 + this.ForceSymmetric.GetHashCode();
                hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Preconditioner != null)
                    hashCode = hashCode * 59 + this.Preconditioner.GetHashCode();
                if (this.MaxIterations != null)
                    hashCode = hashCode * 59 + this.MaxIterations.GetHashCode();
                if (this.ConvergenceThreshold != null)
                    hashCode = hashCode * 59 + this.ConvergenceThreshold.GetHashCode();
                if (this.DistributedMatrixStorage != null)
                    hashCode = hashCode * 59 + this.DistributedMatrixStorage.GetHashCode();
                return hashCode;
            }
        }

    }

}
