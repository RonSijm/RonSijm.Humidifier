namespace Humidifier.ResilienceHub
{
    using global::System.Collections.Generic;
    using AppTypes;

    public class App : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveAppTemplateBody, IHaveAppAssessmentSchedule, IHaveResilienceHubAppTypesPermissionModelPermissionModel, IHaveListOfResilienceHubAppTypesResourceMappingResourceMappings, IHaveListOfResilienceHubAppTypesEventSubscriptionEventSubscriptions, IHaveStringDictionaryOfTags, IHaveName, IHaveResiliencyPolicyArn
    {
        public class Attributes
        {
            public static string AppArn =  "AppArn" ;
            public static string DriftStatus =  "DriftStatus" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHub.App; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// AppTemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-apptemplatebody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppTemplateBody { get; set; }
        /// <summary>
        /// AppAssessmentSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-appassessmentschedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppAssessmentSchedule { get; set; }
        /// <summary>
        /// PermissionModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-permissionmodel
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PermissionModel
        /// </summary>
        public Union<Humidifier.ResilienceHub.AppTypes.PermissionModel, BaseFunction>? PermissionModel { get; set; }

        /// <summary>
        /// ResourceMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-resourcemappings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceMapping
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ResilienceHub.AppTypes.ResourceMapping>, IReadOnlyList<Union<Humidifier.ResilienceHub.AppTypes.ResourceMapping, BaseFunction>>, BaseFunction>? ResourceMappings { get; set; }
        /// <summary>
        /// EventSubscriptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-eventsubscriptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventSubscription
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ResilienceHub.AppTypes.EventSubscription>, IReadOnlyList<Union<Humidifier.ResilienceHub.AppTypes.EventSubscription, BaseFunction>>, BaseFunction>? EventSubscriptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ResiliencyPolicyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-app.html#cfn-resiliencehub-app-resiliencypolicyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResiliencyPolicyArn { get; set; }
    }

    namespace AppTypes
    {
        public class EventSubscription : Humidifier.Base.BaseSubResource, IHaveEventType, IHaveSnsTopicArn, IHaveName
        {
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-eventsubscription.html#cfn-resiliencehub-app-eventsubscription-eventtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventType { get; set; }
            /// <summary>
            /// SnsTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-eventsubscription.html#cfn-resiliencehub-app-eventsubscription-snstopicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnsTopicArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-eventsubscription.html#cfn-resiliencehub-app-eventsubscription-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PermissionModel : Humidifier.Base.BaseSubResource, IHaveType, IHaveStringListOfCrossAccountRoleArns, IHaveInvokerRoleName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-permissionmodel.html#cfn-resiliencehub-app-permissionmodel-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// CrossAccountRoleArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-permissionmodel.html#cfn-resiliencehub-app-permissionmodel-crossaccountrolearns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CrossAccountRoleArns { get; set; }
            /// <summary>
            /// InvokerRoleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-permissionmodel.html#cfn-resiliencehub-app-permissionmodel-invokerrolename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvokerRoleName { get; set; }
        }

        public class PhysicalResourceId : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier, IHaveAwsRegion, IHaveAwsAccountId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-physicalresourceid.html#cfn-resiliencehub-app-physicalresourceid-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-physicalresourceid.html#cfn-resiliencehub-app-physicalresourceid-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-physicalresourceid.html#cfn-resiliencehub-app-physicalresourceid-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-physicalresourceid.html#cfn-resiliencehub-app-physicalresourceid-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsAccountId { get; set; }
        }

        public class ResourceMapping : Humidifier.Base.BaseSubResource, IHaveMappingType, IHaveLogicalStackName, IHaveResourceName, IHaveTerraformSourceName, IHaveResilienceHubAppTypesPhysicalResourceIdPhysicalResourceId, IHaveEksSourceName
        {
            /// <summary>
            /// MappingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-mappingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MappingType { get; set; }
            /// <summary>
            /// LogicalStackName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-logicalstackname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalStackName { get; set; }
            /// <summary>
            /// ResourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-resourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceName { get; set; }
            /// <summary>
            /// TerraformSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-terraformsourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TerraformSourceName { get; set; }
            /// <summary>
            /// PhysicalResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-physicalresourceid
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PhysicalResourceId
            /// </summary>
            public Union<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId, BaseFunction>? PhysicalResourceId { get; set; }
            /// <summary>
            /// EksSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-app-resourcemapping.html#cfn-resiliencehub-app-resourcemapping-ekssourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EksSourceName { get; set; }
        }
    }
}