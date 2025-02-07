using System.Collections.Generic;
using System.Linq;
using Humidifier.Base;

namespace Humidifier;

public class Stack
{
    public string Name { get; set; }
    private Dictionary<string, string> ResourceConditions { get; } = new();
    private Dictionary<string, DeletionPolicy> ResourceDeletionPolicies { get; } = new();
    private Dictionary<string, CreationPolicy> ResourceCreationPolicies { get; } = new();
    private Dictionary<string, UpdatePolicy> ResourceUpdatePolicies { get; } = new();
    private Dictionary<string, HashSet<string>> ResourceDependsOn { get; } = new();

    public Stack(string awsTemplateFormatVersion = "2010-09-09")
    {
        AWSTemplateFormatVersion = awsTemplateFormatVersion;
    }

    public string AWSTemplateFormatVersion { get; set; }
    public string Transform { get; set; }
    public string Description { get; set; }

    public Dictionary<string, Parameter> Parameters { get; } = new();
    public Dictionary<string, Condition> Conditions { get; } = new();
    public Dictionary<string, Mapping> Mappings { get; } = new();
    public Dictionary<string, BaseResource> Resources { get; } = new();
    public Dictionary<string, Output> Outputs { get; } = new();
    public Dictionary<string, dynamic> ResourceMetadata { get; } = new();
    public Dictionary<string, dynamic> TemplateMetadata { get; } = new();

    public void Add(string name, Parameter parameter) => Parameters.Add(name, parameter);
    public void Add(string name, Condition condition) => Conditions.Add(name, condition);
    public void Add(string name, Output output) => Outputs.Add(name, output);
    public void Add(string name, Mapping mapping) => Mappings.Add(name, mapping);

    public void Add(BaseResource resource)
    {
        Add(resource.ResourceName, resource, creationPolicy: resource.CreationPolicy);
    }

    public void Add(string name, BaseResource resource, string condition = null, CreationPolicy creationPolicy = null, UpdatePolicy updatePolicy = null, DeletionPolicy? deletionPolicy = null, dynamic metadata = null, string[] dependsOn = null)
    {
        Resources.Add(name, resource);

        if (!string.IsNullOrWhiteSpace(condition))
        {
            AddCondition(name, condition);
        }

        if (dependsOn != null && dependsOn.Length > 0)
        {
            AddDependsOn(name, dependsOn);
        }

        if (creationPolicy != null)
        {
            AddCreationPolicy(name, creationPolicy);
        }

        if (updatePolicy != null)
        {
            AddUpdatePolicy(name, updatePolicy);
        }

        if (deletionPolicy != null)
        {
            AddDeletionPolicy(name, deletionPolicy.Value);
        }

        if (metadata != null)
        {
            AddResourceMetadata(name, metadata);
        }
    }

    public void AddCondition(string resource, string condition)
    {
        ResourceConditions[resource] = condition;
    }

    public void AddDependsOn(string resource, params string[] dependsOn)
    {
        if (ResourceDependsOn.TryGetValue(resource, out var value))
        {
            foreach (var item in dependsOn)
            {
                value.Add(item);
            }
        }
        else
        {
            ResourceDependsOn.Add(resource, new HashSet<string>(dependsOn));
        }
    }

    public void AddCreationPolicy(string resource, CreationPolicy creationPolicy)
    {
        ResourceCreationPolicies[resource] = creationPolicy;
    }

    public void AddUpdatePolicy(string resource, UpdatePolicy updatePolicy)
    {
        if (ResourceCreationPolicies.ContainsKey(resource))
        {
            ResourceUpdatePolicies[resource] = updatePolicy;
        }
        else
        {
            ResourceUpdatePolicies.Add(resource, updatePolicy);
        }
    }

    public void AddDeletionPolicy(string resource, DeletionPolicy policy)
    {
        ResourceDeletionPolicies[resource] = policy;
    }

    public void AddResourceMetadata(string resource, dynamic metadata)
    {
        ResourceMetadata[resource] = metadata;
    }

    public void AddTemplateMetadata(string resource, dynamic metadata)
    {
        TemplateMetadata[resource] = metadata;
    }

    public string GetCondition(string resource)
    {
        return ResourceConditions.GetValueOrDefault(resource);
    }

    public List<string> GetDependsOn(string resource)
    {
        if (ResourceDependsOn.TryGetValue(resource, out var value))
        {
            return value.ToList();
        }

        return null;
    }

    public CreationPolicy GetCreationPolicy(string resource)
    {
        return ResourceCreationPolicies.GetValueOrDefault(resource);
    }

    public UpdatePolicy GetUpdatePolicy(string resource)
    {
        return ResourceUpdatePolicies.GetValueOrDefault(resource);
    }

    public DeletionPolicy? GetDeletionPolicy(string resource)
    {
        if (ResourceDeletionPolicies.TryGetValue(resource, out var policy))
        {
            return policy;
        }

        return null;
    }

    public dynamic GetMetadata(string resource)
    {
        return ResourceMetadata.GetValueOrDefault(resource);
    }
}