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
    public partial class GCPCSolver : OneOfSolidNumericsSolver, IEquatable<GCPCSolver>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPCSolver" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GCPCSolver() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GCPCSolver" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Choose a linear equation system solver for your calculation:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Multfront&lt;/b&gt; is a direct solver of the multifrontal type. It is easy to set up and behaves well for most problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;MUMPS&lt;/b&gt; is a general purpose direct solver of the multifrontal type. It provides a lot of parameter settings to allow the best fitting to your problems needs.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;LDLT&lt;/b&gt; is a direct solver which uses a Gaussian Algortihm. It is comparatively slow for big problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PETSC&lt;/b&gt; is an iterative solver specially designed to deal with large systems. It scales very effectively in parallel and is the best choice for large problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCPC&lt;/b&gt; is an iterative solver of the pre-conditioned conjugate gradient type. It scales well in parallel and is also usable for large problems.&lt;/p&gt;&lt;/ul&gt;  Schema name: GCPCSolver (required) (default to &quot;GCPC&quot;).</param>
        /// <param name="forceSymmetric">Choose if you want to enforce a symmetric matrix. (default to false).</param>
        /// <param name="preconditioner">preconditioner.</param>
        /// <param name="maxIterations">Set the maximum number of iterations for the iterative solver. If set to 0 the algorithm computes the maximum number of iterations as the the number of equations ot the system divided by 2. (default to 0).</param>
        /// <param name="convergenceThreshold">Set the threshold value for convergence detection for the relative convergence criteria. (default to 0.000010M).</param>
        public GCPCSolver(string type = "GCPC", bool? forceSymmetric = default(bool?), OneOfGCPCSolverPreconditioner preconditioner = default(OneOfGCPCSolverPreconditioner), int? maxIterations = default(int?), decimal? convergenceThreshold = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GCPCSolver and cannot be null");
            this.ForceSymmetric = forceSymmetric;
            this.Preconditioner = preconditioner;
            this.MaxIterations = maxIterations;
            this.ConvergenceThreshold = convergenceThreshold;
        }
        
        /// <summary>
        /// &lt;p&gt;Choose a linear equation system solver for your calculation:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Multfront&lt;/b&gt; is a direct solver of the multifrontal type. It is easy to set up and behaves well for most problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;MUMPS&lt;/b&gt; is a general purpose direct solver of the multifrontal type. It provides a lot of parameter settings to allow the best fitting to your problems needs.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;LDLT&lt;/b&gt; is a direct solver which uses a Gaussian Algortihm. It is comparatively slow for big problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PETSC&lt;/b&gt; is an iterative solver specially designed to deal with large systems. It scales very effectively in parallel and is the best choice for large problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCPC&lt;/b&gt; is an iterative solver of the pre-conditioned conjugate gradient type. It scales well in parallel and is also usable for large problems.&lt;/p&gt;&lt;/ul&gt;  Schema name: GCPCSolver
        /// </summary>
        /// <value>&lt;p&gt;Choose a linear equation system solver for your calculation:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Multfront&lt;/b&gt; is a direct solver of the multifrontal type. It is easy to set up and behaves well for most problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;MUMPS&lt;/b&gt; is a general purpose direct solver of the multifrontal type. It provides a lot of parameter settings to allow the best fitting to your problems needs.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;LDLT&lt;/b&gt; is a direct solver which uses a Gaussian Algortihm. It is comparatively slow for big problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PETSC&lt;/b&gt; is an iterative solver specially designed to deal with large systems. It scales very effectively in parallel and is the best choice for large problems.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCPC&lt;/b&gt; is an iterative solver of the pre-conditioned conjugate gradient type. It scales well in parallel and is also usable for large problems.&lt;/p&gt;&lt;/ul&gt;  Schema name: GCPCSolver</value>
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
        public OneOfGCPCSolverPreconditioner Preconditioner { get; set; }

        /// <summary>
        /// Set the maximum number of iterations for the iterative solver. If set to 0 the algorithm computes the maximum number of iterations as the the number of equations ot the system divided by 2.
        /// </summary>
        /// <value>Set the maximum number of iterations for the iterative solver. If set to 0 the algorithm computes the maximum number of iterations as the the number of equations ot the system divided by 2.</value>
        [DataMember(Name="maxIterations", EmitDefaultValue=false)]
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Set the threshold value for convergence detection for the relative convergence criteria.
        /// </summary>
        /// <value>Set the threshold value for convergence detection for the relative convergence criteria.</value>
        [DataMember(Name="convergenceThreshold", EmitDefaultValue=false)]
        public decimal? ConvergenceThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GCPCSolver {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ForceSymmetric: ").Append(ForceSymmetric).Append("\n");
            sb.Append("  Preconditioner: ").Append(Preconditioner).Append("\n");
            sb.Append("  MaxIterations: ").Append(MaxIterations).Append("\n");
            sb.Append("  ConvergenceThreshold: ").Append(ConvergenceThreshold).Append("\n");
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
            return this.Equals(input as GCPCSolver);
        }

        /// <summary>
        /// Returns true if GCPCSolver instances are equal
        /// </summary>
        /// <param name="input">Instance of GCPCSolver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GCPCSolver input)
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
                if (this.Preconditioner != null)
                    hashCode = hashCode * 59 + this.Preconditioner.GetHashCode();
                if (this.MaxIterations != null)
                    hashCode = hashCode * 59 + this.MaxIterations.GetHashCode();
                if (this.ConvergenceThreshold != null)
                    hashCode = hashCode * 59 + this.ConvergenceThreshold.GetHashCode();
                return hashCode;
            }
        }

    }

}
