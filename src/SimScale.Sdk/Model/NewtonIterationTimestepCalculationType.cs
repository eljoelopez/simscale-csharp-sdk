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
    /// &lt;p&gt;Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Manual&lt;/b&gt;: Here the user defines fixed time step subdivision and augmentation settings.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Newton Iterations Target&lt;/b&gt;: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change Target&lt;/b&gt;: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Mixed&lt;/b&gt;: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class NewtonIterationTimestepCalculationType : OneOfErrorRetimingEventTimestepCalculationType, OneOfNonMonotomousResidualRetimingEventTimestepCalculationType, IEquatable<NewtonIterationTimestepCalculationType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewtonIterationTimestepCalculationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewtonIterationTimestepCalculationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewtonIterationTimestepCalculationType" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Manual&lt;/b&gt;: Here the user defines fixed time step subdivision and augmentation settings.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Newton Iterations Target&lt;/b&gt;: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change Target&lt;/b&gt;: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Mixed&lt;/b&gt;: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.&lt;/p&gt;&lt;/ul&gt;  Schema name: NewtonIterationTimestepCalculationType (required) (default to &quot;NEWTON_ITERATION&quot;).</param>
        /// <param name="value">&lt;p&gt;Define the target value for the number of Newton Iterations within a time step.&lt;/p&gt; (default to 8).</param>
        public NewtonIterationTimestepCalculationType(string type = "NEWTON_ITERATION", int? value = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NewtonIterationTimestepCalculationType and cannot be null");
            this.Value = value;
        }
        
        /// <summary>
        /// &lt;p&gt;Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Manual&lt;/b&gt;: Here the user defines fixed time step subdivision and augmentation settings.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Newton Iterations Target&lt;/b&gt;: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change Target&lt;/b&gt;: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Mixed&lt;/b&gt;: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.&lt;/p&gt;&lt;/ul&gt;  Schema name: NewtonIterationTimestepCalculationType
        /// </summary>
        /// <value>&lt;p&gt;Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Manual&lt;/b&gt;: Here the user defines fixed time step subdivision and augmentation settings.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Newton Iterations Target&lt;/b&gt;: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change Target&lt;/b&gt;: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Mixed&lt;/b&gt;: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.&lt;/p&gt;&lt;/ul&gt;  Schema name: NewtonIterationTimestepCalculationType</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the target value for the number of Newton Iterations within a time step.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the target value for the number of Newton Iterations within a time step.&lt;/p&gt;</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewtonIterationTimestepCalculationType {\n");
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
            return this.Equals(input as NewtonIterationTimestepCalculationType);
        }

        /// <summary>
        /// Returns true if NewtonIterationTimestepCalculationType instances are equal
        /// </summary>
        /// <param name="input">Instance of NewtonIterationTimestepCalculationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewtonIterationTimestepCalculationType input)
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
