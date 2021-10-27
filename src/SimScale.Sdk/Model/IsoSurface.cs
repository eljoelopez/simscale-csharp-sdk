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
    /// IsoSurface
    /// </summary>
    [DataContract]
    public partial class IsoSurface : IEquatable<IsoSurface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoSurface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsoSurface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoSurface" /> class.
        /// </summary>
        /// <param name="isoScalar">isoScalar.</param>
        /// <param name="isoValue">The iso scalar value. Should be within the selected scalar range. Default value is the average between the min and max in the range..</param>
        /// <param name="scalarField">scalarField.</param>
        /// <param name="solidColor">solidColor.</param>
        /// <param name="vectorField">vectorField.</param>
        /// <param name="opacity">opacity (required) (default to 1.0F).</param>
        public IsoSurface(ScalarField isoScalar = default(ScalarField), float? isoValue = default(float?), ScalarField scalarField = default(ScalarField), Color solidColor = default(Color), VectorField vectorField = default(VectorField), float? opacity = 1.0F)
        {
            // to ensure "opacity" is required (not null)
            this.Opacity = opacity ?? throw new ArgumentNullException("opacity is a required property for IsoSurface and cannot be null");
            this.IsoScalar = isoScalar;
            this.IsoValue = isoValue;
            this.ScalarField = scalarField;
            this.SolidColor = solidColor;
            this.VectorField = vectorField;
        }
        
        /// <summary>
        /// Gets or Sets IsoScalar
        /// </summary>
        [DataMember(Name="isoScalar", EmitDefaultValue=false)]
        public ScalarField IsoScalar { get; set; }

        /// <summary>
        /// The iso scalar value. Should be within the selected scalar range. Default value is the average between the min and max in the range.
        /// </summary>
        /// <value>The iso scalar value. Should be within the selected scalar range. Default value is the average between the min and max in the range.</value>
        [DataMember(Name="isoValue", EmitDefaultValue=false)]
        public float? IsoValue { get; set; }

        /// <summary>
        /// Gets or Sets ScalarField
        /// </summary>
        [DataMember(Name="scalarField", EmitDefaultValue=false)]
        public ScalarField ScalarField { get; set; }

        /// <summary>
        /// Gets or Sets SolidColor
        /// </summary>
        [DataMember(Name="solidColor", EmitDefaultValue=false)]
        public Color SolidColor { get; set; }

        /// <summary>
        /// Gets or Sets VectorField
        /// </summary>
        [DataMember(Name="vectorField", EmitDefaultValue=false)]
        public VectorField VectorField { get; set; }

        /// <summary>
        /// Gets or Sets Opacity
        /// </summary>
        [DataMember(Name="opacity", EmitDefaultValue=false)]
        public float? Opacity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsoSurface {\n");
            sb.Append("  IsoScalar: ").Append(IsoScalar).Append("\n");
            sb.Append("  IsoValue: ").Append(IsoValue).Append("\n");
            sb.Append("  ScalarField: ").Append(ScalarField).Append("\n");
            sb.Append("  SolidColor: ").Append(SolidColor).Append("\n");
            sb.Append("  VectorField: ").Append(VectorField).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
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
            return this.Equals(input as IsoSurface);
        }

        /// <summary>
        /// Returns true if IsoSurface instances are equal
        /// </summary>
        /// <param name="input">Instance of IsoSurface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsoSurface input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsoScalar == input.IsoScalar ||
                    (this.IsoScalar != null &&
                    this.IsoScalar.Equals(input.IsoScalar))
                ) && 
                (
                    this.IsoValue == input.IsoValue ||
                    (this.IsoValue != null &&
                    this.IsoValue.Equals(input.IsoValue))
                ) && 
                (
                    this.ScalarField == input.ScalarField ||
                    (this.ScalarField != null &&
                    this.ScalarField.Equals(input.ScalarField))
                ) && 
                (
                    this.SolidColor == input.SolidColor ||
                    (this.SolidColor != null &&
                    this.SolidColor.Equals(input.SolidColor))
                ) && 
                (
                    this.VectorField == input.VectorField ||
                    (this.VectorField != null &&
                    this.VectorField.Equals(input.VectorField))
                ) && 
                (
                    this.Opacity == input.Opacity ||
                    (this.Opacity != null &&
                    this.Opacity.Equals(input.Opacity))
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
                if (this.IsoScalar != null)
                    hashCode = hashCode * 59 + this.IsoScalar.GetHashCode();
                if (this.IsoValue != null)
                    hashCode = hashCode * 59 + this.IsoValue.GetHashCode();
                if (this.ScalarField != null)
                    hashCode = hashCode * 59 + this.ScalarField.GetHashCode();
                if (this.SolidColor != null)
                    hashCode = hashCode * 59 + this.SolidColor.GetHashCode();
                if (this.VectorField != null)
                    hashCode = hashCode * 59 + this.VectorField.GetHashCode();
                if (this.Opacity != null)
                    hashCode = hashCode * 59 + this.Opacity.GetHashCode();
                return hashCode;
            }
        }

    }

}
