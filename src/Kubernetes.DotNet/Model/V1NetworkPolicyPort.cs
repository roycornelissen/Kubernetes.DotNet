/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.7.10
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Kubernetes.DotNet.Client.SwaggerDateConverter;

namespace Kubernetes.DotNet.Model
{
    /// <summary>
    /// NetworkPolicyPort describes a port to allow traffic on
    /// </summary>
    [DataContract]
    public partial class V1NetworkPolicyPort :  IEquatable<V1NetworkPolicyPort>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1NetworkPolicyPort" /> class.
        /// </summary>
        /// <param name="Port">The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers..</param>
        /// <param name="Protocol">The protocol (TCP or UDP) which traffic must match. If not specified, this field defaults to TCP..</param>
        public V1NetworkPolicyPort(Object Port = default(Object), string Protocol = default(string))
        {
            this.Port = Port;
            this.Protocol = Protocol;
        }
        
        /// <summary>
        /// The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers.
        /// </summary>
        /// <value>The port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public Object Port { get; set; }

        /// <summary>
        /// The protocol (TCP or UDP) which traffic must match. If not specified, this field defaults to TCP.
        /// </summary>
        /// <value>The protocol (TCP or UDP) which traffic must match. If not specified, this field defaults to TCP.</value>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1NetworkPolicyPort {\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1NetworkPolicyPort);
        }

        /// <summary>
        /// Returns true if V1NetworkPolicyPort instances are equal
        /// </summary>
        /// <param name="other">Instance of V1NetworkPolicyPort to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1NetworkPolicyPort other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Protocol == other.Protocol ||
                    this.Protocol != null &&
                    this.Protocol.Equals(other.Protocol)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Protocol != null)
                    hash = hash * 59 + this.Protocol.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
