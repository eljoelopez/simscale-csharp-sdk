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
    /// FrequencyAnalysis
    /// </summary>
    [DataContract]
    public partial class FrequencyAnalysis : Analysis, IEquatable<FrequencyAnalysis>
    {
        /// <summary>
        /// Defines MeshOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MeshOrderEnum
        {
            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            [EnumMember(Value = "FIRST")]
            FIRST = 1,

            /// <summary>
            /// Enum SECOND for value: SECOND
            /// </summary>
            [EnumMember(Value = "SECOND")]
            SECOND = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3

        }

        /// <summary>
        /// Gets or Sets MeshOrder
        /// </summary>
        [DataMember(Name="meshOrder", EmitDefaultValue=false)]
        public MeshOrderEnum? MeshOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyAnalysis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrequencyAnalysis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequencyAnalysis" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;FREQUENCY_ANALYSIS&quot;).</param>
        /// <param name="meshSpecId">meshSpecId.</param>
        /// <param name="connectionGroups">connectionGroups.</param>
        /// <param name="elementTechnology">elementTechnology.</param>
        /// <param name="model">model.</param>
        /// <param name="materials">materials.</param>
        /// <param name="initialConditions">initialConditions.</param>
        /// <param name="boundaryConditions">boundaryConditions.</param>
        /// <param name="numerics">numerics.</param>
        /// <param name="simulationControl">simulationControl.</param>
        /// <param name="resultControl">resultControl.</param>
        /// <param name="meshOrder">meshOrder (default to MeshOrderEnum.FIRST).</param>
        public FrequencyAnalysis(string type = "FREQUENCY_ANALYSIS", Guid? meshSpecId = default(Guid?), List<Contact> connectionGroups = default(List<Contact>), SolidElementTechnology elementTechnology = default(SolidElementTechnology), SolidModel model = default(SolidModel), List<SolidMaterial> materials = default(List<SolidMaterial>), SolidInitialConditions initialConditions = default(SolidInitialConditions), List<OneOfFrequencyAnalysisBoundaryConditions> boundaryConditions = default(List<OneOfFrequencyAnalysisBoundaryConditions>), SolidNumerics numerics = default(SolidNumerics), SolidSimulationControl simulationControl = default(SolidSimulationControl), SolidResultControl resultControl = default(SolidResultControl), MeshOrderEnum? meshOrder = default(MeshOrderEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FrequencyAnalysis and cannot be null");
            this.MeshSpecId = meshSpecId;
            this.ConnectionGroups = connectionGroups;
            this.ElementTechnology = elementTechnology;
            this.Model = model;
            this.Materials = materials;
            this.InitialConditions = initialConditions;
            this.BoundaryConditions = boundaryConditions;
            this.Numerics = numerics;
            this.SimulationControl = simulationControl;
            this.ResultControl = resultControl;
            this.MeshOrder = meshOrder;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MeshSpecId
        /// </summary>
        [DataMember(Name="meshSpecId", EmitDefaultValue=false)]
        public Guid? MeshSpecId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionGroups
        /// </summary>
        [DataMember(Name="connectionGroups", EmitDefaultValue=false)]
        public List<Contact> ConnectionGroups { get; set; }

        /// <summary>
        /// Gets or Sets ElementTechnology
        /// </summary>
        [DataMember(Name="elementTechnology", EmitDefaultValue=false)]
        public SolidElementTechnology ElementTechnology { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public SolidModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Materials
        /// </summary>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        public List<SolidMaterial> Materials { get; set; }

        /// <summary>
        /// Gets or Sets InitialConditions
        /// </summary>
        [DataMember(Name="initialConditions", EmitDefaultValue=false)]
        public SolidInitialConditions InitialConditions { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryConditions
        /// </summary>
        [DataMember(Name="boundaryConditions", EmitDefaultValue=false)]
        public List<OneOfFrequencyAnalysisBoundaryConditions> BoundaryConditions { get; set; }

        /// <summary>
        /// Gets or Sets Numerics
        /// </summary>
        [DataMember(Name="numerics", EmitDefaultValue=false)]
        public SolidNumerics Numerics { get; set; }

        /// <summary>
        /// Gets or Sets SimulationControl
        /// </summary>
        [DataMember(Name="simulationControl", EmitDefaultValue=false)]
        public SolidSimulationControl SimulationControl { get; set; }

        /// <summary>
        /// Gets or Sets ResultControl
        /// </summary>
        [DataMember(Name="resultControl", EmitDefaultValue=false)]
        public SolidResultControl ResultControl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrequencyAnalysis {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MeshSpecId: ").Append(MeshSpecId).Append("\n");
            sb.Append("  ConnectionGroups: ").Append(ConnectionGroups).Append("\n");
            sb.Append("  ElementTechnology: ").Append(ElementTechnology).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  InitialConditions: ").Append(InitialConditions).Append("\n");
            sb.Append("  BoundaryConditions: ").Append(BoundaryConditions).Append("\n");
            sb.Append("  Numerics: ").Append(Numerics).Append("\n");
            sb.Append("  SimulationControl: ").Append(SimulationControl).Append("\n");
            sb.Append("  ResultControl: ").Append(ResultControl).Append("\n");
            sb.Append("  MeshOrder: ").Append(MeshOrder).Append("\n");
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
            return this.Equals(input as FrequencyAnalysis);
        }

        /// <summary>
        /// Returns true if FrequencyAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of FrequencyAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FrequencyAnalysis input)
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
                    this.MeshSpecId == input.MeshSpecId ||
                    (this.MeshSpecId != null &&
                    this.MeshSpecId.Equals(input.MeshSpecId))
                ) && 
                (
                    this.ConnectionGroups == input.ConnectionGroups ||
                    this.ConnectionGroups != null &&
                    input.ConnectionGroups != null &&
                    this.ConnectionGroups.SequenceEqual(input.ConnectionGroups)
                ) && 
                (
                    this.ElementTechnology == input.ElementTechnology ||
                    (this.ElementTechnology != null &&
                    this.ElementTechnology.Equals(input.ElementTechnology))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.InitialConditions == input.InitialConditions ||
                    (this.InitialConditions != null &&
                    this.InitialConditions.Equals(input.InitialConditions))
                ) && 
                (
                    this.BoundaryConditions == input.BoundaryConditions ||
                    this.BoundaryConditions != null &&
                    input.BoundaryConditions != null &&
                    this.BoundaryConditions.SequenceEqual(input.BoundaryConditions)
                ) && 
                (
                    this.Numerics == input.Numerics ||
                    (this.Numerics != null &&
                    this.Numerics.Equals(input.Numerics))
                ) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && 
                (
                    this.ResultControl == input.ResultControl ||
                    (this.ResultControl != null &&
                    this.ResultControl.Equals(input.ResultControl))
                ) && 
                (
                    this.MeshOrder == input.MeshOrder ||
                    this.MeshOrder.Equals(input.MeshOrder)
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
                if (this.MeshSpecId != null)
                    hashCode = hashCode * 59 + this.MeshSpecId.GetHashCode();
                if (this.ConnectionGroups != null)
                    hashCode = hashCode * 59 + this.ConnectionGroups.GetHashCode();
                if (this.ElementTechnology != null)
                    hashCode = hashCode * 59 + this.ElementTechnology.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
                if (this.InitialConditions != null)
                    hashCode = hashCode * 59 + this.InitialConditions.GetHashCode();
                if (this.BoundaryConditions != null)
                    hashCode = hashCode * 59 + this.BoundaryConditions.GetHashCode();
                if (this.Numerics != null)
                    hashCode = hashCode * 59 + this.Numerics.GetHashCode();
                if (this.SimulationControl != null)
                    hashCode = hashCode * 59 + this.SimulationControl.GetHashCode();
                if (this.ResultControl != null)
                    hashCode = hashCode * 59 + this.ResultControl.GetHashCode();
                hashCode = hashCode * 59 + this.MeshOrder.GetHashCode();
                return hashCode;
            }
        }

    }

}
