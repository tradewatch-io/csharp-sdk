/*
 * tradewatch.io
 *
 * Financial market data for Developers
 *
 * The version of the OpenAPI document: 3.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Tradewatch.Client.OpenAPIDateConverter;

namespace Tradewatch.Model
{
    /// <summary>
    /// ConversionInfo
    /// </summary>
    [DataContract(Name = "ConversionInfo")]
    public partial class ConversionInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversionInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionInfo" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="rate">rate (required).</param>
        public ConversionInfo(int timestamp = default(int), decimal rate = default(decimal))
        {
            this.Timestamp = timestamp;
            this.Rate = rate;
        }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        /// <example>1704882030</example>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        /// <example>1.23456</example>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = true)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversionInfo {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
