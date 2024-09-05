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
    /// LastQuote
    /// </summary>
    [DataContract(Name = "LastQuote")]
    public partial class LastQuote : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastQuote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LastQuote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LastQuote" /> class.
        /// </summary>
        /// <param name="symbol">Symbol name (required).</param>
        /// <param name="ask">The ask price. (required).</param>
        /// <param name="bid">The bid price. (required).</param>
        /// <param name="mid">The mid price. (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public LastQuote(string symbol = default(string), decimal ask = default(decimal), decimal bid = default(decimal), decimal mid = default(decimal), int timestamp = default(int))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for LastQuote and cannot be null");
            }
            this.Symbol = symbol;
            this.Ask = ask;
            this.Bid = bid;
            this.Mid = mid;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Symbol name
        /// </summary>
        /// <value>Symbol name</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The ask price.
        /// </summary>
        /// <value>The ask price.</value>
        /// <example>1.23456</example>
        [DataMember(Name = "ask", IsRequired = true, EmitDefaultValue = true)]
        public decimal Ask { get; set; }

        /// <summary>
        /// The bid price.
        /// </summary>
        /// <value>The bid price.</value>
        /// <example>1.23456</example>
        [DataMember(Name = "bid", IsRequired = true, EmitDefaultValue = true)]
        public decimal Bid { get; set; }

        /// <summary>
        /// The mid price.
        /// </summary>
        /// <value>The mid price.</value>
        /// <example>1.23456</example>
        [DataMember(Name = "mid", IsRequired = true, EmitDefaultValue = true)]
        public decimal Mid { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        /// <example>1704882030</example>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public int Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LastQuote {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Ask: ").Append(Ask).Append("\n");
            sb.Append("  Bid: ").Append(Bid).Append("\n");
            sb.Append("  Mid: ").Append(Mid).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
