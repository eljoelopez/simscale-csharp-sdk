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
    /// ThetaTimeIntegrationScheme
    /// </summary>
    [DataContract]
    public partial class ThetaTimeIntegrationScheme : OneOfImplicitTimeIntegrationTypeScheme, IEquatable<ThetaTimeIntegrationScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThetaTimeIntegrationScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThetaTimeIntegrationScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThetaTimeIntegrationScheme" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;THETA_METHOD&quot;).</param>
        /// <param name="theta">The parameter &lt;b&gt;&amp;theta;&lt;/b&gt; must be ranging between 0.5 and 1.0: 0.5 corresponds to a minimum, 1.0 to a maximum of numerical dissipation. The selection of &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 1.0 leads to the &lt;b&gt;Euler scheme&lt;/b&gt;, whereas &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 0.5 leads to the &lt;i&gt;Crank-Nicolson&lt;/i&gt; scheme of order 2..</param>
        public ThetaTimeIntegrationScheme(string type = "THETA_METHOD", decimal? theta = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ThetaTimeIntegrationScheme and cannot be null");
            this.Theta = theta;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The parameter &lt;b&gt;&amp;theta;&lt;/b&gt; must be ranging between 0.5 and 1.0: 0.5 corresponds to a minimum, 1.0 to a maximum of numerical dissipation. The selection of &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 1.0 leads to the &lt;b&gt;Euler scheme&lt;/b&gt;, whereas &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 0.5 leads to the &lt;i&gt;Crank-Nicolson&lt;/i&gt; scheme of order 2.
        /// </summary>
        /// <value>The parameter &lt;b&gt;&amp;theta;&lt;/b&gt; must be ranging between 0.5 and 1.0: 0.5 corresponds to a minimum, 1.0 to a maximum of numerical dissipation. The selection of &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 1.0 leads to the &lt;b&gt;Euler scheme&lt;/b&gt;, whereas &lt;b&gt;&amp;theta;&lt;/b&gt; &#x3D; 0.5 leads to the &lt;i&gt;Crank-Nicolson&lt;/i&gt; scheme of order 2.</value>
        [DataMember(Name="theta", EmitDefaultValue=false)]
        public decimal? Theta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThetaTimeIntegrationScheme {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Theta: ").Append(Theta).Append("\n");
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
            return this.Equals(input as ThetaTimeIntegrationScheme);
        }

        /// <summary>
        /// Returns true if ThetaTimeIntegrationScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of ThetaTimeIntegrationScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThetaTimeIntegrationScheme input)
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
                    this.Theta == input.Theta ||
                    (this.Theta != null &&
                    this.Theta.Equals(input.Theta))
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
                if (this.Theta != null)
                    hashCode = hashCode * 59 + this.Theta.GetHashCode();
                return hashCode;
            }
        }

    }

}
