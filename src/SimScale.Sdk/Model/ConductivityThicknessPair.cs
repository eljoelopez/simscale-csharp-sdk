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
    /// ConductivityThicknessPair
    /// </summary>
    [DataContract]
    public partial class ConductivityThicknessPair : IEquatable<ConductivityThicknessPair>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConductivityThicknessPair" /> class.
        /// </summary>
        /// <param name="thermalConductivity">thermalConductivity.</param>
        /// <param name="layerThickness">layerThickness.</param>
        public ConductivityThicknessPair(DimensionalThermalConductivity thermalConductivity = default(DimensionalThermalConductivity), DimensionalLength layerThickness = default(DimensionalLength))
        {
            this.ThermalConductivity = thermalConductivity;
            this.LayerThickness = layerThickness;
        }
        
        /// <summary>
        /// Gets or Sets ThermalConductivity
        /// </summary>
        [DataMember(Name="thermalConductivity", EmitDefaultValue=false)]
        public DimensionalThermalConductivity ThermalConductivity { get; set; }

        /// <summary>
        /// Gets or Sets LayerThickness
        /// </summary>
        [DataMember(Name="layerThickness", EmitDefaultValue=false)]
        public DimensionalLength LayerThickness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConductivityThicknessPair {\n");
            sb.Append("  ThermalConductivity: ").Append(ThermalConductivity).Append("\n");
            sb.Append("  LayerThickness: ").Append(LayerThickness).Append("\n");
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
            return this.Equals(input as ConductivityThicknessPair);
        }

        /// <summary>
        /// Returns true if ConductivityThicknessPair instances are equal
        /// </summary>
        /// <param name="input">Instance of ConductivityThicknessPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConductivityThicknessPair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ThermalConductivity == input.ThermalConductivity ||
                    (this.ThermalConductivity != null &&
                    this.ThermalConductivity.Equals(input.ThermalConductivity))
                ) && 
                (
                    this.LayerThickness == input.LayerThickness ||
                    (this.LayerThickness != null &&
                    this.LayerThickness.Equals(input.LayerThickness))
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
                if (this.ThermalConductivity != null)
                    hashCode = hashCode * 59 + this.ThermalConductivity.GetHashCode();
                if (this.LayerThickness != null)
                    hashCode = hashCode * 59 + this.LayerThickness.GetHashCode();
                return hashCode;
            }
        }

    }

}
