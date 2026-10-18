namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using QuickConnectTypes;

    public class QuickConnect : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveConnectQuickConnectTypesQuickConnectConfigQuickConnectConfig, IHaveInstanceArn, IHaveName
    {
        public class Attributes
        {
            public static string QuickConnectArn =  "QuickConnectArn" ;
            public static string QuickConnectType =  "QuickConnectType" ;
        }

        public override string AWSTypeName { get => AWS.Connect.QuickConnect; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// QuickConnectConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-quickconnectconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuickConnectConfig
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.QuickConnectTypes.QuickConnectConfig, BaseFunction>? QuickConnectConfig { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QuickConnectTypes
    {
        public class FlowQuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveContactFlowArn
        {
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-flowquickconnectconfig.html#cfn-connect-quickconnect-flowquickconnectconfig-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactFlowArn { get; set; }
        }

        public class PhoneNumberQuickConnectConfig : Humidifier.Base.BaseSubResource, IHavePhoneNumber
        {
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-phonenumberquickconnectconfig.html#cfn-connect-quickconnect-phonenumberquickconnectconfig-phonenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhoneNumber { get; set; }
        }

        public class QueueQuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveContactFlowArn, IHaveQueueArn
        {
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-queuequickconnectconfig.html#cfn-connect-quickconnect-queuequickconnectconfig-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactFlowArn { get; set; }
            /// <summary>
            /// QueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-queuequickconnectconfig.html#cfn-connect-quickconnect-queuequickconnectconfig-queuearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueArn { get; set; }
        }

        public class QuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveConnectQuickConnectTypesFlowQuickConnectConfigFlowConfig, IHaveConnectQuickConnectTypesQueueQuickConnectConfigQueueConfig, IHaveConnectQuickConnectTypesPhoneNumberQuickConnectConfigPhoneConfig, IHaveQuickConnectType, IHaveConnectQuickConnectTypesUserQuickConnectConfigUserConfig
        {
            /// <summary>
            /// FlowConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-flowconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FlowQuickConnectConfig
            /// </summary>
            public Union<Humidifier.Connect.QuickConnectTypes.FlowQuickConnectConfig, BaseFunction>? FlowConfig { get; set; }
            /// <summary>
            /// QueueConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-queueconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueueQuickConnectConfig
            /// </summary>
            public Union<Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig, BaseFunction>? QueueConfig { get; set; }
            /// <summary>
            /// PhoneConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-phoneconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PhoneNumberQuickConnectConfig
            /// </summary>
            public Union<Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig, BaseFunction>? PhoneConfig { get; set; }
            /// <summary>
            /// QuickConnectType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-quickconnecttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuickConnectType { get; set; }
            /// <summary>
            /// UserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-userconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserQuickConnectConfig
            /// </summary>
            public Union<Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig, BaseFunction>? UserConfig { get; set; }
        }

        public class UserQuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveUserArn, IHaveContactFlowArn
        {
            /// <summary>
            /// UserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-userquickconnectconfig.html#cfn-connect-quickconnect-userquickconnectconfig-userarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserArn { get; set; }
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-userquickconnectconfig.html#cfn-connect-quickconnect-userquickconnectconfig-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactFlowArn { get; set; }
        }
    }
}