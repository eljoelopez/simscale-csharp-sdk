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
    /// SimulationSpec
    /// </summary>
    [DataContract]
    public partial class SimulationSpec : IEquatable<SimulationSpec>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSpec" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="version">version (required) (default to &quot;5.0&quot;).</param>
        /// <param name="geometryId">geometryId (required).</param>
        /// <param name="meshId">The generated mesh ID which is to be used in the simulation. This field should be left empty for analysis types that do not require a generated mesh like &#39;INCOMPRESSIBLE_PACEFISH&#39;, &#39;WIND_COMFORT&#39;, and &#39;SIMERICS_ANALYSIS&#39;..</param>
        /// <param name="model">model (required).</param>
        /// <param name="parameters">parameters.</param>
        public SimulationSpec(string name = default(string), string version = "5.0", Guid? geometryId = default(Guid?), Guid? meshId = default(Guid?), Analysis model = default(Analysis), Dictionary<string, OneOfParameters> parameters = default(Dictionary<string, OneOfParameters>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SimulationSpec and cannot be null");
            // to ensure "version" is required (not null)
            this.Version = version ?? throw new ArgumentNullException("version is a required property for SimulationSpec and cannot be null");
            // to ensure "geometryId" is required (not null)
            this.GeometryId = geometryId ?? throw new ArgumentNullException("geometryId is a required property for SimulationSpec and cannot be null");
            // to ensure "model" is required (not null)
            this.Model = model ?? throw new ArgumentNullException("model is a required property for SimulationSpec and cannot be null");
            this.MeshId = meshId;
            this.Parameters = parameters;
        }
        
        /// <summary>
        /// Gets or Sets SimulationId
        /// </summary>
        [DataMember(Name="simulationId", EmitDefaultValue=false)]
        public Guid? SimulationId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTimeOffset? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTimeOffset? ModifiedAt { get; private set; }

        /// <summary>
        /// Gets or Sets GeometryId
        /// </summary>
        [DataMember(Name="geometryId", EmitDefaultValue=false)]
        public Guid? GeometryId { get; set; }

        /// <summary>
        /// The generated mesh ID which is to be used in the simulation. This field should be left empty for analysis types that do not require a generated mesh like &#39;INCOMPRESSIBLE_PACEFISH&#39;, &#39;WIND_COMFORT&#39;, and &#39;SIMERICS_ANALYSIS&#39;.
        /// </summary>
        /// <value>The generated mesh ID which is to be used in the simulation. This field should be left empty for analysis types that do not require a generated mesh like &#39;INCOMPRESSIBLE_PACEFISH&#39;, &#39;WIND_COMFORT&#39;, and &#39;SIMERICS_ANALYSIS&#39;.</value>
        [DataMember(Name="meshId", EmitDefaultValue=false)]
        public Guid? MeshId { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public Analysis Model { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, OneOfParameters> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationSpec {\n");
            sb.Append("  SimulationId: ").Append(SimulationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  GeometryId: ").Append(GeometryId).Append("\n");
            sb.Append("  MeshId: ").Append(MeshId).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as SimulationSpec);
        }

        /// <summary>
        /// Returns true if SimulationSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimulationId == input.SimulationId ||
                    (this.SimulationId != null &&
                    this.SimulationId.Equals(input.SimulationId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.GeometryId == input.GeometryId ||
                    (this.GeometryId != null &&
                    this.GeometryId.Equals(input.GeometryId))
                ) && 
                (
                    this.MeshId == input.MeshId ||
                    (this.MeshId != null &&
                    this.MeshId.Equals(input.MeshId))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.SimulationId != null)
                    hashCode = hashCode * 59 + this.SimulationId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.GeometryId != null)
                    hashCode = hashCode * 59 + this.GeometryId.GetHashCode();
                if (this.MeshId != null)
                    hashCode = hashCode * 59 + this.MeshId.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }

    }

}
