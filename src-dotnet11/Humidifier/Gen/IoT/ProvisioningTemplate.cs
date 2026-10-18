namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using ProvisioningTemplateTypes;

    public class ProvisioningTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveProvisioningRoleArn, IHaveDescription, IHaveIoTProvisioningTemplateTypesProvisioningHookPreProvisioningHook, IHaveTemplateName, IHaveEnabled_Boolean, IHaveTemplateBody, IHaveTemplateType
    {
        public class Attributes
        {
            public static string TemplateArn =  "TemplateArn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.ProvisioningTemplate; }

        /// <summary>
        /// ProvisioningRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-provisioningrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProvisioningRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PreProvisioningHook
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-preprovisioninghook
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisioningHook
        /// </summary>
        public Union<Humidifier.IoT.ProvisioningTemplateTypes.ProvisioningHook, BaseFunction>? PreProvisioningHook { get; set; }
        /// <summary>
        /// TemplateName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-templatename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateName { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }

        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-templatebody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        /// <summary>
        /// TemplateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-templatetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-provisioningtemplate.html#cfn-iot-provisioningtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ProvisioningTemplateTypes
    {
        public class ProvisioningHook : Humidifier.Base.BaseSubResource, IHaveTargetArn, IHavePayloadVersion
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-provisioningtemplate-provisioninghook.html#cfn-iot-provisioningtemplate-provisioninghook-targetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
            /// <summary>
            /// PayloadVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-provisioningtemplate-provisioninghook.html#cfn-iot-provisioningtemplate-provisioninghook-payloadversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadVersion { get; set; }
        }
    }
}