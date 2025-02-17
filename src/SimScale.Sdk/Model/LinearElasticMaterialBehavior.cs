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
    /// &lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt; 
    /// </summary>
    [DataContract]
    public partial class LinearElasticMaterialBehavior : OneOfSolidMaterialMaterialBehavior, IEquatable<LinearElasticMaterialBehavior>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearElasticMaterialBehavior" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinearElasticMaterialBehavior() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinearElasticMaterialBehavior" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: LinearElasticMaterialBehavior (required) (default to &quot;LINEAR_ELASTIC&quot;).</param>
        /// <param name="directionalDependency">directionalDependency.</param>
        /// <param name="damping">damping.</param>
        /// <param name="creepFormulation">creepFormulation.</param>
        public LinearElasticMaterialBehavior(string type = "LINEAR_ELASTIC", IsotropicDirectionalDependency directionalDependency = default(IsotropicDirectionalDependency), OneOfLinearElasticMaterialBehaviorDamping damping = default(OneOfLinearElasticMaterialBehaviorDamping), OneOfLinearElasticMaterialBehaviorCreepFormulation creepFormulation = default(OneOfLinearElasticMaterialBehaviorCreepFormulation))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for LinearElasticMaterialBehavior and cannot be null");
            this.DirectionalDependency = directionalDependency;
            this.Damping = damping;
            this.CreepFormulation = creepFormulation;
        }
        
        /// <summary>
        /// &lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: LinearElasticMaterialBehavior
        /// </summary>
        /// <value>&lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: LinearElasticMaterialBehavior</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DirectionalDependency
        /// </summary>
        [DataMember(Name="directionalDependency", EmitDefaultValue=false)]
        public IsotropicDirectionalDependency DirectionalDependency { get; set; }

        /// <summary>
        /// Gets or Sets Damping
        /// </summary>
        [DataMember(Name="damping", EmitDefaultValue=false)]
        public OneOfLinearElasticMaterialBehaviorDamping Damping { get; set; }

        /// <summary>
        /// Gets or Sets CreepFormulation
        /// </summary>
        [DataMember(Name="creepFormulation", EmitDefaultValue=false)]
        public OneOfLinearElasticMaterialBehaviorCreepFormulation CreepFormulation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinearElasticMaterialBehavior {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DirectionalDependency: ").Append(DirectionalDependency).Append("\n");
            sb.Append("  Damping: ").Append(Damping).Append("\n");
            sb.Append("  CreepFormulation: ").Append(CreepFormulation).Append("\n");
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
            return this.Equals(input as LinearElasticMaterialBehavior);
        }

        /// <summary>
        /// Returns true if LinearElasticMaterialBehavior instances are equal
        /// </summary>
        /// <param name="input">Instance of LinearElasticMaterialBehavior to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinearElasticMaterialBehavior input)
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
                    this.DirectionalDependency == input.DirectionalDependency ||
                    (this.DirectionalDependency != null &&
                    this.DirectionalDependency.Equals(input.DirectionalDependency))
                ) && 
                (
                    this.Damping == input.Damping ||
                    (this.Damping != null &&
                    this.Damping.Equals(input.Damping))
                ) && 
                (
                    this.CreepFormulation == input.CreepFormulation ||
                    (this.CreepFormulation != null &&
                    this.CreepFormulation.Equals(input.CreepFormulation))
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
                if (this.DirectionalDependency != null)
                    hashCode = hashCode * 59 + this.DirectionalDependency.GetHashCode();
                if (this.Damping != null)
                    hashCode = hashCode * 59 + this.Damping.GetHashCode();
                if (this.CreepFormulation != null)
                    hashCode = hashCode * 59 + this.CreepFormulation.GetHashCode();
                return hashCode;
            }
        }

    }

}
