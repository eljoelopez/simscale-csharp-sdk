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
    /// FluidResultControls
    /// </summary>
    [DataContract]
    public partial class FluidResultControls : IEquatable<FluidResultControls>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluidResultControls" /> class.
        /// </summary>
        /// <param name="forcesMoments">forcesMoments.</param>
        /// <param name="surfaceData">surfaceData.</param>
        /// <param name="scalarTransport">scalarTransport.</param>
        /// <param name="probePoints">probePoints.</param>
        /// <param name="fieldCalculations">fieldCalculations.</param>
        /// <param name="transientResultControl">transientResultControl.</param>
        /// <param name="statisticalAveragingResultControl">statisticalAveragingResultControl.</param>
        /// <param name="snapshotResultControl">snapshotResultControl.</param>
        public FluidResultControls(List<OneOfFluidResultControlsForcesMoments> forcesMoments = default(List<OneOfFluidResultControlsForcesMoments>), List<OneOfFluidResultControlsSurfaceData> surfaceData = default(List<OneOfFluidResultControlsSurfaceData>), List<ScalarTransportResultControl> scalarTransport = default(List<ScalarTransportResultControl>), List<ProbePointsResultControl> probePoints = default(List<ProbePointsResultControl>), List<OneOfFluidResultControlsFieldCalculations> fieldCalculations = default(List<OneOfFluidResultControlsFieldCalculations>), TransientResultControl transientResultControl = default(TransientResultControl), StatisticalAveragingResultControlV2 statisticalAveragingResultControl = default(StatisticalAveragingResultControlV2), SnapshotResultControl snapshotResultControl = default(SnapshotResultControl))
        {
            this.ForcesMoments = forcesMoments;
            this.SurfaceData = surfaceData;
            this.ScalarTransport = scalarTransport;
            this.ProbePoints = probePoints;
            this.FieldCalculations = fieldCalculations;
            this.TransientResultControl = transientResultControl;
            this.StatisticalAveragingResultControl = statisticalAveragingResultControl;
            this.SnapshotResultControl = snapshotResultControl;
        }
        
        /// <summary>
        /// Gets or Sets ForcesMoments
        /// </summary>
        [DataMember(Name="forcesMoments", EmitDefaultValue=false)]
        public List<OneOfFluidResultControlsForcesMoments> ForcesMoments { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceData
        /// </summary>
        [DataMember(Name="surfaceData", EmitDefaultValue=false)]
        public List<OneOfFluidResultControlsSurfaceData> SurfaceData { get; set; }

        /// <summary>
        /// Gets or Sets ScalarTransport
        /// </summary>
        [DataMember(Name="scalarTransport", EmitDefaultValue=false)]
        public List<ScalarTransportResultControl> ScalarTransport { get; set; }

        /// <summary>
        /// Gets or Sets ProbePoints
        /// </summary>
        [DataMember(Name="probePoints", EmitDefaultValue=false)]
        public List<ProbePointsResultControl> ProbePoints { get; set; }

        /// <summary>
        /// Gets or Sets FieldCalculations
        /// </summary>
        [DataMember(Name="fieldCalculations", EmitDefaultValue=false)]
        public List<OneOfFluidResultControlsFieldCalculations> FieldCalculations { get; set; }

        /// <summary>
        /// Gets or Sets TransientResultControl
        /// </summary>
        [DataMember(Name="transientResultControl", EmitDefaultValue=false)]
        public TransientResultControl TransientResultControl { get; set; }

        /// <summary>
        /// Gets or Sets StatisticalAveragingResultControl
        /// </summary>
        [DataMember(Name="statisticalAveragingResultControl", EmitDefaultValue=false)]
        public StatisticalAveragingResultControlV2 StatisticalAveragingResultControl { get; set; }

        /// <summary>
        /// Gets or Sets SnapshotResultControl
        /// </summary>
        [DataMember(Name="snapshotResultControl", EmitDefaultValue=false)]
        public SnapshotResultControl SnapshotResultControl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FluidResultControls {\n");
            sb.Append("  ForcesMoments: ").Append(ForcesMoments).Append("\n");
            sb.Append("  SurfaceData: ").Append(SurfaceData).Append("\n");
            sb.Append("  ScalarTransport: ").Append(ScalarTransport).Append("\n");
            sb.Append("  ProbePoints: ").Append(ProbePoints).Append("\n");
            sb.Append("  FieldCalculations: ").Append(FieldCalculations).Append("\n");
            sb.Append("  TransientResultControl: ").Append(TransientResultControl).Append("\n");
            sb.Append("  StatisticalAveragingResultControl: ").Append(StatisticalAveragingResultControl).Append("\n");
            sb.Append("  SnapshotResultControl: ").Append(SnapshotResultControl).Append("\n");
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
            return this.Equals(input as FluidResultControls);
        }

        /// <summary>
        /// Returns true if FluidResultControls instances are equal
        /// </summary>
        /// <param name="input">Instance of FluidResultControls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FluidResultControls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForcesMoments == input.ForcesMoments ||
                    this.ForcesMoments != null &&
                    input.ForcesMoments != null &&
                    this.ForcesMoments.SequenceEqual(input.ForcesMoments)
                ) && 
                (
                    this.SurfaceData == input.SurfaceData ||
                    this.SurfaceData != null &&
                    input.SurfaceData != null &&
                    this.SurfaceData.SequenceEqual(input.SurfaceData)
                ) && 
                (
                    this.ScalarTransport == input.ScalarTransport ||
                    this.ScalarTransport != null &&
                    input.ScalarTransport != null &&
                    this.ScalarTransport.SequenceEqual(input.ScalarTransport)
                ) && 
                (
                    this.ProbePoints == input.ProbePoints ||
                    this.ProbePoints != null &&
                    input.ProbePoints != null &&
                    this.ProbePoints.SequenceEqual(input.ProbePoints)
                ) && 
                (
                    this.FieldCalculations == input.FieldCalculations ||
                    this.FieldCalculations != null &&
                    input.FieldCalculations != null &&
                    this.FieldCalculations.SequenceEqual(input.FieldCalculations)
                ) && 
                (
                    this.TransientResultControl == input.TransientResultControl ||
                    (this.TransientResultControl != null &&
                    this.TransientResultControl.Equals(input.TransientResultControl))
                ) && 
                (
                    this.StatisticalAveragingResultControl == input.StatisticalAveragingResultControl ||
                    (this.StatisticalAveragingResultControl != null &&
                    this.StatisticalAveragingResultControl.Equals(input.StatisticalAveragingResultControl))
                ) && 
                (
                    this.SnapshotResultControl == input.SnapshotResultControl ||
                    (this.SnapshotResultControl != null &&
                    this.SnapshotResultControl.Equals(input.SnapshotResultControl))
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
                if (this.ForcesMoments != null)
                    hashCode = hashCode * 59 + this.ForcesMoments.GetHashCode();
                if (this.SurfaceData != null)
                    hashCode = hashCode * 59 + this.SurfaceData.GetHashCode();
                if (this.ScalarTransport != null)
                    hashCode = hashCode * 59 + this.ScalarTransport.GetHashCode();
                if (this.ProbePoints != null)
                    hashCode = hashCode * 59 + this.ProbePoints.GetHashCode();
                if (this.FieldCalculations != null)
                    hashCode = hashCode * 59 + this.FieldCalculations.GetHashCode();
                if (this.TransientResultControl != null)
                    hashCode = hashCode * 59 + this.TransientResultControl.GetHashCode();
                if (this.StatisticalAveragingResultControl != null)
                    hashCode = hashCode * 59 + this.StatisticalAveragingResultControl.GetHashCode();
                if (this.SnapshotResultControl != null)
                    hashCode = hashCode * 59 + this.SnapshotResultControl.GetHashCode();
                return hashCode;
            }
        }

    }

}
