namespace Humidifier.ODB
{
    using global::System.Collections.Generic;
    using OdbNetworkTypes;

    public class OdbNetwork : Humidifier.Base.BaseResource, IHaveTags, IHaveDefaultDnsPrefix, IHaveCustomDomainName, IHaveStsAccess, IHaveZeroEtlAccess, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveBackupSubnetCidr, IHaveClientSubnetCidr, IHaveS3Access, IHaveStsPolicyDocument, IHaveKmsAccess, IHaveDeleteAssociatedResources_Boolean, IHaveDisplayName, IHaveS3PolicyDocument, IHaveKmsPolicyDocument, IHaveStringListOfCrossRegionS3RestoreSources
    {
        public class Attributes
        {
            public static string OdbNetworkArn =  "OdbNetworkArn" ;
            public static string OciNetworkAnchorId =  "OciNetworkAnchorId" ;
            public static string ManagedServices =  "ManagedServices" ;
            public static string OciResourceAnchorName =  "OciResourceAnchorName" ;
            public static string Ec2PlacementGroupIds =  "Ec2PlacementGroupIds" ;
            public static string OciVcnUrl =  "OciVcnUrl" ;
            public static string OdbNetworkId =  "OdbNetworkId" ;
        }

        public override string AWSTypeName { get => AWS.ODB.OdbNetwork; }
        /// <summary>
        /// DefaultDnsPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-defaultdnsprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultDnsPrefix { get; set; }
        /// <summary>
        /// CustomDomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-customdomainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomDomainName { get; set; }
        /// <summary>
        /// StsAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-stsaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StsAccess { get; set; }
        /// <summary>
        /// ZeroEtlAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-zeroetlaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ZeroEtlAccess { get; set; }
        /// <summary>
        /// AvailabilityZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-availabilityzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// BackupSubnetCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-backupsubnetcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BackupSubnetCidr { get; set; }
        /// <summary>
        /// ClientSubnetCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-clientsubnetcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientSubnetCidr { get; set; }
        /// <summary>
        /// S3Access
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-s3access
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3Access { get; set; }
        /// <summary>
        /// StsPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-stspolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StsPolicyDocument { get; set; }
        /// <summary>
        /// KmsAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-kmsaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsAccess { get; set; }
        /// <summary>
        /// DeleteAssociatedResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-deleteassociatedresources
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeleteAssociatedResources { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// S3PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-s3policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? S3PolicyDocument { get; set; }
        /// <summary>
        /// KmsPolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-kmspolicydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsPolicyDocument { get; set; }
        /// <summary>
        /// CrossRegionS3RestoreSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-crossregions3restoresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CrossRegionS3RestoreSources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbnetwork.html#cfn-odb-odbnetwork-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OdbNetworkTypes
    {
        public class CrossRegionS3RestoreSourcesAccess : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfIpv4Addresses, IHaveRegion
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-crossregions3restoresourcesaccess.html#cfn-odb-odbnetwork-crossregions3restoresourcesaccess-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Ipv4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-crossregions3restoresourcesaccess.html#cfn-odb-odbnetwork-crossregions3restoresourcesaccess-ipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv4Addresses { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-crossregions3restoresourcesaccess.html#cfn-odb-odbnetwork-crossregions3restoresourcesaccess-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class KmsAccess : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfIpv4Addresses, IHaveDomainName, IHaveKmsPolicyDocument
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-kmsaccess.html#cfn-odb-odbnetwork-kmsaccess-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Ipv4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-kmsaccess.html#cfn-odb-odbnetwork-kmsaccess-ipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv4Addresses { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-kmsaccess.html#cfn-odb-odbnetwork-kmsaccess-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// KmsPolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-kmsaccess.html#cfn-odb-odbnetwork-kmsaccess-kmspolicydocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsPolicyDocument { get; set; }
        }

        public class ManagedS3BackupAccess : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfIpv4Addresses
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-manageds3backupaccess.html#cfn-odb-odbnetwork-manageds3backupaccess-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Ipv4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-manageds3backupaccess.html#cfn-odb-odbnetwork-manageds3backupaccess-ipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv4Addresses { get; set; }
        }

