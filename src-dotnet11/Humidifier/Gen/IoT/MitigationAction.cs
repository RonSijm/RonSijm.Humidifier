namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using MitigationActionTypes;

    public class MitigationAction : Humidifier.Base.BaseResource, IHaveTags, IHaveActionName, IHaveIoTMitigationActionTypesActionParamsActionParams, IHaveRoleArn
    {
        public class Attributes
        {
            public static string MitigationActionArn =  "MitigationActionArn" ;
            public static string MitigationActionId =  "MitigationActionId" ;
        }

        public override string AWSTypeName { get => AWS.IoT.MitigationAction; }
        /// <summary>
        /// ActionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-actionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActionName { get; set; }

        /// <summary>
        /// ActionParams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-actionparams
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ActionParams
        /// </summary>
        [Required]
        public Union<Humidifier.IoT.MitigationActionTypes.ActionParams, BaseFunction>? ActionParams { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MitigationActionTypes
    {
        public class ActionParams : Humidifier.Base.BaseSubResource, IHaveIoTMitigationActionTypesUpdateDeviceCertificateParamsUpdateDeviceCertificateParams, IHaveIoTMitigationActionTypesAddThingsToThingGroupParamsAddThingsToThingGroupParams, IHaveIoTMitigationActionTypesPublishFindingToSnsParamsPublishFindingToSnsParams, IHaveIoTMitigationActionTypesEnableIoTLoggingParamsEnableIoTLoggingParams, IHaveIoTMitigationActionTypesReplaceDefaultPolicyVersionParamsReplaceDefaultPolicyVersionParams, IHaveIoTMitigationActionTypesUpdateCACertificateParamsUpdateCACertificateParams
        {
            /// <summary>
            /// UpdateDeviceCertificateParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-updatedevicecertificateparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateDeviceCertificateParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams, BaseFunction>? UpdateDeviceCertificateParams { get; set; }
            /// <summary>
            /// AddThingsToThingGroupParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-addthingstothinggroupparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddThingsToThingGroupParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams, BaseFunction>? AddThingsToThingGroupParams { get; set; }
            /// <summary>
            /// PublishFindingToSnsParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-publishfindingtosnsparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishFindingToSnsParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams, BaseFunction>? PublishFindingToSnsParams { get; set; }
            /// <summary>
            /// EnableIoTLoggingParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-enableiotloggingparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnableIoTLoggingParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams, BaseFunction>? EnableIoTLoggingParams { get; set; }
            /// <summary>
            /// ReplaceDefaultPolicyVersionParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-replacedefaultpolicyversionparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplaceDefaultPolicyVersionParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams, BaseFunction>? ReplaceDefaultPolicyVersionParams { get; set; }
            /// <summary>
            /// UpdateCACertificateParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-updatecacertificateparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateCACertificateParams
            /// </summary>
            public Union<Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams, BaseFunction>? UpdateCACertificateParams { get; set; }
        }

        public class AddThingsToThingGroupParams : Humidifier.Base.BaseSubResource, IHaveOverrideDynamicGroups_Boolean, IHaveStringListOfThingGroupNames
        {
            /// <summary>
            /// OverrideDynamicGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-addthingstothinggroupparams.html#cfn-iot-mitigationaction-addthingstothinggroupparams-overridedynamicgroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OverrideDynamicGroups { get; set; }
            /// <summary>
            /// ThingGroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-addthingstothinggroupparams.html#cfn-iot-mitigationaction-addthingstothinggroupparams-thinggroupnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ThingGroupNames { get; set; }
        }

        public class EnableIoTLoggingParams : Humidifier.Base.BaseSubResource, IHaveRoleArnForLogging, IHaveLogLevel
        {
            /// <summary>
            /// RoleArnForLogging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-enableiotloggingparams.html#cfn-iot-mitigationaction-enableiotloggingparams-rolearnforlogging
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArnForLogging { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-enableiotloggingparams.html#cfn-iot-mitigationaction-enableiotloggingparams-loglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }

        public class PublishFindingToSnsParams : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-publishfindingtosnsparams.html#cfn-iot-mitigationaction-publishfindingtosnsparams-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }

        public class ReplaceDefaultPolicyVersionParams : Humidifier.Base.BaseSubResource, IHaveTemplateName
        {
            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-replacedefaultpolicyversionparams.html#cfn-iot-mitigationaction-replacedefaultpolicyversionparams-templatename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateName { get; set; }
        }

        public class UpdateCACertificateParams : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-updatecacertificateparams.html#cfn-iot-mitigationaction-updatecacertificateparams-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }

        public class UpdateDeviceCertificateParams : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-updatedevicecertificateparams.html#cfn-iot-mitigationaction-updatedevicecertificateparams-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
        }
    }
}