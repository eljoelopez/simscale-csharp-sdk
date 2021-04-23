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
    /// ShipDesignAnalysisSBM
    /// </summary>
    [DataContract]
    public partial class ShipDesignAnalysisSBM : OneOfAdvancedConceptsSolidBodyMotions, IEquatable<ShipDesignAnalysisSBM>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipDesignAnalysisSBM" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipDesignAnalysisSBM() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipDesignAnalysisSBM" /> class.
        /// </summary>
        /// <param name="type">Schema name: ShipDesignAnalysisSBM (required) (default to &quot;SHIP_DESIGN_ANALYSIS&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="centerOfGravity">centerOfGravity.</param>
        /// <param name="modelScaleRatio">modelScaleRatio (default to 1M).</param>
        /// <param name="maxRollAmplitude">maxRollAmplitude.</param>
        /// <param name="minRollAmplitude">minRollAmplitude.</param>
        /// <param name="heaveAmplitude">heaveAmplitude.</param>
        /// <param name="swayAmplitude">swayAmplitude.</param>
        /// <param name="dampingCoefficient">dampingCoefficient (default to 1M).</param>
        /// <param name="timePeriodForLiquid">timePeriodForLiquid.</param>
        /// <param name="naturalPeriodOfShip">naturalPeriodOfShip.</param>
        /// <param name="referenceTimeStep">referenceTimeStep.</param>
        /// <param name="increaseInLiquidPerTimeStep">increaseInLiquidPerTimeStep (default to -0.001M).</param>
        public ShipDesignAnalysisSBM(string type = "SHIP_DESIGN_ANALYSIS", string name = default(string), DimensionalVectorLength centerOfGravity = default(DimensionalVectorLength), decimal? modelScaleRatio = default(decimal?), DimensionalAngle maxRollAmplitude = default(DimensionalAngle), DimensionalAngle minRollAmplitude = default(DimensionalAngle), DimensionalLength heaveAmplitude = default(DimensionalLength), DimensionalLength swayAmplitude = default(DimensionalLength), decimal? dampingCoefficient = default(decimal?), DimensionalTime timePeriodForLiquid = default(DimensionalTime), DimensionalTime naturalPeriodOfShip = default(DimensionalTime), DimensionalTime referenceTimeStep = default(DimensionalTime), decimal? increaseInLiquidPerTimeStep = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ShipDesignAnalysisSBM and cannot be null");
            this.Name = name;
            this.CenterOfGravity = centerOfGravity;
            this.ModelScaleRatio = modelScaleRatio;
            this.MaxRollAmplitude = maxRollAmplitude;
            this.MinRollAmplitude = minRollAmplitude;
            this.HeaveAmplitude = heaveAmplitude;
            this.SwayAmplitude = swayAmplitude;
            this.DampingCoefficient = dampingCoefficient;
            this.TimePeriodForLiquid = timePeriodForLiquid;
            this.NaturalPeriodOfShip = naturalPeriodOfShip;
            this.ReferenceTimeStep = referenceTimeStep;
            this.IncreaseInLiquidPerTimeStep = increaseInLiquidPerTimeStep;
        }
        
        /// <summary>
        /// Schema name: ShipDesignAnalysisSBM
        /// </summary>
        /// <value>Schema name: ShipDesignAnalysisSBM</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CenterOfGravity
        /// </summary>
        [DataMember(Name="centerOfGravity", EmitDefaultValue=false)]
        public DimensionalVectorLength CenterOfGravity { get; set; }

        /// <summary>
        /// Gets or Sets ModelScaleRatio
        /// </summary>
        [DataMember(Name="modelScaleRatio", EmitDefaultValue=false)]
        public decimal? ModelScaleRatio { get; set; }

        /// <summary>
        /// Gets or Sets MaxRollAmplitude
        /// </summary>
        [DataMember(Name="maxRollAmplitude", EmitDefaultValue=false)]
        public DimensionalAngle MaxRollAmplitude { get; set; }

        /// <summary>
        /// Gets or Sets MinRollAmplitude
        /// </summary>
        [DataMember(Name="minRollAmplitude", EmitDefaultValue=false)]
        public DimensionalAngle MinRollAmplitude { get; set; }

        /// <summary>
        /// Gets or Sets HeaveAmplitude
        /// </summary>
        [DataMember(Name="heaveAmplitude", EmitDefaultValue=false)]
        public DimensionalLength HeaveAmplitude { get; set; }

        /// <summary>
        /// Gets or Sets SwayAmplitude
        /// </summary>
        [DataMember(Name="swayAmplitude", EmitDefaultValue=false)]
        public DimensionalLength SwayAmplitude { get; set; }

        /// <summary>
        /// Gets or Sets DampingCoefficient
        /// </summary>
        [DataMember(Name="dampingCoefficient", EmitDefaultValue=false)]
        public decimal? DampingCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets TimePeriodForLiquid
        /// </summary>
        [DataMember(Name="timePeriodForLiquid", EmitDefaultValue=false)]
        public DimensionalTime TimePeriodForLiquid { get; set; }

        /// <summary>
        /// Gets or Sets NaturalPeriodOfShip
        /// </summary>
        [DataMember(Name="naturalPeriodOfShip", EmitDefaultValue=false)]
        public DimensionalTime NaturalPeriodOfShip { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceTimeStep
        /// </summary>
        [DataMember(Name="referenceTimeStep", EmitDefaultValue=false)]
        public DimensionalTime ReferenceTimeStep { get; set; }

        /// <summary>
        /// Gets or Sets IncreaseInLiquidPerTimeStep
        /// </summary>
        [DataMember(Name="increaseInLiquidPerTimeStep", EmitDefaultValue=false)]
        public decimal? IncreaseInLiquidPerTimeStep { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipDesignAnalysisSBM {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CenterOfGravity: ").Append(CenterOfGravity).Append("\n");
            sb.Append("  ModelScaleRatio: ").Append(ModelScaleRatio).Append("\n");
            sb.Append("  MaxRollAmplitude: ").Append(MaxRollAmplitude).Append("\n");
            sb.Append("  MinRollAmplitude: ").Append(MinRollAmplitude).Append("\n");
            sb.Append("  HeaveAmplitude: ").Append(HeaveAmplitude).Append("\n");
            sb.Append("  SwayAmplitude: ").Append(SwayAmplitude).Append("\n");
            sb.Append("  DampingCoefficient: ").Append(DampingCoefficient).Append("\n");
            sb.Append("  TimePeriodForLiquid: ").Append(TimePeriodForLiquid).Append("\n");
            sb.Append("  NaturalPeriodOfShip: ").Append(NaturalPeriodOfShip).Append("\n");
            sb.Append("  ReferenceTimeStep: ").Append(ReferenceTimeStep).Append("\n");
            sb.Append("  IncreaseInLiquidPerTimeStep: ").Append(IncreaseInLiquidPerTimeStep).Append("\n");
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
            return this.Equals(input as ShipDesignAnalysisSBM);
        }

        /// <summary>
        /// Returns true if ShipDesignAnalysisSBM instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipDesignAnalysisSBM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipDesignAnalysisSBM input)
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
                    this.CenterOfGravity == input.CenterOfGravity ||
                    (this.CenterOfGravity != null &&
                    this.CenterOfGravity.Equals(input.CenterOfGravity))
                ) && 
                (
                    this.ModelScaleRatio == input.ModelScaleRatio ||
                    (this.ModelScaleRatio != null &&
                    this.ModelScaleRatio.Equals(input.ModelScaleRatio))
                ) && 
                (
                    this.MaxRollAmplitude == input.MaxRollAmplitude ||
                    (this.MaxRollAmplitude != null &&
                    this.MaxRollAmplitude.Equals(input.MaxRollAmplitude))
                ) && 
                (
                    this.MinRollAmplitude == input.MinRollAmplitude ||
                    (this.MinRollAmplitude != null &&
                    this.MinRollAmplitude.Equals(input.MinRollAmplitude))
                ) && 
                (
                    this.HeaveAmplitude == input.HeaveAmplitude ||
                    (this.HeaveAmplitude != null &&
                    this.HeaveAmplitude.Equals(input.HeaveAmplitude))
                ) && 
                (
                    this.SwayAmplitude == input.SwayAmplitude ||
                    (this.SwayAmplitude != null &&
                    this.SwayAmplitude.Equals(input.SwayAmplitude))
                ) && 
                (
                    this.DampingCoefficient == input.DampingCoefficient ||
                    (this.DampingCoefficient != null &&
                    this.DampingCoefficient.Equals(input.DampingCoefficient))
                ) && 
                (
                    this.TimePeriodForLiquid == input.TimePeriodForLiquid ||
                    (this.TimePeriodForLiquid != null &&
                    this.TimePeriodForLiquid.Equals(input.TimePeriodForLiquid))
                ) && 
                (
                    this.NaturalPeriodOfShip == input.NaturalPeriodOfShip ||
                    (this.NaturalPeriodOfShip != null &&
                    this.NaturalPeriodOfShip.Equals(input.NaturalPeriodOfShip))
                ) && 
                (
                    this.ReferenceTimeStep == input.ReferenceTimeStep ||
                    (this.ReferenceTimeStep != null &&
                    this.ReferenceTimeStep.Equals(input.ReferenceTimeStep))
                ) && 
                (
                    this.IncreaseInLiquidPerTimeStep == input.IncreaseInLiquidPerTimeStep ||
                    (this.IncreaseInLiquidPerTimeStep != null &&
                    this.IncreaseInLiquidPerTimeStep.Equals(input.IncreaseInLiquidPerTimeStep))
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
                if (this.CenterOfGravity != null)
                    hashCode = hashCode * 59 + this.CenterOfGravity.GetHashCode();
                if (this.ModelScaleRatio != null)
                    hashCode = hashCode * 59 + this.ModelScaleRatio.GetHashCode();
                if (this.MaxRollAmplitude != null)
                    hashCode = hashCode * 59 + this.MaxRollAmplitude.GetHashCode();
                if (this.MinRollAmplitude != null)
                    hashCode = hashCode * 59 + this.MinRollAmplitude.GetHashCode();
                if (this.HeaveAmplitude != null)
                    hashCode = hashCode * 59 + this.HeaveAmplitude.GetHashCode();
                if (this.SwayAmplitude != null)
                    hashCode = hashCode * 59 + this.SwayAmplitude.GetHashCode();
                if (this.DampingCoefficient != null)
                    hashCode = hashCode * 59 + this.DampingCoefficient.GetHashCode();
                if (this.TimePeriodForLiquid != null)
                    hashCode = hashCode * 59 + this.TimePeriodForLiquid.GetHashCode();
                if (this.NaturalPeriodOfShip != null)
                    hashCode = hashCode * 59 + this.NaturalPeriodOfShip.GetHashCode();
                if (this.ReferenceTimeStep != null)
                    hashCode = hashCode * 59 + this.ReferenceTimeStep.GetHashCode();
                if (this.IncreaseInLiquidPerTimeStep != null)
                    hashCode = hashCode * 59 + this.IncreaseInLiquidPerTimeStep.GetHashCode();
                return hashCode;
            }
        }

    }

}