        public class ManagedServices : Humidifier.Base.BaseSubResource, IHaveStringListOfManagedServicesIpv4Cidrs, IHaveODBOdbNetworkTypesKmsAccessKmsAccess, IHaveResourceGatewayArn, IHaveODBOdbNetworkTypesManagedS3BackupAccessManagedS3BackupAccess, IHaveODBOdbNetworkTypesServiceNetworkEndpointServiceNetworkEndpoint, IHaveODBOdbNetworkTypesZeroEtlAccessZeroEtlAccess, IHaveODBOdbNetworkTypesStsAccessStsAccess, IHaveListOfODBOdbNetworkTypesCrossRegionS3RestoreSourcesAccessCrossRegionS3RestoreSourcesAccess, IHaveServiceNetworkArn, IHaveODBOdbNetworkTypesS3AccessS3Access
        {
            /// <summary>
            /// ManagedServicesIpv4Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-managedservicesipv4cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedServicesIpv4Cidrs { get; set; }
            /// <summary>
            /// KmsAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-kmsaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsAccess
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.KmsAccess, BaseFunction>? KmsAccess { get; set; }
            /// <summary>
            /// ResourceGatewayArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-resourcegatewayarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceGatewayArn { get; set; }
            /// <summary>
            /// ManagedS3BackupAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-manageds3backupaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedS3BackupAccess
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.ManagedS3BackupAccess, BaseFunction>? ManagedS3BackupAccess { get; set; }
            /// <summary>
            /// ServiceNetworkEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-servicenetworkendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNetworkEndpoint
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.ServiceNetworkEndpoint, BaseFunction>? ServiceNetworkEndpoint { get; set; }
            /// <summary>
            /// ZeroEtlAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-zeroetlaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZeroEtlAccess
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.ZeroEtlAccess, BaseFunction>? ZeroEtlAccess { get; set; }
            /// <summary>
            /// StsAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-stsaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StsAccess
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.StsAccess, BaseFunction>? StsAccess { get; set; }
            /// <summary>
            /// CrossRegionS3RestoreSourcesAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-crossregions3restoresourcesaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CrossRegionS3RestoreSourcesAccess
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ODB.OdbNetworkTypes.CrossRegionS3RestoreSourcesAccess>, IReadOnlyList<Union<Humidifier.ODB.OdbNetworkTypes.CrossRegionS3RestoreSourcesAccess, BaseFunction>>, BaseFunction>? CrossRegionS3RestoreSourcesAccess { get; set; }
            /// <summary>
            /// ServiceNetworkArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-servicenetworkarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNetworkArn { get; set; }
            /// <summary>
            /// S3Access
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-managedservices.html#cfn-odb-odbnetwork-managedservices-s3access
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Access
            /// </summary>
            public Union<Humidifier.ODB.OdbNetworkTypes.S3Access, BaseFunction>? S3Access { get; set; }
        }

        public class S3Access : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfIpv4Addresses, IHaveDomainName, IHaveS3PolicyDocument
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-s3access.html#cfn-odb-odbnetwork-s3access-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Ipv4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-s3access.html#cfn-odb-odbnetwork-s3access-ipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv4Addresses { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-s3access.html#cfn-odb-odbnetwork-s3access-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// S3PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-s3access.html#cfn-odb-odbnetwork-s3access-s3policydocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3PolicyDocument { get; set; }
        }

        public class ServiceNetworkEndpoint : Humidifier.Base.BaseSubResource, IHaveVpcEndpointType, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcEndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-servicenetworkendpoint.html#cfn-odb-odbnetwork-servicenetworkendpoint-vpcendpointtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointType { get; set; }
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-servicenetworkendpoint.html#cfn-odb-odbnetwork-servicenetworkendpoint-vpcendpointid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class StsAccess : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveStringListOfIpv4Addresses, IHaveDomainName, IHaveStsPolicyDocument
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-stsaccess.html#cfn-odb-odbnetwork-stsaccess-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Ipv4Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-stsaccess.html#cfn-odb-odbnetwork-stsaccess-ipv4addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Ipv4Addresses { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-stsaccess.html#cfn-odb-odbnetwork-stsaccess-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainName { get; set; }
            /// <summary>
            /// StsPolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-stsaccess.html#cfn-odb-odbnetwork-stsaccess-stspolicydocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StsPolicyDocument { get; set; }
        }

        public class ZeroEtlAccess : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCidr
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-zeroetlaccess.html#cfn-odb-odbnetwork-zeroetlaccess-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-odb-odbnetwork-zeroetlaccess.html#cfn-odb-odbnetwork-zeroetlaccess-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }
    }
}