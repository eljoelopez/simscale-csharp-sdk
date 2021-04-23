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
    /// This boundary condition is suitable for inlet and open boundaries where the value of pressure is known. For Incompressible and Passive Scalar Transport analysis the specific Pressure i.e. Pressure/Density is used.
    /// </summary>
    [DataContract]
    public partial class PressureInletBC : OneOfCompressibleBoundaryConditions, OneOfConjugateHeatTransferBoundaryConditions, OneOfConvectiveHeatTransferBoundaryConditions, OneOfIncompressibleBoundaryConditions, OneOfMultiphaseBoundaryConditions, OneOfSimericsAnalysisBoundaryConditions, IEquatable<PressureInletBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureInletBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PressureInletBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureInletBC" /> class.
        /// </summary>
        /// <param name="type">This boundary condition is suitable for inlet and open boundaries where the value of pressure is known. For Incompressible and Passive Scalar Transport analysis the specific Pressure i.e. Pressure/Density is used.  Schema name: PressureInletBC (required) (default to &quot;PRESSURE_INLET_V31&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="pressure">pressure.</param>
        /// <param name="pressureRgh">pressureRgh.</param>
        /// <param name="gaugePressure">gaugePressure.</param>
        /// <param name="gaugePressureRgh">gaugePressureRgh.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="passiveScalars">Please choose a boundary condition for passive scalar (T)..</param>
        /// <param name="phaseFraction">phaseFraction.</param>
        /// <param name="netRadiativeHeatFlux">netRadiativeHeatFlux.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public PressureInletBC(string type = "PRESSURE_INLET_V31", string name = default(string), TotalPBC pressure = default(TotalPBC), TotalPBC pressureRgh = default(TotalPBC), OneOfPressureInletBCGaugePressure gaugePressure = default(OneOfPressureInletBCGaugePressure), TotalPBC gaugePressureRgh = default(TotalPBC), OneOfPressureInletBCTemperature temperature = default(OneOfPressureInletBCTemperature), List<FixedValuePSBC> passiveScalars = default(List<FixedValuePSBC>), FixedValuePFBC phaseFraction = default(FixedValuePFBC), OneOfPressureInletBCNetRadiativeHeatFlux netRadiativeHeatFlux = default(OneOfPressureInletBCNetRadiativeHeatFlux), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PressureInletBC and cannot be null");
            this.Name = name;
            this.Pressure = pressure;
            this.PressureRgh = pressureRgh;
            this.GaugePressure = gaugePressure;
            this.GaugePressureRgh = gaugePressureRgh;
            this.Temperature = temperature;
            this.PassiveScalars = passiveScalars;
            this.PhaseFraction = phaseFraction;
            this.NetRadiativeHeatFlux = netRadiativeHeatFlux;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// This boundary condition is suitable for inlet and open boundaries where the value of pressure is known. For Incompressible and Passive Scalar Transport analysis the specific Pressure i.e. Pressure/Density is used.  Schema name: PressureInletBC
        /// </summary>
        /// <value>This boundary condition is suitable for inlet and open boundaries where the value of pressure is known. For Incompressible and Passive Scalar Transport analysis the specific Pressure i.e. Pressure/Density is used.  Schema name: PressureInletBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Pressure
        /// </summary>
        [DataMember(Name="pressure", EmitDefaultValue=false)]
        public TotalPBC Pressure { get; set; }

        /// <summary>
        /// Gets or Sets PressureRgh
        /// </summary>
        [DataMember(Name="pressureRgh", EmitDefaultValue=false)]
        public TotalPBC PressureRgh { get; set; }

        /// <summary>
        /// Gets or Sets GaugePressure
        /// </summary>
        [DataMember(Name="gaugePressure", EmitDefaultValue=false)]
        public OneOfPressureInletBCGaugePressure GaugePressure { get; set; }

        /// <summary>
        /// Gets or Sets GaugePressureRgh
        /// </summary>
        [DataMember(Name="gaugePressureRgh", EmitDefaultValue=false)]
        public TotalPBC GaugePressureRgh { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public OneOfPressureInletBCTemperature Temperature { get; set; }

        /// <summary>
        /// Please choose a boundary condition for passive scalar (T).
        /// </summary>
        /// <value>Please choose a boundary condition for passive scalar (T).</value>
        [DataMember(Name="passiveScalars", EmitDefaultValue=false)]
        public List<FixedValuePSBC> PassiveScalars { get; set; }

        /// <summary>
        /// Gets or Sets PhaseFraction
        /// </summary>
        [DataMember(Name="phaseFraction", EmitDefaultValue=false)]
        public FixedValuePFBC PhaseFraction { get; set; }

        /// <summary>
        /// Gets or Sets NetRadiativeHeatFlux
        /// </summary>
        [DataMember(Name="netRadiativeHeatFlux", EmitDefaultValue=false)]
        public OneOfPressureInletBCNetRadiativeHeatFlux NetRadiativeHeatFlux { get; set; }

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
            sb.Append("class PressureInletBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pressure: ").Append(Pressure).Append("\n");
            sb.Append("  PressureRgh: ").Append(PressureRgh).Append("\n");
            sb.Append("  GaugePressure: ").Append(GaugePressure).Append("\n");
            sb.Append("  GaugePressureRgh: ").Append(GaugePressureRgh).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  PassiveScalars: ").Append(PassiveScalars).Append("\n");
            sb.Append("  PhaseFraction: ").Append(PhaseFraction).Append("\n");
            sb.Append("  NetRadiativeHeatFlux: ").Append(NetRadiativeHeatFlux).Append("\n");
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
            return this.Equals(input as PressureInletBC);
        }

        /// <summary>
        /// Returns true if PressureInletBC instances are equal
        /// </summary>
        /// <param name="input">Instance of PressureInletBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PressureInletBC input)
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
                    this.Pressure == input.Pressure ||
                    (this.Pressure != null &&
                    this.Pressure.Equals(input.Pressure))
                ) && 
                (
                    this.PressureRgh == input.PressureRgh ||
                    (this.PressureRgh != null &&
                    this.PressureRgh.Equals(input.PressureRgh))
                ) && 
                (
                    this.GaugePressure == input.GaugePressure ||
                    (this.GaugePressure != null &&
                    this.GaugePressure.Equals(input.GaugePressure))
                ) && 
                (
                    this.GaugePressureRgh == input.GaugePressureRgh ||
                    (this.GaugePressureRgh != null &&
                    this.GaugePressureRgh.Equals(input.GaugePressureRgh))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.PassiveScalars == input.PassiveScalars ||
                    this.PassiveScalars != null &&
                    input.PassiveScalars != null &&
                    this.PassiveScalars.SequenceEqual(input.PassiveScalars)
                ) && 
                (
                    this.PhaseFraction == input.PhaseFraction ||
                    (this.PhaseFraction != null &&
                    this.PhaseFraction.Equals(input.PhaseFraction))
                ) && 
                (
                    this.NetRadiativeHeatFlux == input.NetRadiativeHeatFlux ||
                    (this.NetRadiativeHeatFlux != null &&
                    this.NetRadiativeHeatFlux.Equals(input.NetRadiativeHeatFlux))
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
                if (this.Pressure != null)
                    hashCode = hashCode * 59 + this.Pressure.GetHashCode();
                if (this.PressureRgh != null)
                    hashCode = hashCode * 59 + this.PressureRgh.GetHashCode();
                if (this.GaugePressure != null)
                    hashCode = hashCode * 59 + this.GaugePressure.GetHashCode();
                if (this.GaugePressureRgh != null)
                    hashCode = hashCode * 59 + this.GaugePressureRgh.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.PassiveScalars != null)
                    hashCode = hashCode * 59 + this.PassiveScalars.GetHashCode();
                if (this.PhaseFraction != null)
                    hashCode = hashCode * 59 + this.PhaseFraction.GetHashCode();
                if (this.NetRadiativeHeatFlux != null)
                    hashCode = hashCode * 59 + this.NetRadiativeHeatFlux.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
