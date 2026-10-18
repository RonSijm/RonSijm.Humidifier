namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using QueueTypes;

    public class Queue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveHoursOfOperationArn, IHaveDescription, IHaveStringListOfQuickConnectArns, IHaveInstanceArn, IHaveConnectQueueTypesOutboundEmailConfigOutboundEmailConfig, IHaveConnectQueueTypesOutboundCallerConfigOutboundCallerConfig, IHaveListOfConnectQueueTypesEmailAddressAdditionalEmailAddresses, IHaveMaxContacts_Integer, IHaveName
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string QueueArn =  "QueueArn" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Queue; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// HoursOfOperationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-hoursofoperationarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? HoursOfOperationArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// QuickConnectArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-quickconnectarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? QuickConnectArns { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// OutboundEmailConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-outboundemailconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutboundEmailConfig
        /// </summary>
        public Union<Humidifier.Connect.QueueTypes.OutboundEmailConfig, BaseFunction>? OutboundEmailConfig { get; set; }
        /// <summary>
        /// OutboundCallerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-outboundcallerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutboundCallerConfig
        /// </summary>
        public Union<Humidifier.Connect.QueueTypes.OutboundCallerConfig, BaseFunction>? OutboundCallerConfig { get; set; }
        /// <summary>
        /// AdditionalEmailAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-additionalemailaddresses
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EmailAddress
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.QueueTypes.EmailAddress>, IReadOnlyList<Union<Humidifier.Connect.QueueTypes.EmailAddress, BaseFunction>>, BaseFunction>? AdditionalEmailAddresses { get; set; }
        /// <summary>
        /// MaxContacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-maxcontacts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxContacts { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-queue.html#cfn-connect-queue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QueueTypes
    {
        public class EmailAddress : Humidifier.Base.BaseSubResource, IHaveEmailAddressArn
        {
            /// <summary>
            /// EmailAddressArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-queue-emailaddress.html#cfn-connect-queue-emailaddress-emailaddressarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmailAddressArn { get; set; }
        }

        public class OutboundCallerConfig : Humidifier.Base.BaseSubResource, IHaveOutboundCallerIdNumberArn, IHaveOutboundFlowArn, IHaveOutboundCallerIdName
        {
            /// <summary>
            /// OutboundCallerIdNumberArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-queue-outboundcallerconfig.html#cfn-connect-queue-outboundcallerconfig-outboundcalleridnumberarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutboundCallerIdNumberArn { get; set; }
            /// <summary>
            /// OutboundFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-queue-outboundcallerconfig.html#cfn-connect-queue-outboundcallerconfig-outboundflowarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutboundFlowArn { get; set; }
            /// <summary>
            /// OutboundCallerIdName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-queue-outboundcallerconfig.html#cfn-connect-queue-outboundcallerconfig-outboundcalleridname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutboundCallerIdName { get; set; }
        }

        public class OutboundEmailConfig : Humidifier.Base.BaseSubResource, IHaveOutboundEmailAddressId
        {
            /// <summary>
            /// OutboundEmailAddressId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-queue-outboundemailconfig.html#cfn-connect-queue-outboundemailconfig-outboundemailaddressid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutboundEmailAddressId { get; set; }
        }
    }
}