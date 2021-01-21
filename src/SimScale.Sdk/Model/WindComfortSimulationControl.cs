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
    /// WindComfortSimulationControl
    /// </summary>
    [DataContract]
    public partial class WindComfortSimulationControl : IEquatable<WindComfortSimulationControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindComfortSimulationControl" /> class.
        /// </summary>
        /// <param name="maxDirectionRunTime">maxDirectionRunTime.</param>
        /// <param name="numberOfFluidPasses">&lt;p&gt;Set how many times the fluid (air) passes over the domain during the simulation. &lt;b&gt;Warning&lt;/b&gt;: Values below 2.0 might produce invalid results while higher numbers will require more simulation time and consequently more GPU hours. Recommended value is 3.0. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt; (default to 3M).</param>
        public WindComfortSimulationControl(DimensionalTime maxDirectionRunTime = default(DimensionalTime), decimal? numberOfFluidPasses = default(decimal?))
        {
            this.MaxDirectionRunTime = maxDirectionRunTime;
            this.NumberOfFluidPasses = numberOfFluidPasses;
        }
        
        /// <summary>
        /// Gets or Sets MaxDirectionRunTime
        /// </summary>
        [DataMember(Name="maxDirectionRunTime", EmitDefaultValue=false)]
        public DimensionalTime MaxDirectionRunTime { get; set; }

        /// <summary>
        /// &lt;p&gt;Set how many times the fluid (air) passes over the domain during the simulation. &lt;b&gt;Warning&lt;/b&gt;: Values below 2.0 might produce invalid results while higher numbers will require more simulation time and consequently more GPU hours. Recommended value is 3.0. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Set how many times the fluid (air) passes over the domain during the simulation. &lt;b&gt;Warning&lt;/b&gt;: Values below 2.0 might produce invalid results while higher numbers will require more simulation time and consequently more GPU hours. Recommended value is 3.0. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="numberOfFluidPasses", EmitDefaultValue=false)]
        public decimal? NumberOfFluidPasses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindComfortSimulationControl {\n");
            sb.Append("  MaxDirectionRunTime: ").Append(MaxDirectionRunTime).Append("\n");
            sb.Append("  NumberOfFluidPasses: ").Append(NumberOfFluidPasses).Append("\n");
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
            return this.Equals(input as WindComfortSimulationControl);
        }

        /// <summary>
        /// Returns true if WindComfortSimulationControl instances are equal
        /// </summary>
        /// <param name="input">Instance of WindComfortSimulationControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindComfortSimulationControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxDirectionRunTime == input.MaxDirectionRunTime ||
                    (this.MaxDirectionRunTime != null &&
                    this.MaxDirectionRunTime.Equals(input.MaxDirectionRunTime))
                ) && 
                (
                    this.NumberOfFluidPasses == input.NumberOfFluidPasses ||
                    (this.NumberOfFluidPasses != null &&
                    this.NumberOfFluidPasses.Equals(input.NumberOfFluidPasses))
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
                if (this.MaxDirectionRunTime != null)
                    hashCode = hashCode * 59 + this.MaxDirectionRunTime.GetHashCode();
                if (this.NumberOfFluidPasses != null)
                    hashCode = hashCode * 59 + this.NumberOfFluidPasses.GetHashCode();
                return hashCode;
            }
        }

    }

}
