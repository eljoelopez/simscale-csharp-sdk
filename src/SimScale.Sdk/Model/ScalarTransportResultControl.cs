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
    /// ScalarTransportResultControl
    /// </summary>
    [DataContract]
    public partial class ScalarTransportResultControl : IEquatable<ScalarTransportResultControl>
    {
        /// <summary>
        /// Defines VolumeMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VolumeModeEnum
        {
            /// <summary>
            /// Enum SPECIFIC for value: SPECIFIC
            /// </summary>
            [EnumMember(Value = "SPECIFIC")]
            SPECIFIC = 1,

            /// <summary>
            /// Enum ABSOLUTE for value: ABSOLUTE
            /// </summary>
            [EnumMember(Value = "ABSOLUTE")]
            ABSOLUTE = 2

        }

        /// <summary>
        /// Gets or Sets VolumeMode
        /// </summary>
        [DataMember(Name="volumeMode", EmitDefaultValue=false)]
        public VolumeModeEnum? VolumeMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarTransportResultControl" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="diffusionCoefficient">diffusionCoefficient (default to 0M).</param>
        /// <param name="volumeMode">volumeMode (default to VolumeModeEnum.SPECIFIC).</param>
        /// <param name="su">su (default to 1M).</param>
        /// <param name="sp">sp (default to 0M).</param>
        /// <param name="writeControl">writeControl.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public ScalarTransportResultControl(string name = default(string), decimal? diffusionCoefficient = default(decimal?), VolumeModeEnum? volumeMode = default(VolumeModeEnum?), decimal? su = default(decimal?), decimal? sp = default(decimal?), OneOfScalarTransportResultControlWriteControl writeControl = default(OneOfScalarTransportResultControlWriteControl), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            this.Name = name;
            this.DiffusionCoefficient = diffusionCoefficient;
            this.VolumeMode = volumeMode;
            this.Su = su;
            this.Sp = sp;
            this.WriteControl = writeControl;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DiffusionCoefficient
        /// </summary>
        [DataMember(Name="diffusionCoefficient", EmitDefaultValue=false)]
        public decimal? DiffusionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets Su
        /// </summary>
        [DataMember(Name="su", EmitDefaultValue=false)]
        public decimal? Su { get; set; }

        /// <summary>
        /// Gets or Sets Sp
        /// </summary>
        [DataMember(Name="sp", EmitDefaultValue=false)]
        public decimal? Sp { get; set; }

        /// <summary>
        /// Gets or Sets WriteControl
        /// </summary>
        [DataMember(Name="writeControl", EmitDefaultValue=false)]
        public OneOfScalarTransportResultControlWriteControl WriteControl { get; set; }

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
            sb.Append("class ScalarTransportResultControl {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DiffusionCoefficient: ").Append(DiffusionCoefficient).Append("\n");
            sb.Append("  VolumeMode: ").Append(VolumeMode).Append("\n");
            sb.Append("  Su: ").Append(Su).Append("\n");
            sb.Append("  Sp: ").Append(Sp).Append("\n");
            sb.Append("  WriteControl: ").Append(WriteControl).Append("\n");
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
            return this.Equals(input as ScalarTransportResultControl);
        }

        /// <summary>
        /// Returns true if ScalarTransportResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of ScalarTransportResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScalarTransportResultControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DiffusionCoefficient == input.DiffusionCoefficient ||
                    (this.DiffusionCoefficient != null &&
                    this.DiffusionCoefficient.Equals(input.DiffusionCoefficient))
                ) && 
                (
                    this.VolumeMode == input.VolumeMode ||
                    this.VolumeMode.Equals(input.VolumeMode)
                ) && 
                (
                    this.Su == input.Su ||
                    (this.Su != null &&
                    this.Su.Equals(input.Su))
                ) && 
                (
                    this.Sp == input.Sp ||
                    (this.Sp != null &&
                    this.Sp.Equals(input.Sp))
                ) && 
                (
                    this.WriteControl == input.WriteControl ||
                    (this.WriteControl != null &&
                    this.WriteControl.Equals(input.WriteControl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DiffusionCoefficient != null)
                    hashCode = hashCode * 59 + this.DiffusionCoefficient.GetHashCode();
                hashCode = hashCode * 59 + this.VolumeMode.GetHashCode();
                if (this.Su != null)
                    hashCode = hashCode * 59 + this.Su.GetHashCode();
                if (this.Sp != null)
                    hashCode = hashCode * 59 + this.Sp.GetHashCode();
                if (this.WriteControl != null)
                    hashCode = hashCode * 59 + this.WriteControl.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
