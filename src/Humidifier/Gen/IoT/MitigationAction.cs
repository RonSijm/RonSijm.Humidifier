namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using MitigationActionTypes;

    public class MitigationAction : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn, IHaveActionName
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
        public dynamic ActionName { get; set; }

        /// <summary>
        /// ActionParams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-actionparams
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ActionParams
        /// </summary>
        [Required]
        public Humidifier.IoT.MitigationActionTypes.ActionParams ActionParams { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html#cfn-iot-mitigationaction-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace MitigationActionTypes
    {
        public class ActionParams : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UpdateDeviceCertificateParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-updatedevicecertificateparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateDeviceCertificateParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.UpdateDeviceCertificateParams UpdateDeviceCertificateParams { get; set; }
            /// <summary>
            /// AddThingsToThingGroupParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-addthingstothinggroupparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddThingsToThingGroupParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.AddThingsToThingGroupParams AddThingsToThingGroupParams { get; set; }
            /// <summary>
            /// PublishFindingToSnsParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-publishfindingtosnsparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublishFindingToSnsParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.PublishFindingToSnsParams PublishFindingToSnsParams { get; set; }
            /// <summary>
            /// EnableIoTLoggingParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-enableiotloggingparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnableIoTLoggingParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.EnableIoTLoggingParams EnableIoTLoggingParams { get; set; }
            /// <summary>
            /// ReplaceDefaultPolicyVersionParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-replacedefaultpolicyversionparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplaceDefaultPolicyVersionParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.ReplaceDefaultPolicyVersionParams ReplaceDefaultPolicyVersionParams { get; set; }
            /// <summary>
            /// UpdateCACertificateParams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-actionparams.html#cfn-iot-mitigationaction-actionparams-updatecacertificateparams
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpdateCACertificateParams
            /// </summary>
            public Humidifier.IoT.MitigationActionTypes.UpdateCACertificateParams UpdateCACertificateParams { get; set; }
        }

        public class AddThingsToThingGroupParams : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OverrideDynamicGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-addthingstothinggroupparams.html#cfn-iot-mitigationaction-addthingstothinggroupparams-overridedynamicgroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic OverrideDynamicGroups { get; set; }
            /// <summary>
            /// ThingGroupNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-addthingstothinggroupparams.html#cfn-iot-mitigationaction-addthingstothinggroupparams-thinggroupnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ThingGroupNames { get; set; }
        }

        public class EnableIoTLoggingParams : Humidifier.Base.BaseSubResource, IHaveLogLevel
        {
            /// <summary>
            /// RoleArnForLogging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-enableiotloggingparams.html#cfn-iot-mitigationaction-enableiotloggingparams-rolearnforlogging
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArnForLogging { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-mitigationaction-enableiotloggingparams.html#cfn-iot-mitigationaction-enableiotloggingparams-loglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
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
            public dynamic TopicArn { get; set; }
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
            public dynamic TemplateName { get; set; }
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
            public dynamic Action { get; set; }
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
            public dynamic Action { get; set; }
        }
    }
}