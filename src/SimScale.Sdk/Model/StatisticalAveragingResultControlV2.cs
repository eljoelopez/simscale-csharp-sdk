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
    /// StatisticalAveragingResultControlV2
    /// </summary>
    [DataContract]
    public partial class StatisticalAveragingResultControlV2 : IEquatable<StatisticalAveragingResultControlV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalAveragingResultControlV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatisticalAveragingResultControlV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalAveragingResultControlV2" /> class.
        /// </summary>
        /// <param name="type">Schema name: StatisticalAveragingResultControlV2 (required) (default to &quot;STATISTICAL_AVERAGING_V2&quot;).</param>
        /// <param name="fractionFromEnd">It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation. (default to 0.2M).</param>
        /// <param name="samplingInterval">samplingInterval.</param>
        /// <param name="exportFluid">When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported (default to true).</param>
        /// <param name="exportSurface">When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported (default to false).</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public StatisticalAveragingResultControlV2(string type = "STATISTICAL_AVERAGING_V2", decimal? fractionFromEnd = default(decimal?), OneOfStatisticalAveragingResultControlV2SamplingInterval samplingInterval = default(OneOfStatisticalAveragingResultControlV2SamplingInterval), bool? exportFluid = default(bool?), bool? exportSurface = default(bool?), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for StatisticalAveragingResultControlV2 and cannot be null");
            this.FractionFromEnd = fractionFromEnd;
            this.SamplingInterval = samplingInterval;
            this.ExportFluid = exportFluid;
            this.ExportSurface = exportSurface;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Schema name: StatisticalAveragingResultControlV2
        /// </summary>
        /// <value>Schema name: StatisticalAveragingResultControlV2</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation.
        /// </summary>
        /// <value>It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation.</value>
        [DataMember(Name="fractionFromEnd", EmitDefaultValue=false)]
        public decimal? FractionFromEnd { get; set; }

        /// <summary>
        /// Gets or Sets SamplingInterval
        /// </summary>
        [DataMember(Name="samplingInterval", EmitDefaultValue=false)]
        public OneOfStatisticalAveragingResultControlV2SamplingInterval SamplingInterval { get; set; }

        /// <summary>
        /// When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported
        /// </summary>
        /// <value>When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported</value>
        [DataMember(Name="exportFluid", EmitDefaultValue=false)]
        public bool? ExportFluid { get; set; }

        /// <summary>
        /// When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported
        /// </summary>
        /// <value>When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported</value>
        [DataMember(Name="exportSurface", EmitDefaultValue=false)]
        public bool? ExportSurface { get; set; }

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
            sb.Append("class StatisticalAveragingResultControlV2 {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FractionFromEnd: ").Append(FractionFromEnd).Append("\n");
            sb.Append("  SamplingInterval: ").Append(SamplingInterval).Append("\n");
            sb.Append("  ExportFluid: ").Append(ExportFluid).Append("\n");
            sb.Append("  ExportSurface: ").Append(ExportSurface).Append("\n");
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
            return this.Equals(input as StatisticalAveragingResultControlV2);
        }

        /// <summary>
        /// Returns true if StatisticalAveragingResultControlV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticalAveragingResultControlV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticalAveragingResultControlV2 input)
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
                    this.FractionFromEnd == input.FractionFromEnd ||
                    (this.FractionFromEnd != null &&
                    this.FractionFromEnd.Equals(input.FractionFromEnd))
                ) && 
                (
                    this.SamplingInterval == input.SamplingInterval ||
                    (this.SamplingInterval != null &&
                    this.SamplingInterval.Equals(input.SamplingInterval))
                ) && 
                (
                    this.ExportFluid == input.ExportFluid ||
                    (this.ExportFluid != null &&
                    this.ExportFluid.Equals(input.ExportFluid))
                ) && 
                (
                    this.ExportSurface == input.ExportSurface ||
                    (this.ExportSurface != null &&
                    this.ExportSurface.Equals(input.ExportSurface))
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
                if (this.FractionFromEnd != null)
                    hashCode = hashCode * 59 + this.FractionFromEnd.GetHashCode();
                if (this.SamplingInterval != null)
                    hashCode = hashCode * 59 + this.SamplingInterval.GetHashCode();
                if (this.ExportFluid != null)
                    hashCode = hashCode * 59 + this.ExportFluid.GetHashCode();
                if (this.ExportSurface != null)
                    hashCode = hashCode * 59 + this.ExportSurface.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
