
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Leonardo
{
    /// <summary>
    /// Represents the Execution of a Blueprint Version
    /// </summary>
    public sealed partial class BlueprintExecution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("akUUID")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.AllOf<string, object> AkUUID { get; set; }

        /// <summary>
        /// The status of a Blueprint Execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.BlueprintExecutionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.BlueprintExecutionStatus Status { get; set; }

        /// <summary>
        /// Inputs of the Blueprint Execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Leonardo.NodeInput> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Leonardo.JsonConverters.AllOfJsonConverter<bool?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Leonardo.AllOf<bool?, object> Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecution" /> class.
        /// </summary>
        /// <param name="akUUID"></param>
        /// <param name="status">
        /// The status of a Blueprint Execution.
        /// </param>
        /// <param name="inputs">
        /// Inputs of the Blueprint Execution
        /// </param>
        /// <param name="public"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlueprintExecution(
            global::Leonardo.AllOf<string, object> akUUID,
            global::Leonardo.BlueprintExecutionStatus status,
            global::System.Collections.Generic.IList<global::Leonardo.NodeInput> inputs,
            global::Leonardo.AllOf<bool?, object> @public,
            string createdAt)
        {
            this.AkUUID = akUUID;
            this.Status = status;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Public = @public;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintExecution" /> class.
        /// </summary>
        public BlueprintExecution()
        {
        }
    }
}