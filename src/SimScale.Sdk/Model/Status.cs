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
    /// Status of the operation.
    /// </summary>
    /// <value>Status of the operation.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Status
    {
        /// <summary>
        /// Enum READY for value: READY
        /// </summary>
        [EnumMember(Value = "READY")]
        READY = 1,

        /// <summary>
        /// Enum QUEUED for value: QUEUED
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED = 2,

        /// <summary>
        /// Enum RUNNING for value: RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING = 3,

        /// <summary>
        /// Enum FINISHED for value: FINISHED
        /// </summary>
        [EnumMember(Value = "FINISHED")]
        FINISHED = 4,

        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED = 5,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 6

    }

}
