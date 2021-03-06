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
    /// RoleRef contains information that points to the role being used
    /// </summary>
    [DataContract]
    public partial class V1beta1RoleRef :  IEquatable<V1beta1RoleRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1RoleRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1beta1RoleRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1RoleRef" /> class.
        /// </summary>
        /// <param name="ApiGroup">APIGroup is the group for the resource being referenced (required).</param>
        /// <param name="Kind">Kind is the type of resource being referenced (required).</param>
        /// <param name="Name">Name is the name of resource being referenced (required).</param>
        public V1beta1RoleRef(string ApiGroup = default(string), string Kind = default(string), string Name = default(string))
        {
            // to ensure "ApiGroup" is required (not null)
            if (ApiGroup == null)
            {
                throw new InvalidDataException("ApiGroup is a required property for V1beta1RoleRef and cannot be null");
            }
            else
            {
                this.ApiGroup = ApiGroup;
            }
            // to ensure "Kind" is required (not null)
            if (Kind == null)
            {
                throw new InvalidDataException("Kind is a required property for V1beta1RoleRef and cannot be null");
            }
            else
            {
                this.Kind = Kind;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for V1beta1RoleRef and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
        }
        
        /// <summary>
        /// APIGroup is the group for the resource being referenced
        /// </summary>
        /// <value>APIGroup is the group for the resource being referenced</value>
        [DataMember(Name="apiGroup", EmitDefaultValue=false)]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Kind is the type of resource being referenced
        /// </summary>
        /// <value>Kind is the type of resource being referenced</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// Name is the name of resource being referenced
        /// </summary>
        /// <value>Name is the name of resource being referenced</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1RoleRef {\n");
            sb.Append("  ApiGroup: ").Append(ApiGroup).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as V1beta1RoleRef);
        }

        /// <summary>
        /// Returns true if V1beta1RoleRef instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1RoleRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1RoleRef other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiGroup == other.ApiGroup ||
                    this.ApiGroup != null &&
                    this.ApiGroup.Equals(other.ApiGroup)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.ApiGroup != null)
                    hash = hash * 59 + this.ApiGroup.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
