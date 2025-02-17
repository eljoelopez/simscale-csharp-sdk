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
    /// AdvancedSimmetrixSolidSettings
    /// </summary>
    [DataContract]
    public partial class AdvancedSimmetrixSolidSettings : IEquatable<AdvancedSimmetrixSolidSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSimmetrixSolidSettings" /> class.
        /// </summary>
        /// <param name="smallFeatureTolerance">smallFeatureTolerance.</param>
        /// <param name="gapElements">&lt;p&gt;Define a target number of elements across the thickness of thin gaps. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/standard/#gap-refinement-factor&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-gap-elements.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example of gap refinements applied with a target of 4 elements across the thickness&lt;/p&gt; (default to 0M).</param>
        /// <param name="globalGradationRate">&lt;p&gt;Adjust the transition from small to large cells. This value is the ratio between the size of two adjacent cells. The allowed range is 1.0 - 3.0. 1.0 would produce a uniform mesh with the smallest size everywhere. This is generally not recommended, as it may produce very large meshes.&lt;/p&gt; (default to 1.22M).</param>
        public AdvancedSimmetrixSolidSettings(DimensionalLength smallFeatureTolerance = default(DimensionalLength), decimal? gapElements = default(decimal?), decimal? globalGradationRate = default(decimal?))
        {
            this.SmallFeatureTolerance = smallFeatureTolerance;
            this.GapElements = gapElements;
            this.GlobalGradationRate = globalGradationRate;
        }
        
        /// <summary>
        /// Gets or Sets SmallFeatureTolerance
        /// </summary>
        [DataMember(Name="smallFeatureTolerance", EmitDefaultValue=false)]
        public DimensionalLength SmallFeatureTolerance { get; set; }

        /// <summary>
        /// &lt;p&gt;Define a target number of elements across the thickness of thin gaps. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/standard/#gap-refinement-factor&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-gap-elements.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example of gap refinements applied with a target of 4 elements across the thickness&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define a target number of elements across the thickness of thin gaps. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/standard/#gap-refinement-factor&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-gap-elements.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example of gap refinements applied with a target of 4 elements across the thickness&lt;/p&gt;</value>
        [DataMember(Name="gapElements", EmitDefaultValue=false)]
        public decimal? GapElements { get; set; }

        /// <summary>
        /// &lt;p&gt;Adjust the transition from small to large cells. This value is the ratio between the size of two adjacent cells. The allowed range is 1.0 - 3.0. 1.0 would produce a uniform mesh with the smallest size everywhere. This is generally not recommended, as it may produce very large meshes.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Adjust the transition from small to large cells. This value is the ratio between the size of two adjacent cells. The allowed range is 1.0 - 3.0. 1.0 would produce a uniform mesh with the smallest size everywhere. This is generally not recommended, as it may produce very large meshes.&lt;/p&gt;</value>
        [DataMember(Name="globalGradationRate", EmitDefaultValue=false)]
        public decimal? GlobalGradationRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSimmetrixSolidSettings {\n");
            sb.Append("  SmallFeatureTolerance: ").Append(SmallFeatureTolerance).Append("\n");
            sb.Append("  GapElements: ").Append(GapElements).Append("\n");
            sb.Append("  GlobalGradationRate: ").Append(GlobalGradationRate).Append("\n");
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
            return this.Equals(input as AdvancedSimmetrixSolidSettings);
        }

        /// <summary>
        /// Returns true if AdvancedSimmetrixSolidSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSimmetrixSolidSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSimmetrixSolidSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmallFeatureTolerance == input.SmallFeatureTolerance ||
                    (this.SmallFeatureTolerance != null &&
                    this.SmallFeatureTolerance.Equals(input.SmallFeatureTolerance))
                ) && 
                (
                    this.GapElements == input.GapElements ||
                    (this.GapElements != null &&
                    this.GapElements.Equals(input.GapElements))
                ) && 
                (
                    this.GlobalGradationRate == input.GlobalGradationRate ||
                    (this.GlobalGradationRate != null &&
                    this.GlobalGradationRate.Equals(input.GlobalGradationRate))
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
                if (this.SmallFeatureTolerance != null)
                    hashCode = hashCode * 59 + this.SmallFeatureTolerance.GetHashCode();
                if (this.GapElements != null)
                    hashCode = hashCode * 59 + this.GapElements.GetHashCode();
                if (this.GlobalGradationRate != null)
                    hashCode = hashCode * 59 + this.GlobalGradationRate.GetHashCode();
                return hashCode;
            }
        }

    }

}
