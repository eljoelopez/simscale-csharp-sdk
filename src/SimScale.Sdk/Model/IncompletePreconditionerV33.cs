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
    /// IncompletePreconditionerV33
    /// </summary>
    [DataContract]
    public partial class IncompletePreconditionerV33 : OneOfGCPCSolverPreconditioner, OneOfPETSCSolverPreconditioner, IEquatable<IncompletePreconditionerV33>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompletePreconditionerV33" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncompletePreconditionerV33() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncompletePreconditionerV33" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;INCOMPLETE_LDLT_V33&quot;).</param>
        /// <param name="matrixCompleteness">Set the level of completeness for the incomplete Cholesky decomposition. The larger this value is, the better the preconditioning Matrix P approximates K&lt;sup&gt;-1&lt;/sup&gt;, but also the memory usage and computation time increase. If the solution does not converge or uses a lot of iterations it could help to increase this parameter. (default to 0).</param>
        /// <param name="preconditionerMatrixGrowth">Set the growth rate of the filling for the incomplete decomposition matrix. If this parameter is set to 1.0 PETSc estimates the matrix storage size from the first level of completeness. If this estimate is too low, PETSC increases the allocated memory on the fly, but this is more expensive. (default to 1M).</param>
        public IncompletePreconditionerV33(string type = "INCOMPLETE_LDLT_V33", int? matrixCompleteness = default(int?), decimal? preconditionerMatrixGrowth = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IncompletePreconditionerV33 and cannot be null");
            this.MatrixCompleteness = matrixCompleteness;
            this.PreconditionerMatrixGrowth = preconditionerMatrixGrowth;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Set the level of completeness for the incomplete Cholesky decomposition. The larger this value is, the better the preconditioning Matrix P approximates K&lt;sup&gt;-1&lt;/sup&gt;, but also the memory usage and computation time increase. If the solution does not converge or uses a lot of iterations it could help to increase this parameter.
        /// </summary>
        /// <value>Set the level of completeness for the incomplete Cholesky decomposition. The larger this value is, the better the preconditioning Matrix P approximates K&lt;sup&gt;-1&lt;/sup&gt;, but also the memory usage and computation time increase. If the solution does not converge or uses a lot of iterations it could help to increase this parameter.</value>
        [DataMember(Name="matrixCompleteness", EmitDefaultValue=false)]
        public int? MatrixCompleteness { get; set; }

        /// <summary>
        /// Set the growth rate of the filling for the incomplete decomposition matrix. If this parameter is set to 1.0 PETSc estimates the matrix storage size from the first level of completeness. If this estimate is too low, PETSC increases the allocated memory on the fly, but this is more expensive.
        /// </summary>
        /// <value>Set the growth rate of the filling for the incomplete decomposition matrix. If this parameter is set to 1.0 PETSc estimates the matrix storage size from the first level of completeness. If this estimate is too low, PETSC increases the allocated memory on the fly, but this is more expensive.</value>
        [DataMember(Name="preconditionerMatrixGrowth", EmitDefaultValue=false)]
        public decimal? PreconditionerMatrixGrowth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncompletePreconditionerV33 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MatrixCompleteness: ").Append(MatrixCompleteness).Append("\n");
            sb.Append("  PreconditionerMatrixGrowth: ").Append(PreconditionerMatrixGrowth).Append("\n");
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
            return this.Equals(input as IncompletePreconditionerV33);
        }

        /// <summary>
        /// Returns true if IncompletePreconditionerV33 instances are equal
        /// </summary>
        /// <param name="input">Instance of IncompletePreconditionerV33 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncompletePreconditionerV33 input)
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
                    this.MatrixCompleteness == input.MatrixCompleteness ||
                    (this.MatrixCompleteness != null &&
                    this.MatrixCompleteness.Equals(input.MatrixCompleteness))
                ) && 
                (
                    this.PreconditionerMatrixGrowth == input.PreconditionerMatrixGrowth ||
                    (this.PreconditionerMatrixGrowth != null &&
                    this.PreconditionerMatrixGrowth.Equals(input.PreconditionerMatrixGrowth))
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
                if (this.MatrixCompleteness != null)
                    hashCode = hashCode * 59 + this.MatrixCompleteness.GetHashCode();
                if (this.PreconditionerMatrixGrowth != null)
                    hashCode = hashCode * 59 + this.PreconditionerMatrixGrowth.GetHashCode();
                return hashCode;
            }
        }

    }

}
