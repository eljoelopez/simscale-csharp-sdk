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
    /// &lt;p&gt;Select the event for the time step adaptation. Currently there are four different events possible that trigger a time step adaptation:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Error&lt;/b&gt;: This is the case of a general error like for example non-convergence or singular matrix errors.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Collision&lt;/b&gt;: This event is triggered if in a computation with physical contact a contact state change from open to closed is noticed. This time step adaptation is especially useful in dynamics to reduce the effect of artificial oscillations due to inexact collision detection.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change&lt;/b&gt;: The user can define the maximum delta that a field is allowed to change within one time step, if the defined threshold is exceeded the time step is adapted. This time stepping criteria is especially useful to capture material nonlinearitier more exact.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Non-monotonous residual&lt;/b&gt;: This event is triggered if the residual has not been reduced within three iterations . This criteria is mostly used to reduce runtime by detecting diverging time steps before reaching the maximum number of allowed newton iterations.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class NonMonotomousResidualRetimingEvent : OneOfAutoTimestepDefinitionRetimingEvent, IEquatable<NonMonotomousResidualRetimingEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonMonotomousResidualRetimingEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonMonotomousResidualRetimingEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonMonotomousResidualRetimingEvent" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;NON_MONOTOMOUS_RESIDUAL&quot;).</param>
        /// <param name="timestepCalculationType">timestepCalculationType.</param>
        public NonMonotomousResidualRetimingEvent(string type = "NON_MONOTOMOUS_RESIDUAL", OneOfNonMonotomousResidualRetimingEventTimestepCalculationType timestepCalculationType = default(OneOfNonMonotomousResidualRetimingEventTimestepCalculationType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NonMonotomousResidualRetimingEvent and cannot be null");
            this.TimestepCalculationType = timestepCalculationType;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TimestepCalculationType
        /// </summary>
        [DataMember(Name="timestepCalculationType", EmitDefaultValue=false)]
        public OneOfNonMonotomousResidualRetimingEventTimestepCalculationType TimestepCalculationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonMonotomousResidualRetimingEvent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimestepCalculationType: ").Append(TimestepCalculationType).Append("\n");
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
            return this.Equals(input as NonMonotomousResidualRetimingEvent);
        }

        /// <summary>
        /// Returns true if NonMonotomousResidualRetimingEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of NonMonotomousResidualRetimingEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonMonotomousResidualRetimingEvent input)
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
                    this.TimestepCalculationType == input.TimestepCalculationType ||
                    (this.TimestepCalculationType != null &&
                    this.TimestepCalculationType.Equals(input.TimestepCalculationType))
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
                if (this.TimestepCalculationType != null)
                    hashCode = hashCode * 59 + this.TimestepCalculationType.GetHashCode();
                return hashCode;
            }
        }

    }

}
