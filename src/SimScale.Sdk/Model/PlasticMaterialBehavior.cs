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
    public partial class PlasticMaterialBehavior : OneOfSolidMaterialMaterialBehavior, IEquatable<PlasticMaterialBehavior>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlasticMaterialBehavior" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlasticMaterialBehavior() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlasticMaterialBehavior" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: PlasticMaterialBehavior (required) (default to &quot;PLASTIC&quot;).</param>
        /// <param name="plasticHardening">plasticHardening.</param>
        /// <param name="creepFormulation">creepFormulation.</param>
        public PlasticMaterialBehavior(string type = "PLASTIC", IsotropicPlasticHardening plasticHardening = default(IsotropicPlasticHardening), OneOfPlasticMaterialBehaviorCreepFormulation creepFormulation = default(OneOfPlasticMaterialBehaviorCreepFormulation))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PlasticMaterialBehavior and cannot be null");
            this.PlasticHardening = plasticHardening;
            this.CreepFormulation = creepFormulation;
        }
        
        /// <summary>
        /// &lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: PlasticMaterialBehavior
        /// </summary>
        /// <value>&lt;p&gt;Choose the material behavior for your problem. &lt;/p&gt; &lt;br /&gt;&lt;br /&gt;Important remarks:&lt;br /&gt; &lt;ul&gt;&lt;li&gt;Choose &lt;b&gt;Linear elastic&lt;/b&gt; if the stress-strain relationship of your material is linear.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Elasto-plastic&lt;/b&gt; if the stress-strain relationship of your material is non-linear after some point e.g. yielding point.&lt;/li&gt;&lt;li&gt;Choose &lt;b&gt;Hyperelastic&lt;/b&gt; if your material responds elastically even at higher deformations.&lt;/li&gt;&lt;/ul&gt;   Schema name: PlasticMaterialBehavior</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PlasticHardening
        /// </summary>
        [DataMember(Name="plasticHardening", EmitDefaultValue=false)]
        public IsotropicPlasticHardening PlasticHardening { get; set; }

        /// <summary>
        /// Gets or Sets CreepFormulation
        /// </summary>
        [DataMember(Name="creepFormulation", EmitDefaultValue=false)]
        public OneOfPlasticMaterialBehaviorCreepFormulation CreepFormulation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlasticMaterialBehavior {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PlasticHardening: ").Append(PlasticHardening).Append("\n");
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
            return this.Equals(input as PlasticMaterialBehavior);
        }

        /// <summary>
        /// Returns true if PlasticMaterialBehavior instances are equal
        /// </summary>
        /// <param name="input">Instance of PlasticMaterialBehavior to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlasticMaterialBehavior input)
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
                    this.PlasticHardening == input.PlasticHardening ||
                    (this.PlasticHardening != null &&
                    this.PlasticHardening.Equals(input.PlasticHardening))
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
                if (this.PlasticHardening != null)
                    hashCode = hashCode * 59 + this.PlasticHardening.GetHashCode();
                if (this.CreepFormulation != null)
                    hashCode = hashCode * 59 + this.CreepFormulation.GetHashCode();
                return hashCode;
            }
        }

    }

}
