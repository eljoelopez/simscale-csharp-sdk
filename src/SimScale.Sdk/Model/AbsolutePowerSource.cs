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
    /// &lt;i&gt;Power sources&lt;/i&gt; can be used to simulate heat generation from a volume. Two types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Absolute&lt;/b&gt;&lt;/li&gt;: Used when total power emitted by the assigned volume is known.&lt;li&gt;&lt;b&gt;Specific&lt;/b&gt;&lt;/li&gt;: Used when power density of the assigned volume is known. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/advanced-concepts/power-sources/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class AbsolutePowerSource : OneOfAdvancedConceptsPowerSources, IEquatable<AbsolutePowerSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsolutePowerSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbsolutePowerSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsolutePowerSource" /> class.
        /// </summary>
        /// <param name="type">&lt;i&gt;Power sources&lt;/i&gt; can be used to simulate heat generation from a volume. Two types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Absolute&lt;/b&gt;&lt;/li&gt;: Used when total power emitted by the assigned volume is known.&lt;li&gt;&lt;b&gt;Specific&lt;/b&gt;&lt;/li&gt;: Used when power density of the assigned volume is known. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/advanced-concepts/power-sources/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: AbsolutePowerSource (required) (default to &quot;ABSOLUTE_V23&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="heatFlux">heatFlux.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public AbsolutePowerSource(string type = "ABSOLUTE_V23", string name = default(string), DimensionalFunctionPower heatFlux = default(DimensionalFunctionPower), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AbsolutePowerSource and cannot be null");
            this.Name = name;
            this.HeatFlux = heatFlux;
            this.TopologicalReference = topologicalReference;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// &lt;i&gt;Power sources&lt;/i&gt; can be used to simulate heat generation from a volume. Two types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Absolute&lt;/b&gt;&lt;/li&gt;: Used when total power emitted by the assigned volume is known.&lt;li&gt;&lt;b&gt;Specific&lt;/b&gt;&lt;/li&gt;: Used when power density of the assigned volume is known. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/advanced-concepts/power-sources/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: AbsolutePowerSource
        /// </summary>
        /// <value>&lt;i&gt;Power sources&lt;/i&gt; can be used to simulate heat generation from a volume. Two types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Absolute&lt;/b&gt;&lt;/li&gt;: Used when total power emitted by the assigned volume is known.&lt;li&gt;&lt;b&gt;Specific&lt;/b&gt;&lt;/li&gt;: Used when power density of the assigned volume is known. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/advanced-concepts/power-sources/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: AbsolutePowerSource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets HeatFlux
        /// </summary>
        [DataMember(Name="heatFlux", EmitDefaultValue=false)]
        public DimensionalFunctionPower HeatFlux { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbsolutePowerSource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HeatFlux: ").Append(HeatFlux).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as AbsolutePowerSource);
        }

        /// <summary>
        /// Returns true if AbsolutePowerSource instances are equal
        /// </summary>
        /// <param name="input">Instance of AbsolutePowerSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbsolutePowerSource input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.HeatFlux == input.HeatFlux ||
                    (this.HeatFlux != null &&
                    this.HeatFlux.Equals(input.HeatFlux))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HeatFlux != null)
                    hashCode = hashCode * 59 + this.HeatFlux.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
