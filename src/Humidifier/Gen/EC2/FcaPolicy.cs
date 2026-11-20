namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using FcaPolicyTypes;

    public class FcaPolicy : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string FcaPolicyId =  "FcaPolicyId" ;
            public static string LatestVersion =  "LatestVersion" ;
            public static string PolicyCreatedAt =  "PolicyCreatedAt" ;
            public static string OwnerAccount =  "OwnerAccount" ;
            public static string Arn =  "Arn" ;
            public static string VersionExpectedEffectiveAt =  "VersionExpectedEffectiveAt" ;
        }

        public override string AWSTypeName { get => AWS.EC2.FcaPolicy; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// PcxFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-pcxfcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PcxFcaPolicyDocument
        /// </summary>
        public Humidifier.EC2.FcaPolicyTypes.PcxFcaPolicyDocument PcxFcaPolicyDocument { get; set; }
        /// <summary>
        /// InstanceFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-instancefcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceFcaPolicyDocument
        /// </summary>
        public Humidifier.EC2.FcaPolicyTypes.InstanceFcaPolicyDocument InstanceFcaPolicyDocument { get; set; }
        /// <summary>
        /// ShowBackEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-showbackenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ShowBackEnabled { get; set; }
        /// <summary>
        /// NatFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-natfcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NatFcaPolicyDocument
        /// </summary>
        public Humidifier.EC2.FcaPolicyTypes.NatFcaPolicyDocument NatFcaPolicyDocument { get; set; }

        /// <summary>
        /// NetworkResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-networkresourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkResourceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FcaPolicyTypes
    {
        public class CidrMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CidrRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrmapping.html#cfn-ec2-fcapolicy-cidrmapping-cidrrange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CidrRange { get; set; }
            /// <summary>
            /// CidrLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrmapping.html#cfn-ec2-fcapolicy-cidrmapping-cidrlabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CidrLabel { get; set; }
        }

        public class CidrRangeSpecifications : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrefixesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrrangespecifications.html#cfn-ec2-fcapolicy-cidrrangespecifications-prefixestype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrefixesType { get; set; }
            /// <summary>
            /// Prefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrrangespecifications.html#cfn-ec2-fcapolicy-cidrrangespecifications-prefixes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CidrMapping
            /// </summary>
            public List<Humidifier.EC2.FcaPolicyTypes.CidrMapping> Prefixes { get; set; }
        }

        public class InstanceFcaPolicyDocument : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications CidrRangeSpecifications { get; set; }
        }

        public class NatFcaPolicyDocument : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications CidrRangeSpecifications { get; set; }
        }

        public class PcxFcaPolicyDocument : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications CidrRangeSpecifications { get; set; }
        }
    }
}