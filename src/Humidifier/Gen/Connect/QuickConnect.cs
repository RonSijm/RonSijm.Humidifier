namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using QuickConnectTypes;

    public class QuickConnect : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveInstanceArn
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
        public dynamic Description { get; set; }

        /// <summary>
        /// QuickConnectConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-quickconnectconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuickConnectConfig
        /// </summary>
        [Required]
        public Humidifier.Connect.QuickConnectTypes.QuickConnectConfig QuickConnectConfig { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-quickconnect.html#cfn-connect-quickconnect-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace QuickConnectTypes
    {
        public class PhoneNumberQuickConnectConfig : Humidifier.Base.BaseSubResource, IHavePhoneNumber
        {
            /// <summary>
            /// PhoneNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-phonenumberquickconnectconfig.html#cfn-connect-quickconnect-phonenumberquickconnectconfig-phonenumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PhoneNumber { get; set; }
        }

        public class QueueQuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveContactFlowArn
        {
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-queuequickconnectconfig.html#cfn-connect-quickconnect-queuequickconnectconfig-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactFlowArn { get; set; }
            /// <summary>
            /// QueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-queuequickconnectconfig.html#cfn-connect-quickconnect-queuequickconnectconfig-queuearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueueArn { get; set; }
        }

        public class QuickConnectConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueueConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-queueconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueueQuickConnectConfig
            /// </summary>
            public Humidifier.Connect.QuickConnectTypes.QueueQuickConnectConfig QueueConfig { get; set; }
            /// <summary>
            /// PhoneConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-phoneconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PhoneNumberQuickConnectConfig
            /// </summary>
            public Humidifier.Connect.QuickConnectTypes.PhoneNumberQuickConnectConfig PhoneConfig { get; set; }
            /// <summary>
            /// QuickConnectType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-quickconnecttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuickConnectType { get; set; }
            /// <summary>
            /// UserConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-quickconnectconfig.html#cfn-connect-quickconnect-quickconnectconfig-userconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UserQuickConnectConfig
            /// </summary>
            public Humidifier.Connect.QuickConnectTypes.UserQuickConnectConfig UserConfig { get; set; }
        }

        public class UserQuickConnectConfig : Humidifier.Base.BaseSubResource, IHaveContactFlowArn
        {
            /// <summary>
            /// UserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-userquickconnectconfig.html#cfn-connect-quickconnect-userquickconnectconfig-userarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserArn { get; set; }
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-quickconnect-userquickconnectconfig.html#cfn-connect-quickconnect-userquickconnectconfig-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactFlowArn { get; set; }
        }
    }
}