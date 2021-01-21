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
    /// &lt;p&gt;Define the Creep formulation. Two fundamental Creep law types are available: &lt;ul&gt;&lt;li&gt;&lt;b&gt;Power Law&lt;/b&gt;&lt;/li&gt;&lt;b&gt;&amp;epsilon;&amp;#775 &#x3D; m*A*&amp;sigma;&lt;sup&gt;n&lt;/sup&gt;*t&lt;sup&gt;m-1&lt;/sup&gt;&lt;/b&gt;&lt;li&gt;&lt;b&gt;Hyperbolic Sine Law&lt;/b&gt; &lt;/li&gt;&lt;b&gt;&amp;epsilon;&amp;#775;&#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* sinh(&amp;sigma;/(&amp;sigma;&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;.&lt;/ul&gt; For the Power Law different formulations, like the &lt;b&gt;Norton&lt;/b&gt;, &lt;b&gt;Strain Hardening&lt;/b&gt; or &lt;b&gt;Time Hardening&lt;/b&gt; are available. For the Hyperbolic Sine Law, the &lt;b&gt;Garofalo&lt;b&gt; formulation is available.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class GarofaloCreepFormulation : OneOfLinearElasticMaterialBehaviorCreepFormulation, OneOfPlasticMaterialBehaviorCreepFormulation, IEquatable<GarofaloCreepFormulation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GarofaloCreepFormulation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GarofaloCreepFormulation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GarofaloCreepFormulation" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;GAROFALO&quot;).</param>
        /// <param name="a">a.</param>
        /// <param name="n">&lt;p&gt;Define the parameter &lt;b&gt;&amp;sigma;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;.</param>
        /// <param name="s">&lt;p&gt;Define the parameter &lt;b&gt;&amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;.</param>
        public GarofaloCreepFormulation(string type = "GAROFALO", DimensionalStrainRate a = default(DimensionalStrainRate), decimal? n = default(decimal?), decimal? s = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GarofaloCreepFormulation and cannot be null");
            this.A = a;
            this.N = n;
            this.S = s;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name="a", EmitDefaultValue=false)]
        public DimensionalStrainRate A { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the parameter &lt;b&gt;&amp;sigma;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the parameter &lt;b&gt;&amp;sigma;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public decimal? N { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the parameter &lt;b&gt;&amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the parameter &lt;b&gt;&amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;&lt;/b&gt; of the Garofalo creep formulation: &lt;ul&gt;&lt;b&gt;&amp;epsilon;&amp;#775; &#x3D; &amp;epsilon;&lt;sub&gt;0&lt;/sub&gt;* &amp;sinh(&amp;sigma;/(&amp;sigma&lt;sub&gt;0&lt;/sub&gt;))&lt;sup&gt;n&lt;/sup&gt;&lt;/b&gt;&lt;/ul&gt;&lt;/p&gt;</value>
        [DataMember(Name="s", EmitDefaultValue=false)]
        public decimal? S { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GarofaloCreepFormulation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  S: ").Append(S).Append("\n");
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
            return this.Equals(input as GarofaloCreepFormulation);
        }

        /// <summary>
        /// Returns true if GarofaloCreepFormulation instances are equal
        /// </summary>
        /// <param name="input">Instance of GarofaloCreepFormulation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GarofaloCreepFormulation input)
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
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.S == input.S ||
                    (this.S != null &&
                    this.S.Equals(input.S))
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
                if (this.A != null)
                    hashCode = hashCode * 59 + this.A.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.S != null)
                    hashCode = hashCode * 59 + this.S.GetHashCode();
                return hashCode;
            }
        }

    }

}
