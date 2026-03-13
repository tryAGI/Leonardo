
#nullable enable

namespace Leonardo
{
    /// <summary>
    /// API error response structure
    /// </summary>
    public sealed partial class ApiError
    {
        /// <summary>
        /// Error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Path to the field that caused the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<string>? Path { get; set; }

        /// <summary>
        /// Location information for the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations")]
        public global::System.Collections.Generic.IList<global::Leonardo.ApiErrorLocation>? Locations { get; set; }

        /// <summary>
        /// Additional error details and context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public object? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        /// <param name="message">
        /// Error message
        /// </param>
        /// <param name="path">
        /// Path to the field that caused the error
        /// </param>
        /// <param name="locations">
        /// Location information for the error
        /// </param>
        /// <param name="extensions">
        /// Additional error details and context
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiError(
            string message,
            global::System.Collections.Generic.IList<string>? path,
            global::System.Collections.Generic.IList<global::Leonardo.ApiErrorLocation>? locations,
            object? extensions)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Path = path;
            this.Locations = locations;
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        public ApiError()
        {
        }
    }
}