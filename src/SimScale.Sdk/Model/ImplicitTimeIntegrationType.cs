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
    /// &lt;p&gt;Choose the time integration scheme type&lt;/p&gt;&lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;implicit&lt;/b&gt; if the problem is static or dynamic but not so complex. Implicit analysis takes more solution time but can solve the problem easily with larger timesteps. Therefore, it is always recommended to use implicit time integration scheme. &lt;/li&gt;&lt;i&gt;Choose &lt;b&gt;explicit&lt;/b&gt; if the problem is only dynamic and highly complex. Explicit analysis takes less solution time but also needs more refined (small) timesteps to solve the problem. Therefore, in most of the cases it&#39;s not recommended due to convergence problems. &lt;/i&gt;&lt;/ul&gt; 
    /// </summary>
    [DataContract]
    public partial class ImplicitTimeIntegrationType : OneOfSolidNumericsMechanicalTimeIntegrationType, IEquatable<ImplicitTimeIntegrationType>
    {
        /// <summary>
        /// &lt;p&gt;Choose the primary variable for the time integration scheme.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose the primary variable for the time integration scheme.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemeFormulationEnum
        {
            /// <summary>
            /// Enum DISPLACEMENT for value: DISPLACEMENT
            /// </summary>
            [EnumMember(Value = "DISPLACEMENT")]
            DISPLACEMENT = 1

        }

        /// <summary>
        /// &lt;p&gt;Choose the primary variable for the time integration scheme.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose the primary variable for the time integration scheme.&lt;/p&gt;</value>
        [DataMember(Name="schemeFormulation", EmitDefaultValue=false)]
        public SchemeFormulationEnum? SchemeFormulation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImplicitTimeIntegrationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImplicitTimeIntegrationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImplicitTimeIntegrationType" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Choose the time integration scheme type&lt;/p&gt;&lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;implicit&lt;/b&gt; if the problem is static or dynamic but not so complex. Implicit analysis takes more solution time but can solve the problem easily with larger timesteps. Therefore, it is always recommended to use implicit time integration scheme. &lt;/li&gt;&lt;i&gt;Choose &lt;b&gt;explicit&lt;/b&gt; if the problem is only dynamic and highly complex. Explicit analysis takes less solution time but also needs more refined (small) timesteps to solve the problem. Therefore, in most of the cases it&#39;s not recommended due to convergence problems. &lt;/i&gt;&lt;/ul&gt;   Schema name: ImplicitTimeIntegrationType (required) (default to &quot;IMPLICIT&quot;).</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="schemeFormulation">&lt;p&gt;Choose the primary variable for the time integration scheme.&lt;/p&gt; (default to SchemeFormulationEnum.DISPLACEMENT).</param>
        /// <param name="massMatrixShift">&lt;p&gt;This parameter c&lt;sub&gt;K&lt;/sub&gt; allows the shifting of the mass matrix with the stiffness matrix multiplied by c&lt;sub&gt;K&lt;/sub&gt;: &lt;b&gt;M&lt;/b&gt;&lt;sup&gt;&#39;&lt;/sup&gt;&#x3D;&lt;b&gt;M&lt;/b&gt; + c&lt;sub&gt;K&lt;/sub&gt;*&lt;b&gt;K&lt;/b&gt;. This makes it possible to strongly improve convergence in dynamics with implicit time scheme by imposing a cut-off frequency inversely proportional to the value of c&lt;sub&gt;K&lt;/sub&gt; (at the cost of a light distortion of all the eigen frequencies of the system).&lt;/p&gt; (default to 0M).</param>
        public ImplicitTimeIntegrationType(string type = "IMPLICIT", OneOfImplicitTimeIntegrationTypeScheme scheme = default(OneOfImplicitTimeIntegrationTypeScheme), SchemeFormulationEnum? schemeFormulation = default(SchemeFormulationEnum?), decimal? massMatrixShift = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ImplicitTimeIntegrationType and cannot be null");
            this.Scheme = scheme;
            this.SchemeFormulation = schemeFormulation;
            this.MassMatrixShift = massMatrixShift;
        }
        
        /// <summary>
        /// &lt;p&gt;Choose the time integration scheme type&lt;/p&gt;&lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;implicit&lt;/b&gt; if the problem is static or dynamic but not so complex. Implicit analysis takes more solution time but can solve the problem easily with larger timesteps. Therefore, it is always recommended to use implicit time integration scheme. &lt;/li&gt;&lt;i&gt;Choose &lt;b&gt;explicit&lt;/b&gt; if the problem is only dynamic and highly complex. Explicit analysis takes less solution time but also needs more refined (small) timesteps to solve the problem. Therefore, in most of the cases it&#39;s not recommended due to convergence problems. &lt;/i&gt;&lt;/ul&gt;   Schema name: ImplicitTimeIntegrationType
        /// </summary>
        /// <value>&lt;p&gt;Choose the time integration scheme type&lt;/p&gt;&lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;implicit&lt;/b&gt; if the problem is static or dynamic but not so complex. Implicit analysis takes more solution time but can solve the problem easily with larger timesteps. Therefore, it is always recommended to use implicit time integration scheme. &lt;/li&gt;&lt;i&gt;Choose &lt;b&gt;explicit&lt;/b&gt; if the problem is only dynamic and highly complex. Explicit analysis takes less solution time but also needs more refined (small) timesteps to solve the problem. Therefore, in most of the cases it&#39;s not recommended due to convergence problems. &lt;/i&gt;&lt;/ul&gt;   Schema name: ImplicitTimeIntegrationType</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public OneOfImplicitTimeIntegrationTypeScheme Scheme { get; set; }

        /// <summary>
        /// &lt;p&gt;This parameter c&lt;sub&gt;K&lt;/sub&gt; allows the shifting of the mass matrix with the stiffness matrix multiplied by c&lt;sub&gt;K&lt;/sub&gt;: &lt;b&gt;M&lt;/b&gt;&lt;sup&gt;&#39;&lt;/sup&gt;&#x3D;&lt;b&gt;M&lt;/b&gt; + c&lt;sub&gt;K&lt;/sub&gt;*&lt;b&gt;K&lt;/b&gt;. This makes it possible to strongly improve convergence in dynamics with implicit time scheme by imposing a cut-off frequency inversely proportional to the value of c&lt;sub&gt;K&lt;/sub&gt; (at the cost of a light distortion of all the eigen frequencies of the system).&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;This parameter c&lt;sub&gt;K&lt;/sub&gt; allows the shifting of the mass matrix with the stiffness matrix multiplied by c&lt;sub&gt;K&lt;/sub&gt;: &lt;b&gt;M&lt;/b&gt;&lt;sup&gt;&#39;&lt;/sup&gt;&#x3D;&lt;b&gt;M&lt;/b&gt; + c&lt;sub&gt;K&lt;/sub&gt;*&lt;b&gt;K&lt;/b&gt;. This makes it possible to strongly improve convergence in dynamics with implicit time scheme by imposing a cut-off frequency inversely proportional to the value of c&lt;sub&gt;K&lt;/sub&gt; (at the cost of a light distortion of all the eigen frequencies of the system).&lt;/p&gt;</value>
        [DataMember(Name="massMatrixShift", EmitDefaultValue=false)]
        public decimal? MassMatrixShift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImplicitTimeIntegrationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SchemeFormulation: ").Append(SchemeFormulation).Append("\n");
            sb.Append("  MassMatrixShift: ").Append(MassMatrixShift).Append("\n");
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
            return this.Equals(input as ImplicitTimeIntegrationType);
        }

        /// <summary>
        /// Returns true if ImplicitTimeIntegrationType instances are equal
        /// </summary>
        /// <param name="input">Instance of ImplicitTimeIntegrationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImplicitTimeIntegrationType input)
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
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.SchemeFormulation == input.SchemeFormulation ||
                    this.SchemeFormulation.Equals(input.SchemeFormulation)
                ) && 
                (
                    this.MassMatrixShift == input.MassMatrixShift ||
                    (this.MassMatrixShift != null &&
                    this.MassMatrixShift.Equals(input.MassMatrixShift))
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
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                hashCode = hashCode * 59 + this.SchemeFormulation.GetHashCode();
                if (this.MassMatrixShift != null)
                    hashCode = hashCode * 59 + this.MassMatrixShift.GetHashCode();
                return hashCode;
            }
        }

    }

}
