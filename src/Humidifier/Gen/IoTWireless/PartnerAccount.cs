namespace Humidifier.IoTWireless
{
    using System.Collections.Generic;
    using PartnerAccountTypes;

    public class PartnerAccount : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Fingerprint =  "Fingerprint" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.PartnerAccount; }
        /// <summary>
        /// PartnerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-partnertype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PartnerType { get; set; }
        /// <summary>
        /// SidewalkResponse
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-sidewalkresponse
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SidewalkAccountInfoWithFingerprint
        /// </summary>
        public Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint SidewalkResponse { get; set; }
        /// <summary>
        /// AccountLinked
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-accountlinked
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AccountLinked { get; set; }
        /// <summary>
        /// Sidewalk
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-sidewalk
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SidewalkAccountInfo
        /// </summary>
        public Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfo Sidewalk { get; set; }
        /// <summary>
        /// PartnerAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-partneraccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PartnerAccountId { get; set; }
        /// <summary>
        /// SidewalkUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-sidewalkupdate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SidewalkUpdateAccount
        /// </summary>
        public Humidifier.IoTWireless.PartnerAccountTypes.SidewalkUpdateAccount SidewalkUpdate { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-partneraccount.html#cfn-iotwireless-partneraccount-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PartnerAccountTypes
    {
        public class SidewalkAccountInfo : Humidifier.Base.BaseSubResource, IHaveAppServerPrivateKey
        {
            /// <summary>
            /// AppServerPrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkaccountinfo.html#cfn-iotwireless-partneraccount-sidewalkaccountinfo-appserverprivatekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppServerPrivateKey { get; set; }
        }

        public class SidewalkAccountInfoWithFingerprint : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Fingerprint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint.html#cfn-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint-fingerprint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Fingerprint { get; set; }
            /// <summary>
            /// AmazonId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint.html#cfn-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint-amazonid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint.html#cfn-iotwireless-partneraccount-sidewalkaccountinfowithfingerprint-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class SidewalkUpdateAccount : Humidifier.Base.BaseSubResource, IHaveAppServerPrivateKey
        {
            /// <summary>
            /// AppServerPrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-partneraccount-sidewalkupdateaccount.html#cfn-iotwireless-partneraccount-sidewalkupdateaccount-appserverprivatekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppServerPrivateKey { get; set; }
        }
    }
}