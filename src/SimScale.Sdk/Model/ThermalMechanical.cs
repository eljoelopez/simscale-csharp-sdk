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
    /// ThermalMechanical
    /// </summary>
    [DataContract]
    public partial class ThermalMechanical : Analysis, IEquatable<ThermalMechanical>
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
        /// Initializes a new instance of the <see cref="ThermalMechanical" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThermalMechanical() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThermalMechanical" /> class.
        /// </summary>
        /// <param name="type">Schema name: ThermalMechanical (required) (default to &quot;THERMAL_MECHANICAL&quot;).</param>
        /// <param name="timeDependency">timeDependency.</param>
        /// <param name="inertiaEffect">&lt;p&gt;Select if inertia effects should be considered in the analysis. If high loading accelerations or impacts are present then &lt;b&gt;dynamic&lt;/b&gt; is the right choice for this parameter. If the dynamic effects are negligible, &lt;b&gt;static&lt;/b&gt; should be selected.&lt;/p&gt; (default to &quot;STATIC&quot;).</param>
        /// <param name="nonLinearAnalysis">&lt;p&gt;Choose if your analysis should feature any kind of &lt;b&gt;nonlinearity&lt;/b&gt; like &lt;b&gt;physical contacts, nonlinear materials&lt;/b&gt; as hyperelasticity or plasticity or &lt;b&gt;large rotations&lt;/b&gt; and &lt;b&gt;large deformations, temperature dependant material properties&lt;/b&gt; or &lt;b&gt;temperature dependant boundary conditions&lt;/b&gt;. For a &lt;b&gt;linear analysis&lt;/b&gt; none of those nonlinearities are available.&lt;/p&gt; (default to false).</param>
        /// <param name="connectionGroups">connectionGroups.</param>
        /// <param name="elementTechnology">elementTechnology.</param>
        /// <param name="model">model.</param>
        /// <param name="materials">materials.</param>
        /// <param name="initialConditions">initialConditions.</param>
        /// <param name="boundaryConditions">boundaryConditions.</param>
        /// <param name="numerics">numerics.</param>
        /// <param name="simulationControl">simulationControl.</param>
        /// <param name="resultControl">resultControl.</param>
        /// <param name="meshOrder">meshOrder (default to MeshOrderEnum.NONE).</param>
        public ThermalMechanical(string type = "THERMAL_MECHANICAL", OneOfThermalMechanicalTimeDependency timeDependency = default(OneOfThermalMechanicalTimeDependency), string inertiaEffect = default(string), bool? nonLinearAnalysis = default(bool?), List<OneOfThermalMechanicalConnectionGroups> connectionGroups = default(List<OneOfThermalMechanicalConnectionGroups>), SolidElementTechnology elementTechnology = default(SolidElementTechnology), SolidModel model = default(SolidModel), List<SolidMaterial> materials = default(List<SolidMaterial>), SolidInitialConditions initialConditions = default(SolidInitialConditions), List<OneOfThermalMechanicalBoundaryConditions> boundaryConditions = default(List<OneOfThermalMechanicalBoundaryConditions>), SolidNumerics numerics = default(SolidNumerics), SolidSimulationControl simulationControl = default(SolidSimulationControl), SolidResultControl resultControl = default(SolidResultControl), MeshOrderEnum? meshOrder = default(MeshOrderEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ThermalMechanical and cannot be null");
            this.TimeDependency = timeDependency;
            this.InertiaEffect = inertiaEffect;
            this.NonLinearAnalysis = nonLinearAnalysis;
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
        /// Schema name: ThermalMechanical
        /// </summary>
        /// <value>Schema name: ThermalMechanical</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TimeDependency
        /// </summary>
        [DataMember(Name="timeDependency", EmitDefaultValue=false)]
        public OneOfThermalMechanicalTimeDependency TimeDependency { get; set; }

        /// <summary>
        /// &lt;p&gt;Select if inertia effects should be considered in the analysis. If high loading accelerations or impacts are present then &lt;b&gt;dynamic&lt;/b&gt; is the right choice for this parameter. If the dynamic effects are negligible, &lt;b&gt;static&lt;/b&gt; should be selected.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Select if inertia effects should be considered in the analysis. If high loading accelerations or impacts are present then &lt;b&gt;dynamic&lt;/b&gt; is the right choice for this parameter. If the dynamic effects are negligible, &lt;b&gt;static&lt;/b&gt; should be selected.&lt;/p&gt;</value>
        [DataMember(Name="inertiaEffect", EmitDefaultValue=false)]
        public string InertiaEffect { get; set; }

        /// <summary>
        /// &lt;p&gt;Choose if your analysis should feature any kind of &lt;b&gt;nonlinearity&lt;/b&gt; like &lt;b&gt;physical contacts, nonlinear materials&lt;/b&gt; as hyperelasticity or plasticity or &lt;b&gt;large rotations&lt;/b&gt; and &lt;b&gt;large deformations, temperature dependant material properties&lt;/b&gt; or &lt;b&gt;temperature dependant boundary conditions&lt;/b&gt;. For a &lt;b&gt;linear analysis&lt;/b&gt; none of those nonlinearities are available.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose if your analysis should feature any kind of &lt;b&gt;nonlinearity&lt;/b&gt; like &lt;b&gt;physical contacts, nonlinear materials&lt;/b&gt; as hyperelasticity or plasticity or &lt;b&gt;large rotations&lt;/b&gt; and &lt;b&gt;large deformations, temperature dependant material properties&lt;/b&gt; or &lt;b&gt;temperature dependant boundary conditions&lt;/b&gt;. For a &lt;b&gt;linear analysis&lt;/b&gt; none of those nonlinearities are available.&lt;/p&gt;</value>
        [DataMember(Name="nonLinearAnalysis", EmitDefaultValue=false)]
        public bool? NonLinearAnalysis { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionGroups
        /// </summary>
        [DataMember(Name="connectionGroups", EmitDefaultValue=false)]
        public List<OneOfThermalMechanicalConnectionGroups> ConnectionGroups { get; set; }

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
        public List<OneOfThermalMechanicalBoundaryConditions> BoundaryConditions { get; set; }

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
            sb.Append("class ThermalMechanical {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeDependency: ").Append(TimeDependency).Append("\n");
            sb.Append("  InertiaEffect: ").Append(InertiaEffect).Append("\n");
            sb.Append("  NonLinearAnalysis: ").Append(NonLinearAnalysis).Append("\n");
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
            return this.Equals(input as ThermalMechanical);
        }

        /// <summary>
        /// Returns true if ThermalMechanical instances are equal
        /// </summary>
        /// <param name="input">Instance of ThermalMechanical to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThermalMechanical input)
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
                    this.TimeDependency == input.TimeDependency ||
                    (this.TimeDependency != null &&
                    this.TimeDependency.Equals(input.TimeDependency))
                ) && 
                (
                    this.InertiaEffect == input.InertiaEffect ||
                    (this.InertiaEffect != null &&
                    this.InertiaEffect.Equals(input.InertiaEffect))
                ) && 
                (
                    this.NonLinearAnalysis == input.NonLinearAnalysis ||
                    (this.NonLinearAnalysis != null &&
                    this.NonLinearAnalysis.Equals(input.NonLinearAnalysis))
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
                if (this.TimeDependency != null)
                    hashCode = hashCode * 59 + this.TimeDependency.GetHashCode();
                if (this.InertiaEffect != null)
                    hashCode = hashCode * 59 + this.InertiaEffect.GetHashCode();
                if (this.NonLinearAnalysis != null)
                    hashCode = hashCode * 59 + this.NonLinearAnalysis.GetHashCode();
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
