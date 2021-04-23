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
    /// &lt;p&gt;Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available via the selection &lt;b&gt;Newton&lt;/b&gt;. For iterative solvers also an inexact version of the Newton-Raphson method is available via the selection &lt;b&gt;Newton-Krylov&lt;/b&gt;.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class NewtonResolutionType : OneOfSolidNumericsMechanicalResolutionType, IEquatable<NewtonResolutionType>
    {
        /// <summary>
        /// &lt;p&gt;Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a good starting point for the first Newton iteration and thus a faster convergence.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a good starting point for the first Newton iteration and thus a faster convergence.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PredictionMatrixEnum
        {
            /// <summary>
            /// Enum TANGENT for value: TANGENT
            /// </summary>
            [EnumMember(Value = "TANGENT")]
            TANGENT = 1,

            /// <summary>
            /// Enum ELASTIC for value: ELASTIC
            /// </summary>
            [EnumMember(Value = "ELASTIC")]
            ELASTIC = 2

        }

        /// <summary>
        /// &lt;p&gt;Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a good starting point for the first Newton iteration and thus a faster convergence.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a good starting point for the first Newton iteration and thus a faster convergence.&lt;/p&gt;</value>
        [DataMember(Name="predictionMatrix", EmitDefaultValue=false)]
        public PredictionMatrixEnum? PredictionMatrix { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewtonResolutionType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewtonResolutionType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewtonResolutionType" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available via the selection &lt;b&gt;Newton&lt;/b&gt;. For iterative solvers also an inexact version of the Newton-Raphson method is available via the selection &lt;b&gt;Newton-Krylov&lt;/b&gt;.&lt;/p&gt;  Schema name: NewtonResolutionType (required) (default to &quot;NEWTON&quot;).</param>
        /// <param name="convergenceCriteria">convergenceCriteria.</param>
        /// <param name="predictionMatrix">&lt;p&gt;Select which stiffnes matrix should be used in the prediction phase of the Newton method. A good choice leads to a good starting point for the first Newton iteration and thus a faster convergence.&lt;/p&gt; (default to PredictionMatrixEnum.TANGENT).</param>
        /// <param name="jacobianMatrix">jacobianMatrix.</param>
        public NewtonResolutionType(string type = "NEWTON", OneOfNewtonResolutionTypeConvergenceCriteria convergenceCriteria = default(OneOfNewtonResolutionTypeConvergenceCriteria), PredictionMatrixEnum? predictionMatrix = default(PredictionMatrixEnum?), OneOfNewtonResolutionTypeJacobianMatrix jacobianMatrix = default(OneOfNewtonResolutionTypeJacobianMatrix))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NewtonResolutionType and cannot be null");
            this.ConvergenceCriteria = convergenceCriteria;
            this.PredictionMatrix = predictionMatrix;
            this.JacobianMatrix = jacobianMatrix;
        }
        
        /// <summary>
        /// &lt;p&gt;Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available via the selection &lt;b&gt;Newton&lt;/b&gt;. For iterative solvers also an inexact version of the Newton-Raphson method is available via the selection &lt;b&gt;Newton-Krylov&lt;/b&gt;.&lt;/p&gt;  Schema name: NewtonResolutionType
        /// </summary>
        /// <value>&lt;p&gt;Choose how the nonlinearities are solved. Currently for direct solvers only the Newton-Raphson method is available via the selection &lt;b&gt;Newton&lt;/b&gt;. For iterative solvers also an inexact version of the Newton-Raphson method is available via the selection &lt;b&gt;Newton-Krylov&lt;/b&gt;.&lt;/p&gt;  Schema name: NewtonResolutionType</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ConvergenceCriteria
        /// </summary>
        [DataMember(Name="convergenceCriteria", EmitDefaultValue=false)]
        public OneOfNewtonResolutionTypeConvergenceCriteria ConvergenceCriteria { get; set; }

        /// <summary>
        /// Gets or Sets JacobianMatrix
        /// </summary>
        [DataMember(Name="jacobianMatrix", EmitDefaultValue=false)]
        public OneOfNewtonResolutionTypeJacobianMatrix JacobianMatrix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewtonResolutionType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConvergenceCriteria: ").Append(ConvergenceCriteria).Append("\n");
            sb.Append("  PredictionMatrix: ").Append(PredictionMatrix).Append("\n");
            sb.Append("  JacobianMatrix: ").Append(JacobianMatrix).Append("\n");
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
            return this.Equals(input as NewtonResolutionType);
        }

        /// <summary>
        /// Returns true if NewtonResolutionType instances are equal
        /// </summary>
        /// <param name="input">Instance of NewtonResolutionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewtonResolutionType input)
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
                    this.ConvergenceCriteria == input.ConvergenceCriteria ||
                    (this.ConvergenceCriteria != null &&
                    this.ConvergenceCriteria.Equals(input.ConvergenceCriteria))
                ) && 
                (
                    this.PredictionMatrix == input.PredictionMatrix ||
                    this.PredictionMatrix.Equals(input.PredictionMatrix)
                ) && 
                (
                    this.JacobianMatrix == input.JacobianMatrix ||
                    (this.JacobianMatrix != null &&
                    this.JacobianMatrix.Equals(input.JacobianMatrix))
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
                if (this.ConvergenceCriteria != null)
                    hashCode = hashCode * 59 + this.ConvergenceCriteria.GetHashCode();
                hashCode = hashCode * 59 + this.PredictionMatrix.GetHashCode();
                if (this.JacobianMatrix != null)
                    hashCode = hashCode * 59 + this.JacobianMatrix.GetHashCode();
                return hashCode;
            }
        }

    }

}
