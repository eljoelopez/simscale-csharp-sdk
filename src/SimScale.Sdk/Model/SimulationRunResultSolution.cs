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
    /// SimulationRunResultSolution
    /// </summary>
    [DataContract]
    public partial class SimulationRunResultSolution : OneOfSimulationRunResult, IEquatable<SimulationRunResultSolution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunResultSolution" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationRunResultSolution() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunResultSolution" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SOLUTION_FIELD&quot;).</param>
        /// <param name="resultId">The result ID.</param>
        /// <param name="download">download.</param>
        public SimulationRunResultSolution(string type = "SOLUTION_FIELD", Guid? resultId = default(Guid?), SimulationRunResultDownload download = default(SimulationRunResultDownload))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SimulationRunResultSolution and cannot be null");
            this.ResultId = resultId;
            this.Download = download;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The result ID
        /// </summary>
        /// <value>The result ID</value>
        [DataMember(Name="resultId", EmitDefaultValue=false)]
        public Guid? ResultId { get; set; }

        /// <summary>
        /// The result category. For solution fields values include &#x60;SOLUTION&#x60;, &#x60;AVERAGED_SOLUTION&#x60;, &#x60;TRANSIENT_SOLUTION&#x60;, &#x60;STATISTICAL_SURFACE_SOLUTION&#x60;, etc. For convergence plots values include &#x60;RESIDUALS_PLOT&#x60;, &#x60;NUMBER_OF_NEWTON_ITERATIONS&#x60;, etc. For plots values include &#x60;FORCE_PLOT&#x60;, &#x60;FORCE_COEFFICIENTS_PLOT&#x60;, &#x60;PROBE_POINT_PLOT&#x60;, &#x60;AREA_AVERAGE&#x60;, &#x60;FACE_CALC&#x60;, etc. 
        /// </summary>
        /// <value>The result category. For solution fields values include &#x60;SOLUTION&#x60;, &#x60;AVERAGED_SOLUTION&#x60;, &#x60;TRANSIENT_SOLUTION&#x60;, &#x60;STATISTICAL_SURFACE_SOLUTION&#x60;, etc. For convergence plots values include &#x60;RESIDUALS_PLOT&#x60;, &#x60;NUMBER_OF_NEWTON_ITERATIONS&#x60;, etc. For plots values include &#x60;FORCE_PLOT&#x60;, &#x60;FORCE_COEFFICIENTS_PLOT&#x60;, &#x60;PROBE_POINT_PLOT&#x60;, &#x60;AREA_AVERAGE&#x60;, &#x60;FACE_CALC&#x60;, etc. </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; private set; }

        /// <summary>
        /// The result direction, only applies to Pedestrian Wind Comfort analysis
        /// </summary>
        /// <value>The result direction, only applies to Pedestrian Wind Comfort analysis</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public decimal? Direction { get; private set; }

        /// <summary>
        /// The time when the result was last modified.
        /// </summary>
        /// <value>The time when the result was last modified.</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTimeOffset? ModifiedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name="download", EmitDefaultValue=false)]
        public SimulationRunResultDownload Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationRunResultSolution {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ResultId: ").Append(ResultId).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return this.Equals(input as SimulationRunResultSolution);
        }

        /// <summary>
        /// Returns true if SimulationRunResultSolution instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationRunResultSolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationRunResultSolution input)
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
                    this.ResultId == input.ResultId ||
                    (this.ResultId != null &&
                    this.ResultId.Equals(input.ResultId))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.Download == input.Download ||
                    (this.Download != null &&
                    this.Download.Equals(input.Download))
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
                if (this.ResultId != null)
                    hashCode = hashCode * 59 + this.ResultId.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.Download != null)
                    hashCode = hashCode * 59 + this.Download.GetHashCode();
                return hashCode;
            }
        }

    }

}
