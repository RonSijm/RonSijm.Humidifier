namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;

    public class GroupVersion : Humidifier.Base.BaseResource, IHaveLoggerDefinitionVersionArn, IHaveDeviceDefinitionVersionArn, IHaveFunctionDefinitionVersionArn, IHaveCoreDefinitionVersionArn, IHaveResourceDefinitionVersionArn, IHaveConnectorDefinitionVersionArn, IHaveSubscriptionDefinitionVersionArn, IHaveGroupId
    {
        public override string AWSTypeName { get => AWS.Greengrass.GroupVersion; }
        /// <summary>
        /// LoggerDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-loggerdefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LoggerDefinitionVersionArn { get; set; }
        /// <summary>
        /// DeviceDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-devicedefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeviceDefinitionVersionArn { get; set; }
        /// <summary>
        /// FunctionDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-functiondefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FunctionDefinitionVersionArn { get; set; }
        /// <summary>
        /// CoreDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-coredefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CoreDefinitionVersionArn { get; set; }
        /// <summary>
        /// ResourceDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-resourcedefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceDefinitionVersionArn { get; set; }
        /// <summary>
        /// ConnectorDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-connectordefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectorDefinitionVersionArn { get; set; }
        /// <summary>
        /// SubscriptionDefinitionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-subscriptiondefinitionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubscriptionDefinitionVersionArn { get; set; }

        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-groupversion.html#cfn-greengrass-groupversion-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupId { get; set; }
    }
}