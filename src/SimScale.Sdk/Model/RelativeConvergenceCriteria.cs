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
    /// &lt;p&gt;Select the type of convergence criterion for the nonlinear solution method.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;absolute&lt;/b&gt; if you want convergence to be reached when the maximum residual of all degrees of freedom of a given Newton iteration is lower than the given tolerance.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;relative&lt;/b&gt; if the same criteria as &lt;b&gt;absolute&lt;/b&gt; will be checked but for the maximum relative residual i.e. maximum absolute residual divided by external force. Please note, if no external force is involved e.g. two far objects coming in contact, then using relative criteria will lead to singularity and convergence will not be attained.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class RelativeConvergenceCriteria : OneOfNewtonKrylovResolutionTypeConvergenceCriteria, OneOfNewtonResolutionTypeConvergenceCriteria, IEquatable<RelativeConvergenceCriteria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelativeConvergenceCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceCriteria" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Select the type of convergence criterion for the nonlinear solution method.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;absolute&lt;/b&gt; if you want convergence to be reached when the maximum residual of all degrees of freedom of a given Newton iteration is lower than the given tolerance.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;relative&lt;/b&gt; if the same criteria as &lt;b&gt;absolute&lt;/b&gt; will be checked but for the maximum relative residual i.e. maximum absolute residual divided by external force. Please note, if no external force is involved e.g. two far objects coming in contact, then using relative criteria will lead to singularity and convergence will not be attained.&lt;/li&gt;&lt;/ul&gt;  Schema name: RelativeConvergenceCriteria (required) (default to &quot;RELATIVE&quot;).</param>
        /// <param name="tolerance">&lt;p&gt;Set the threshold value for convergence detection for the absolute convergence criteria. If the maximum abolute error of all DOFs fall below this value the current time step is considered convergent.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;In most of the cases using a lower value for tolerance may lead to hard or no convergence. Therefore, it is always recommended to start with a higher value e.g. 10&lt;sup&gt;-3&lt;/sup&gt; or 10&lt;sup&gt;-4&lt;/sup&gt;. Please also note that increasing the threshold value may effect the solution results. &lt;/li&gt;&lt;/ul&gt; (default to 0.000010M).</param>
        public RelativeConvergenceCriteria(string type = "RELATIVE", decimal? tolerance = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RelativeConvergenceCriteria and cannot be null");
            this.Tolerance = tolerance;
        }
        
        /// <summary>
        /// &lt;p&gt;Select the type of convergence criterion for the nonlinear solution method.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;absolute&lt;/b&gt; if you want convergence to be reached when the maximum residual of all degrees of freedom of a given Newton iteration is lower than the given tolerance.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;relative&lt;/b&gt; if the same criteria as &lt;b&gt;absolute&lt;/b&gt; will be checked but for the maximum relative residual i.e. maximum absolute residual divided by external force. Please note, if no external force is involved e.g. two far objects coming in contact, then using relative criteria will lead to singularity and convergence will not be attained.&lt;/li&gt;&lt;/ul&gt;  Schema name: RelativeConvergenceCriteria
        /// </summary>
        /// <value>&lt;p&gt;Select the type of convergence criterion for the nonlinear solution method.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;absolute&lt;/b&gt; if you want convergence to be reached when the maximum residual of all degrees of freedom of a given Newton iteration is lower than the given tolerance.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;relative&lt;/b&gt; if the same criteria as &lt;b&gt;absolute&lt;/b&gt; will be checked but for the maximum relative residual i.e. maximum absolute residual divided by external force. Please note, if no external force is involved e.g. two far objects coming in contact, then using relative criteria will lead to singularity and convergence will not be attained.&lt;/li&gt;&lt;/ul&gt;  Schema name: RelativeConvergenceCriteria</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Set the threshold value for convergence detection for the absolute convergence criteria. If the maximum abolute error of all DOFs fall below this value the current time step is considered convergent.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;In most of the cases using a lower value for tolerance may lead to hard or no convergence. Therefore, it is always recommended to start with a higher value e.g. 10&lt;sup&gt;-3&lt;/sup&gt; or 10&lt;sup&gt;-4&lt;/sup&gt;. Please also note that increasing the threshold value may effect the solution results. &lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>&lt;p&gt;Set the threshold value for convergence detection for the absolute convergence criteria. If the maximum abolute error of all DOFs fall below this value the current time step is considered convergent.&lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;In most of the cases using a lower value for tolerance may lead to hard or no convergence. Therefore, it is always recommended to start with a higher value e.g. 10&lt;sup&gt;-3&lt;/sup&gt; or 10&lt;sup&gt;-4&lt;/sup&gt;. Please also note that increasing the threshold value may effect the solution results. &lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="tolerance", EmitDefaultValue=false)]
        public decimal? Tolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeConvergenceCriteria {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
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
            return this.Equals(input as RelativeConvergenceCriteria);
        }

        /// <summary>
        /// Returns true if RelativeConvergenceCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeConvergenceCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeConvergenceCriteria input)
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
                    this.Tolerance == input.Tolerance ||
                    (this.Tolerance != null &&
                    this.Tolerance.Equals(input.Tolerance))
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
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                return hashCode;
            }
        }

    }

}
