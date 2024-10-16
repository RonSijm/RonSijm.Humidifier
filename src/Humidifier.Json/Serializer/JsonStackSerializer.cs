using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Humidifier.Base;
using Humidifier.Interfaces;
using Humidifier.Json.Converters;
using Newtonsoft.Json;

namespace Humidifier.Json.Serializer;

public class JsonStackSerializer : IStackSerializer
{
    public JsonStackSerializer()
    {
        _settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            ContractResolver = new JsonStackSerializerContractResolver()
        };

        _settings.Converters.Add(new ConditionConverter());
        _settings.Converters.Add(new PropertyWithFallbackConverter());

        // Intrinsic functions
        _settings.Converters.Add(new FnJoinConverter());
        _settings.Converters.Add(new FnRefConverter());
        _settings.Converters.Add(new FnGetAttConverter());
        _settings.Converters.Add(new FnSubConverter());
        _settings.Converters.Add(new FnImportValueConverter());
        _settings.Converters.Add(new FnSplitConverter());
        _settings.Converters.Add(new FnSelectConverter());
        _settings.Converters.Add(new FnGetAZsConverter());
        _settings.Converters.Add(new FnFindInMapConverter());
        _settings.Converters.Add(new FnBase64Converter());
        _settings.Converters.Add(new FnCidrConvertor());
        _settings.Converters.Add(new FnLazyStringConverter());

        // Conditional functions
        _settings.Converters.Add(new FnAndConverter());
        _settings.Converters.Add(new FnIfConverter());
        _settings.Converters.Add(new FnEqualsConverter());
        _settings.Converters.Add(new FnNotConverter());
        _settings.Converters.Add(new FnOrConverter());

        _settings.Converters.Add(new FnStringJoinConverter());
        _settings.Converters.Add(new FFnREFConverter());
        _settings.Converters.Add(new FFnNameConverter());
        _settings.Converters.Add(new FFnNameFuncConverter());
        _settings.Converters.Add(new FFnImportValueConverter());
        _settings.Converters.Add(new FFnARNConverter());
        _settings.Converters.Add(new FFnGetAttConverter());
        _settings.Converters.Add(new FFNamedListConverter());
        _settings.Converters.Add(new FFnREFListConverter());
        _settings.Converters.Add(new FFnSubConverter());
        _settings.Converters.Add(new FFnTokenConverter());

        //if (injectedConverters != null)
        //{
        //    foreach (var injectedConverter in injectedConverters)
        //    {
        //        _settings.Converters.Add(injectedConverter);
        //    }
        //}

        //_settings.Error = (sender, args) =>
        //{
        //    //Console.WriteLine($"Error: {args.ErrorContext.Error.Message}");
        //    args.ErrorContext.Handled = true;
        //};
    }

    private readonly JsonSerializerSettings _settings;

    public string Serialize(Stack stack)
    {
        var stackJson = new StackJson
        {
            AWSTemplateFormatVersion = stack.AWSTemplateFormatVersion,
            Transform = stack.Transform,
            Description = stack.Description
        };

        if (stack.Parameters != null && stack.Parameters.Any())
        {
            stackJson.Parameters = stack.Parameters;
        }

        if (stack.Mappings != null && stack.Mappings.Any())
        {
            stackJson.Mappings = stack.Mappings;
        }

        if (stack.Resources != null)
        {
            foreach (var resource in stack.Resources.Where(x => x.Value.Export))
            {
                stack.Outputs.Add(resource.Key, new Output
                {
                    Value = Fn.Ref(resource.Key),
                    Export = new { Name = Fn.Sub(resource.Key) }
                });

                // This has already been exported in this stack.
                // So setting it to false to prevent importers to accidentally export it again, or something
                resource.Value.Export = false;
            }
        }

        if (stack.Outputs != null && stack.Outputs.Any())
        {
            stackJson.Outputs = stack.Outputs;
        }

        if (stack.Conditions != null && stack.Conditions.Any())
        {
            stackJson.Conditions = stack.Conditions;
        }

        if (stack.TemplateMetadata != null && stack.TemplateMetadata.Any())
        {
            stackJson.Metadata = stack.TemplateMetadata;
        }

        if (stack.Resources != null && stack.Resources.Any())
        {
            stackJson.Resources = new Dictionary<string, ResourceJson>();

            foreach (KeyValuePair<string, BaseResource> kvp in stack.Resources)
            {
                var resource = kvp.Value;

                var typeInfo = kvp.Value.GetType();
                Debug.Assert(typeInfo.Namespace != null);

                var condition = stack.GetCondition(kvp.Key);
                var dependsOn = stack.GetDependsOn(kvp.Key);

                var creationPolicy = stack.GetCreationPolicy(kvp.Key);
                var updatePolicy = stack.GetUpdatePolicy(kvp.Key);
                var deletionPolicy = stack.GetDeletionPolicy(kvp.Key);
                var metadata = stack.GetMetadata(kvp.Key);

                var resourceJson = new ResourceJson
                {
                    Type = resource.AWSTypeName,
                    Condition = condition,
                    Properties = resource,
                    DependsOn = resource.DependsOn,
                    CreationPolicy = creationPolicy,
                    UpdatePolicy = updatePolicy,
                    DeletionPolicy = deletionPolicy,
                    Metadata = metadata
                };

                stackJson.Resources.Add(kvp.Key, resourceJson);
            }
        }

        var result = JsonConvert.SerializeObject(stackJson, _settings);
        return result;
    }
}