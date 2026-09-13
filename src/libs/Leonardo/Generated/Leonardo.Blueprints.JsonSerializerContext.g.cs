
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Leonardo
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.Blueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintThumbnail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintThumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeUiMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeExecutability))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintVersionPageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.NodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.NodeInputSettingName), TypeInfoPropertyName = "NodeInputSettingName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>), TypeInfoPropertyName = "OneOfStringIListTextVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.TextVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.TextVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ApiErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ApiErrorLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionStatus), TypeInfoPropertyName = "BlueprintExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<string, object>), TypeInfoPropertyName = "AllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.NodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<bool?, object>), TypeInfoPropertyName = "AllOfBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationsConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.BlueprintExecutionGenerationEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGeneration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationStatus), TypeInfoPropertyName = "BlueprintExecutionGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptModerationFailureReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptModerationFailureReasonType), TypeInfoPropertyName = "PromptModerationFailureReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsRequestPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsRequestPlatform), TypeInfoPropertyName = "ListBlueprintsRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfListBlueprintsResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponseBlueprints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsResponseBlueprintsEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Leonardo.ApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintByIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintByIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintVersionsByBlueprintIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfExecuteBlueprintResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponseExecuteBlueprint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ExecuteBlueprintResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>), TypeInfoPropertyName = "OneOfGetBlueprintExecutionResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintExecutionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.GetBlueprintExecutionGenerationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.NodeInputSettingName?), TypeInfoPropertyName = "NullableNodeInputSettingName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>?), TypeInfoPropertyName = "NullableOneOfStringIListTextVariable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionStatus?), TypeInfoPropertyName = "NullableBlueprintExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<string, object>?), TypeInfoPropertyName = "NullableAllOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.AllOf<bool?, object>?), TypeInfoPropertyName = "NullableAllOfBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.BlueprintExecutionGenerationStatus?), TypeInfoPropertyName = "NullableBlueprintExecutionGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.PromptModerationFailureReasonType?), TypeInfoPropertyName = "NullablePromptModerationFailureReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.ListBlueprintsRequestPlatform?), TypeInfoPropertyName = "NullableListBlueprintsRequestPlatform2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>?), TypeInfoPropertyName = "NullableOneOfListBlueprintsResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>?), TypeInfoPropertyName = "NullableOneOfGetBlueprintByIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>?), TypeInfoPropertyName = "NullableOneOfGetBlueprintVersionsByBlueprintIdResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>?), TypeInfoPropertyName = "NullableOneOfExecuteBlueprintResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>?), TypeInfoPropertyName = "NullableOneOfGetBlueprintExecutionResponse2IListApiError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintThumbnail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintVersionEdgeNodeExecutabilityReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<string, global::System.Collections.Generic.List<global::Leonardo.TextVariable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.TextVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ApiErrorLocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.NodeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.BlueprintExecutionGenerationEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsRequestPlatform>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ListBlueprintsResponseBlueprintsEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Leonardo.ApiError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Leonardo.OneOf<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.List<global::Leonardo.ApiError>>))]
    internal sealed partial class BlueprintsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BlueprintsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BlueprintsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BlueprintsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Leonardo.TextVariable>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::Leonardo.JsonConverters.AllOfJsonConverter<bool?, object>());
            options.Converters.Add(new global::Leonardo.JsonConverters.AllOfJsonConverter<string, object>());
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.ListBlueprintsResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintByIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintVersionsByBlueprintIdResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.ExecuteBlueprintResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.OneOfJsonConverter<global::Leonardo.GetBlueprintExecutionResponse2, global::System.Collections.Generic.IList<global::Leonardo.ApiError>>());
            options.Converters.Add(new global::Leonardo.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Leonardo.NodeInputSettingName)

                    || typeToConvert == typeof(global::Leonardo.NodeInputSettingName?)

                    || typeToConvert == typeof(global::Leonardo.BlueprintExecutionStatus)

                    || typeToConvert == typeof(global::Leonardo.BlueprintExecutionStatus?)

                    || typeToConvert == typeof(global::Leonardo.BlueprintExecutionGenerationStatus)

                    || typeToConvert == typeof(global::Leonardo.BlueprintExecutionGenerationStatus?)

                    || typeToConvert == typeof(global::Leonardo.PromptModerationFailureReasonType)

                    || typeToConvert == typeof(global::Leonardo.PromptModerationFailureReasonType?)

                    || typeToConvert == typeof(global::Leonardo.ListBlueprintsRequestPlatform)

                    || typeToConvert == typeof(global::Leonardo.ListBlueprintsRequestPlatform?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Leonardo.NodeInputSettingName))
                {
                    return new global::Leonardo.JsonConverters.NodeInputSettingNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.NodeInputSettingName?))
                {
                    return new global::Leonardo.JsonConverters.NodeInputSettingNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.BlueprintExecutionStatus))
                {
                    return new global::Leonardo.JsonConverters.BlueprintExecutionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.BlueprintExecutionStatus?))
                {
                    return new global::Leonardo.JsonConverters.BlueprintExecutionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.BlueprintExecutionGenerationStatus))
                {
                    return new global::Leonardo.JsonConverters.BlueprintExecutionGenerationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.BlueprintExecutionGenerationStatus?))
                {
                    return new global::Leonardo.JsonConverters.BlueprintExecutionGenerationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.PromptModerationFailureReasonType))
                {
                    return new global::Leonardo.JsonConverters.PromptModerationFailureReasonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.PromptModerationFailureReasonType?))
                {
                    return new global::Leonardo.JsonConverters.PromptModerationFailureReasonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.ListBlueprintsRequestPlatform))
                {
                    return new global::Leonardo.JsonConverters.ListBlueprintsRequestPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::Leonardo.ListBlueprintsRequestPlatform?))
                {
                    return new global::Leonardo.JsonConverters.ListBlueprintsRequestPlatformNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new BlueprintsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}