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
    /// ConversionQuery
    /// </summary>
    [DataContract(Name = "ConversionQuery")]
    public partial class ConversionQuery : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversionQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionQuery" /> class.
        /// </summary>
        /// <param name="from">from (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="amount">amount (default to 10M).</param>
        /// <param name="precision">precision (default to 5).</param>
        public ConversionQuery(string from = default(string), string to = default(string), decimal amount = 10M, int precision = 5)
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for ConversionQuery and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for ConversionQuery and cannot be null");
            }
            this.To = to;
            this.Amount = amount;
            this.Precision = precision;
        }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Precision
        /// </summary>
        [DataMember(Name = "precision", EmitDefaultValue = false)]
        public int Precision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversionQuery {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Precision: ").Append(Precision).Append("\n");
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
            // Amount (decimal) minimum
            if (this.Amount < (decimal)0.01)
            {
                yield return new ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.01.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
