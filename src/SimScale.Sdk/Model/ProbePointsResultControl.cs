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
    /// ProbePointsResultControl
    /// </summary>
    [DataContract]
    public partial class ProbePointsResultControl : IEquatable<ProbePointsResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProbePointsResultControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProbePointsResultControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProbePointsResultControl" /> class.
        /// </summary>
        /// <param name="type">Schema name: ProbePointsResultControl (required) (default to &quot;PROBE_POINTS&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="writeControl">writeControl.</param>
        /// <param name="fractionFromEnd">It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation. (default to 0.2M).</param>
        /// <param name="exportStatistics">&lt;p&gt;When this switch is active, statistical data for the selected probe points will be exported:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;Minimum (&lt;strong&gt;MIN&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Maximum (&lt;strong&gt;MAX&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute minimum (&lt;strong&gt;MIN (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute maximum (&lt;strong&gt;MAX (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Average (&lt;strong&gt;AVG&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Standard deviation (&lt;strong&gt;STDDEV&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Root mean square (&lt;strong&gt;RMS (fluctuation)&lt;/strong&gt;)&lt;/li&gt;&lt;/ul&gt; (default to true).</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        /// <param name="probeLocations">probeLocations.</param>
        public ProbePointsResultControl(string type = "PROBE_POINTS", string name = default(string), OneOfProbePointsResultControlWriteControl writeControl = default(OneOfProbePointsResultControlWriteControl), decimal? fractionFromEnd = default(decimal?), bool? exportStatistics = default(bool?), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>), TableDefinedProbeLocations probeLocations = default(TableDefinedProbeLocations))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ProbePointsResultControl and cannot be null");
            this.Name = name;
            this.WriteControl = writeControl;
            this.FractionFromEnd = fractionFromEnd;
            this.ExportStatistics = exportStatistics;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
            this.ProbeLocations = probeLocations;
        }
        
        /// <summary>
        /// Schema name: ProbePointsResultControl
        /// </summary>
        /// <value>Schema name: ProbePointsResultControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets WriteControl
        /// </summary>
        [DataMember(Name="writeControl", EmitDefaultValue=false)]
        public OneOfProbePointsResultControlWriteControl WriteControl { get; set; }

        /// <summary>
        /// It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation.
        /// </summary>
        /// <value>It defines the point in simulation where the result output data extraction starts. For instance, &lt;i&gt;Fraction from end&lt;/i&gt; of 1 (100%) extracts all data from the beginning of the simulation while default 0.2 extracts 20% data from the end of the simulation.</value>
        [DataMember(Name="fractionFromEnd", EmitDefaultValue=false)]
        public decimal? FractionFromEnd { get; set; }

        /// <summary>
        /// &lt;p&gt;When this switch is active, statistical data for the selected probe points will be exported:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;Minimum (&lt;strong&gt;MIN&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Maximum (&lt;strong&gt;MAX&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute minimum (&lt;strong&gt;MIN (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute maximum (&lt;strong&gt;MAX (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Average (&lt;strong&gt;AVG&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Standard deviation (&lt;strong&gt;STDDEV&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Root mean square (&lt;strong&gt;RMS (fluctuation)&lt;/strong&gt;)&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>&lt;p&gt;When this switch is active, statistical data for the selected probe points will be exported:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;Minimum (&lt;strong&gt;MIN&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Maximum (&lt;strong&gt;MAX&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute minimum (&lt;strong&gt;MIN (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Absolute maximum (&lt;strong&gt;MAX (Abs)&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Average (&lt;strong&gt;AVG&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Standard deviation (&lt;strong&gt;STDDEV&lt;/strong&gt;)&lt;/li&gt;&lt;li&gt;Root mean square (&lt;strong&gt;RMS (fluctuation)&lt;/strong&gt;)&lt;/li&gt;&lt;/ul&gt;</value>
        [DataMember(Name="exportStatistics", EmitDefaultValue=false)]
        public bool? ExportStatistics { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Gets or Sets ProbeLocations
        /// </summary>
        [DataMember(Name="probeLocations", EmitDefaultValue=false)]
        public TableDefinedProbeLocations ProbeLocations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProbePointsResultControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WriteControl: ").Append(WriteControl).Append("\n");
            sb.Append("  FractionFromEnd: ").Append(FractionFromEnd).Append("\n");
            sb.Append("  ExportStatistics: ").Append(ExportStatistics).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
            sb.Append("  ProbeLocations: ").Append(ProbeLocations).Append("\n");
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
            return this.Equals(input as ProbePointsResultControl);
        }

        /// <summary>
        /// Returns true if ProbePointsResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of ProbePointsResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProbePointsResultControl input)
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
                    this.WriteControl == input.WriteControl ||
                    (this.WriteControl != null &&
                    this.WriteControl.Equals(input.WriteControl))
                ) && 
                (
                    this.FractionFromEnd == input.FractionFromEnd ||
                    (this.FractionFromEnd != null &&
                    this.FractionFromEnd.Equals(input.FractionFromEnd))
                ) && 
                (
                    this.ExportStatistics == input.ExportStatistics ||
                    (this.ExportStatistics != null &&
                    this.ExportStatistics.Equals(input.ExportStatistics))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
                ) && 
                (
                    this.ProbeLocations == input.ProbeLocations ||
                    (this.ProbeLocations != null &&
                    this.ProbeLocations.Equals(input.ProbeLocations))
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
                if (this.WriteControl != null)
                    hashCode = hashCode * 59 + this.WriteControl.GetHashCode();
                if (this.FractionFromEnd != null)
                    hashCode = hashCode * 59 + this.FractionFromEnd.GetHashCode();
                if (this.ExportStatistics != null)
                    hashCode = hashCode * 59 + this.ExportStatistics.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                if (this.ProbeLocations != null)
                    hashCode = hashCode * 59 + this.ProbeLocations.GetHashCode();
                return hashCode;
            }
        }

    }

}
