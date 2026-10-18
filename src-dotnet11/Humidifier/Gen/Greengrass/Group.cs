namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassGroupTypesGroupVersionInitialVersion, IHaveRoleArn, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string RoleAttachedAt =  "RoleAttachedAt" ;
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string RoleArn =  "RoleArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.Group; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: GroupVersion
        /// </summary>
        public Union<Humidifier.Greengrass.GroupTypes.GroupVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace GroupTypes
    {
        public class GroupVersion : Humidifier.Base.BaseSubResource, IHaveLoggerDefinitionVersionArn, IHaveDeviceDefinitionVersionArn, IHaveFunctionDefinitionVersionArn, IHaveCoreDefinitionVersionArn, IHaveResourceDefinitionVersionArn, IHaveConnectorDefinitionVersionArn, IHaveSubscriptionDefinitionVersionArn
        {
            /// <summary>
            /// LoggerDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-loggerdefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoggerDefinitionVersionArn { get; set; }
            /// <summary>
            /// DeviceDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-devicedefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceDefinitionVersionArn { get; set; }
            /// <summary>
            /// FunctionDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-functiondefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionDefinitionVersionArn { get; set; }
            /// <summary>
            /// CoreDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-coredefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CoreDefinitionVersionArn { get; set; }
            /// <summary>
            /// ResourceDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-resourcedefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceDefinitionVersionArn { get; set; }
            /// <summary>
            /// ConnectorDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-connectordefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorDefinitionVersionArn { get; set; }
            /// <summary>
            /// SubscriptionDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-subscriptiondefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionDefinitionVersionArn { get; set; }
        }
    }
}