namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using FcaPolicyTypes;

    public class FcaPolicy : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveEC2FcaPolicyTypesPcxFcaPolicyDocumentPcxFcaPolicyDocument, IHaveEC2FcaPolicyTypesInstanceFcaPolicyDocumentInstanceFcaPolicyDocument, IHaveShowBackEnabled_Boolean, IHaveEC2FcaPolicyTypesNatFcaPolicyDocumentNatFcaPolicyDocument, IHaveNetworkResourceType
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PcxFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-pcxfcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PcxFcaPolicyDocument
        /// </summary>
        public Union<Humidifier.EC2.FcaPolicyTypes.PcxFcaPolicyDocument, BaseFunction>? PcxFcaPolicyDocument { get; set; }
        /// <summary>
        /// InstanceFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-instancefcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceFcaPolicyDocument
        /// </summary>
        public Union<Humidifier.EC2.FcaPolicyTypes.InstanceFcaPolicyDocument, BaseFunction>? InstanceFcaPolicyDocument { get; set; }
        /// <summary>
        /// ShowBackEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-showbackenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ShowBackEnabled { get; set; }
        /// <summary>
        /// NatFcaPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-natfcapolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NatFcaPolicyDocument
        /// </summary>
        public Union<Humidifier.EC2.FcaPolicyTypes.NatFcaPolicyDocument, BaseFunction>? NatFcaPolicyDocument { get; set; }

        /// <summary>
        /// NetworkResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-networkresourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkResourceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-fcapolicy.html#cfn-ec2-fcapolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FcaPolicyTypes
    {
        public class CidrMapping : Humidifier.Base.BaseSubResource, IHaveCidrRange, IHaveCidrLabel
        {
            /// <summary>
            /// CidrRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrmapping.html#cfn-ec2-fcapolicy-cidrmapping-cidrrange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrRange { get; set; }
            /// <summary>
            /// CidrLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrmapping.html#cfn-ec2-fcapolicy-cidrmapping-cidrlabel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrLabel { get; set; }
        }

        public class CidrRangeSpecifications : Humidifier.Base.BaseSubResource, IHavePrefixesType, IHaveListOfEC2FcaPolicyTypesCidrMappingPrefixes
        {
            /// <summary>
            /// PrefixesType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrrangespecifications.html#cfn-ec2-fcapolicy-cidrrangespecifications-prefixestype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixesType { get; set; }
            /// <summary>
            /// Prefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-cidrrangespecifications.html#cfn-ec2-fcapolicy-cidrrangespecifications-prefixes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CidrMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.FcaPolicyTypes.CidrMapping>, IReadOnlyList<Union<Humidifier.EC2.FcaPolicyTypes.CidrMapping, BaseFunction>>, BaseFunction>? Prefixes { get; set; }
        }

        public class InstanceFcaPolicyDocument : Humidifier.Base.BaseSubResource, IHaveStringListOfDimensions, IHaveStringListOfReportingGranularity, IHaveEC2FcaPolicyTypesCidrRangeSpecificationsCidrRangeSpecifications
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-instancefcapolicydocument.html#cfn-ec2-fcapolicy-instancefcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Union<Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications, BaseFunction>? CidrRangeSpecifications { get; set; }
        }

        public class NatFcaPolicyDocument : Humidifier.Base.BaseSubResource, IHaveStringListOfDimensions, IHaveStringListOfReportingGranularity, IHaveEC2FcaPolicyTypesCidrRangeSpecificationsCidrRangeSpecifications
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-natfcapolicydocument.html#cfn-ec2-fcapolicy-natfcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Union<Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications, BaseFunction>? CidrRangeSpecifications { get; set; }
        }

        public class PcxFcaPolicyDocument : Humidifier.Base.BaseSubResource, IHaveStringListOfDimensions, IHaveStringListOfReportingGranularity, IHaveEC2FcaPolicyTypesCidrRangeSpecificationsCidrRangeSpecifications
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-dimensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// ReportingGranularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-reportinggranularity
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReportingGranularity { get; set; }
            /// <summary>
            /// CidrRangeSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-fcapolicy-pcxfcapolicydocument.html#cfn-ec2-fcapolicy-pcxfcapolicydocument-cidrrangespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CidrRangeSpecifications
            /// </summary>
            public Union<Humidifier.EC2.FcaPolicyTypes.CidrRangeSpecifications, BaseFunction>? CidrRangeSpecifications { get; set; }
        }
    }
}