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
    /// &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#layers-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;Inflated boundary layers&lt;/b&gt;&lt;/a&gt; are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.
    /// </summary>
    [DataContract]
    public partial class LayerAdditionHexDominantSnappy : OneOfHexDominantSnappyRefinements, IEquatable<LayerAdditionHexDominantSnappy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerAdditionHexDominantSnappy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LayerAdditionHexDominantSnappy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerAdditionHexDominantSnappy" /> class.
        /// </summary>
        /// <param name="type">&lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#layers-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;Inflated boundary layers&lt;/b&gt;&lt;/a&gt; are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.  Schema name: LayerAdditionHexDominantSnappy (required) (default to &quot;LAYER_ADDITION_HEX_DOMINANT_SNAPPY&quot;).</param>
        /// <param name="name">name (default to &quot;Inflate boundary layer&quot;).</param>
        /// <param name="layers">The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created. (default to 5).</param>
        /// <param name="expansionRatio">&lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt; (default to 1.3M).</param>
        /// <param name="minThickness">Specifies the &lt;b&gt;overall minimum thickness of all layers combined&lt;/b&gt;. In case the overall thickness falls below this minimum thickness, no layers will be added for the affected areas. (default to 0M).</param>
        /// <param name="firstLayerThickness">Specifies the height (thickness) of the &lt;b&gt;first layer&lt;/b&gt; that is closest to the surface. The first layer thickness is specified &lt;b&gt;relative&lt;/b&gt; to the neighboring volume cell size after refinements. (default to 0.055M).</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public LayerAdditionHexDominantSnappy(string type = "LAYER_ADDITION_HEX_DOMINANT_SNAPPY", string name = default(string), int? layers = default(int?), decimal? expansionRatio = default(decimal?), decimal? minThickness = default(decimal?), decimal? firstLayerThickness = default(decimal?), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for LayerAdditionHexDominantSnappy and cannot be null");
            this.Name = name;
            this.Layers = layers;
            this.ExpansionRatio = expansionRatio;
            this.MinThickness = minThickness;
            this.FirstLayerThickness = firstLayerThickness;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#layers-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;Inflated boundary layers&lt;/b&gt;&lt;/a&gt; are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.  Schema name: LayerAdditionHexDominantSnappy
        /// </summary>
        /// <value>&lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#layers-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;Inflated boundary layers&lt;/b&gt;&lt;/a&gt; are used to resolve the boundary layer near walls (no-slip) which are in contact with the fluid. Using boundary layers is generally recommended for turbulent simulations.  Schema name: LayerAdditionHexDominantSnappy</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created.
        /// </summary>
        /// <value>The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created.</value>
        [DataMember(Name="layers", EmitDefaultValue=false)]
        public int? Layers { get; set; }

        /// <summary>
        /// &lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt;</value>
        [DataMember(Name="expansionRatio", EmitDefaultValue=false)]
        public decimal? ExpansionRatio { get; set; }

        /// <summary>
        /// Specifies the &lt;b&gt;overall minimum thickness of all layers combined&lt;/b&gt;. In case the overall thickness falls below this minimum thickness, no layers will be added for the affected areas.
        /// </summary>
        /// <value>Specifies the &lt;b&gt;overall minimum thickness of all layers combined&lt;/b&gt;. In case the overall thickness falls below this minimum thickness, no layers will be added for the affected areas.</value>
        [DataMember(Name="minThickness", EmitDefaultValue=false)]
        public decimal? MinThickness { get; set; }

        /// <summary>
        /// Specifies the height (thickness) of the &lt;b&gt;first layer&lt;/b&gt; that is closest to the surface. The first layer thickness is specified &lt;b&gt;relative&lt;/b&gt; to the neighboring volume cell size after refinements.
        /// </summary>
        /// <value>Specifies the height (thickness) of the &lt;b&gt;first layer&lt;/b&gt; that is closest to the surface. The first layer thickness is specified &lt;b&gt;relative&lt;/b&gt; to the neighboring volume cell size after refinements.</value>
        [DataMember(Name="firstLayerThickness", EmitDefaultValue=false)]
        public decimal? FirstLayerThickness { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerAdditionHexDominantSnappy {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            sb.Append("  ExpansionRatio: ").Append(ExpansionRatio).Append("\n");
            sb.Append("  MinThickness: ").Append(MinThickness).Append("\n");
            sb.Append("  FirstLayerThickness: ").Append(FirstLayerThickness).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as LayerAdditionHexDominantSnappy);
        }

        /// <summary>
        /// Returns true if LayerAdditionHexDominantSnappy instances are equal
        /// </summary>
        /// <param name="input">Instance of LayerAdditionHexDominantSnappy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayerAdditionHexDominantSnappy input)
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
                    this.Layers == input.Layers ||
                    (this.Layers != null &&
                    this.Layers.Equals(input.Layers))
                ) && 
                (
                    this.ExpansionRatio == input.ExpansionRatio ||
                    (this.ExpansionRatio != null &&
                    this.ExpansionRatio.Equals(input.ExpansionRatio))
                ) && 
                (
                    this.MinThickness == input.MinThickness ||
                    (this.MinThickness != null &&
                    this.MinThickness.Equals(input.MinThickness))
                ) && 
                (
                    this.FirstLayerThickness == input.FirstLayerThickness ||
                    (this.FirstLayerThickness != null &&
                    this.FirstLayerThickness.Equals(input.FirstLayerThickness))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
                if (this.ExpansionRatio != null)
                    hashCode = hashCode * 59 + this.ExpansionRatio.GetHashCode();
                if (this.MinThickness != null)
                    hashCode = hashCode * 59 + this.MinThickness.GetHashCode();
                if (this.FirstLayerThickness != null)
                    hashCode = hashCode * 59 + this.FirstLayerThickness.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
