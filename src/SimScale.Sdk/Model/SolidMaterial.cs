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
    /// SolidMaterial
    /// </summary>
    [DataContract]
    public partial class SolidMaterial : IEquatable<SolidMaterial>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidMaterial" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="materialBehavior">materialBehavior.</param>
        /// <param name="density">density.</param>
        /// <param name="expansion">expansion.</param>
        /// <param name="conductivity">conductivity.</param>
        /// <param name="specificHeat">specificHeat.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="builtInMaterial">builtInMaterial.</param>
        public SolidMaterial(string name = default(string), OneOfSolidMaterialMaterialBehavior materialBehavior = default(OneOfSolidMaterialMaterialBehavior), DimensionalFunctionDensity density = default(DimensionalFunctionDensity), IsotropicExpansion expansion = default(IsotropicExpansion), OneOfSolidMaterialConductivity conductivity = default(OneOfSolidMaterialConductivity), DimensionalFunctionSpecificHeat specificHeat = default(DimensionalFunctionSpecificHeat), TopologicalReference topologicalReference = default(TopologicalReference), string builtInMaterial = default(string))
        {
            this.Name = name;
            this.MaterialBehavior = materialBehavior;
            this.Density = density;
            this.Expansion = expansion;
            this.Conductivity = conductivity;
            this.SpecificHeat = specificHeat;
            this.TopologicalReference = topologicalReference;
            this.BuiltInMaterial = builtInMaterial;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MaterialBehavior
        /// </summary>
        [DataMember(Name="materialBehavior", EmitDefaultValue=false)]
        public OneOfSolidMaterialMaterialBehavior MaterialBehavior { get; set; }

        /// <summary>
        /// Gets or Sets Density
        /// </summary>
        [DataMember(Name="density", EmitDefaultValue=false)]
        public DimensionalFunctionDensity Density { get; set; }

        /// <summary>
        /// Gets or Sets Expansion
        /// </summary>
        [DataMember(Name="expansion", EmitDefaultValue=false)]
        public IsotropicExpansion Expansion { get; set; }

        /// <summary>
        /// Gets or Sets Conductivity
        /// </summary>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        public OneOfSolidMaterialConductivity Conductivity { get; set; }

        /// <summary>
        /// Gets or Sets SpecificHeat
        /// </summary>
        [DataMember(Name="specificHeat", EmitDefaultValue=false)]
        public DimensionalFunctionSpecificHeat SpecificHeat { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets BuiltInMaterial
        /// </summary>
        [DataMember(Name="builtInMaterial", EmitDefaultValue=false)]
        public string BuiltInMaterial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolidMaterial {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaterialBehavior: ").Append(MaterialBehavior).Append("\n");
            sb.Append("  Density: ").Append(Density).Append("\n");
            sb.Append("  Expansion: ").Append(Expansion).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  SpecificHeat: ").Append(SpecificHeat).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  BuiltInMaterial: ").Append(BuiltInMaterial).Append("\n");
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
            return this.Equals(input as SolidMaterial);
        }

        /// <summary>
        /// Returns true if SolidMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of SolidMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolidMaterial input)
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
                    this.MaterialBehavior == input.MaterialBehavior ||
                    (this.MaterialBehavior != null &&
                    this.MaterialBehavior.Equals(input.MaterialBehavior))
                ) && 
                (
                    this.Density == input.Density ||
                    (this.Density != null &&
                    this.Density.Equals(input.Density))
                ) && 
                (
                    this.Expansion == input.Expansion ||
                    (this.Expansion != null &&
                    this.Expansion.Equals(input.Expansion))
                ) && 
                (
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && 
                (
                    this.SpecificHeat == input.SpecificHeat ||
                    (this.SpecificHeat != null &&
                    this.SpecificHeat.Equals(input.SpecificHeat))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.BuiltInMaterial == input.BuiltInMaterial ||
                    (this.BuiltInMaterial != null &&
                    this.BuiltInMaterial.Equals(input.BuiltInMaterial))
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
                if (this.MaterialBehavior != null)
                    hashCode = hashCode * 59 + this.MaterialBehavior.GetHashCode();
                if (this.Density != null)
                    hashCode = hashCode * 59 + this.Density.GetHashCode();
                if (this.Expansion != null)
                    hashCode = hashCode * 59 + this.Expansion.GetHashCode();
                if (this.Conductivity != null)
                    hashCode = hashCode * 59 + this.Conductivity.GetHashCode();
                if (this.SpecificHeat != null)
                    hashCode = hashCode * 59 + this.SpecificHeat.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.BuiltInMaterial != null)
                    hashCode = hashCode * 59 + this.BuiltInMaterial.GetHashCode();
                return hashCode;
            }
        }

    }

}
