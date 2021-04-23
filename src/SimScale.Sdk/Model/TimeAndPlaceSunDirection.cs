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
    /// TimeAndPlaceSunDirection
    /// </summary>
    [DataContract]
    public partial class TimeAndPlaceSunDirection : OneOfSolarCalculatorSunDirection, IEquatable<TimeAndPlaceSunDirection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAndPlaceSunDirection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeAndPlaceSunDirection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeAndPlaceSunDirection" /> class.
        /// </summary>
        /// <param name="type">Schema name: TimeAndPlaceSunDirection (required) (default to &quot;TIME_AND_PLACE&quot;).</param>
        /// <param name="northAngle">northAngle.</param>
        /// <param name="geographicalLocation">geographicalLocation.</param>
        /// <param name="localDateTime">localDateTime.</param>
        public TimeAndPlaceSunDirection(string type = "TIME_AND_PLACE", DimensionalAngle northAngle = default(DimensionalAngle), GeographicalLocation geographicalLocation = default(GeographicalLocation), string localDateTime = default(string))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TimeAndPlaceSunDirection and cannot be null");
            this.NorthAngle = northAngle;
            this.GeographicalLocation = geographicalLocation;
            this.LocalDateTime = localDateTime;
        }
        
        /// <summary>
        /// Schema name: TimeAndPlaceSunDirection
        /// </summary>
        /// <value>Schema name: TimeAndPlaceSunDirection</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets NorthAngle
        /// </summary>
        [DataMember(Name="northAngle", EmitDefaultValue=false)]
        public DimensionalAngle NorthAngle { get; set; }

        /// <summary>
        /// Gets or Sets GeographicalLocation
        /// </summary>
        [DataMember(Name="geographicalLocation", EmitDefaultValue=false)]
        public GeographicalLocation GeographicalLocation { get; set; }

        /// <summary>
        /// Gets or Sets LocalDateTime
        /// </summary>
        [DataMember(Name="localDateTime", EmitDefaultValue=false)]
        public string LocalDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeAndPlaceSunDirection {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NorthAngle: ").Append(NorthAngle).Append("\n");
            sb.Append("  GeographicalLocation: ").Append(GeographicalLocation).Append("\n");
            sb.Append("  LocalDateTime: ").Append(LocalDateTime).Append("\n");
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
            return this.Equals(input as TimeAndPlaceSunDirection);
        }

        /// <summary>
        /// Returns true if TimeAndPlaceSunDirection instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeAndPlaceSunDirection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeAndPlaceSunDirection input)
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
                    this.NorthAngle == input.NorthAngle ||
                    (this.NorthAngle != null &&
                    this.NorthAngle.Equals(input.NorthAngle))
                ) && 
                (
                    this.GeographicalLocation == input.GeographicalLocation ||
                    (this.GeographicalLocation != null &&
                    this.GeographicalLocation.Equals(input.GeographicalLocation))
                ) && 
                (
                    this.LocalDateTime == input.LocalDateTime ||
                    (this.LocalDateTime != null &&
                    this.LocalDateTime.Equals(input.LocalDateTime))
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
                if (this.NorthAngle != null)
                    hashCode = hashCode * 59 + this.NorthAngle.GetHashCode();
                if (this.GeographicalLocation != null)
                    hashCode = hashCode * 59 + this.GeographicalLocation.GetHashCode();
                if (this.LocalDateTime != null)
                    hashCode = hashCode * 59 + this.LocalDateTime.GetHashCode();
                return hashCode;
            }
        }

    }

}
