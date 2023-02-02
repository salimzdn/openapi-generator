/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Whale
    /// </summary>
    [DataContract(Name = "whale")]
    public partial class Whale : IEquatable<Whale>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Whale()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Whale" /> class.
        /// </summary>
        /// <param name="HasBaleen">HasBaleen.</param>
        /// <param name="HasTeeth">HasTeeth.</param>
        /// <param name="ClassName">ClassName (required).</param>
        public Whale( bool HasBaleen = default(bool), bool HasTeeth = default(bool), string ClassName = default(string))
        {
            // to ensure "ClassName" is required (not null)
            if (ClassName == null)
            {
                throw new ArgumentNullException("ClassName is a required property for Whale and cannot be null");
            }
            this.ClassName = ClassName;
            this.HasBaleen = HasBaleen;
            this.HasTeeth = HasTeeth;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets HasBaleen
        /// </summary>
        [DataMember(Name = "hasBaleen", EmitDefaultValue = true)]
        public bool HasBaleen { get; set; }

        /// <summary>
        /// Gets or Sets HasTeeth
        /// </summary>
        [DataMember(Name = "hasTeeth", EmitDefaultValue = true)]
        public bool HasTeeth { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [DataMember(Name = "className", IsRequired = true, EmitDefaultValue = true)]
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Whale {\n");
            sb.Append("  HasBaleen: ").Append(HasBaleen).Append("\n");
            sb.Append("  HasTeeth: ").Append(HasTeeth).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Whale).AreEqual;
        }

        /// <summary>
        /// Returns true if Whale instances are equal
        /// </summary>
        /// <param name="input">Instance of Whale to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Whale input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + this.HasBaleen.GetHashCode();
                hashCode = (hashCode * 59) + this.HasTeeth.GetHashCode();
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
