namespace Humidifier.PCAConnectorAD
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveCertificateAuthorityArn, IHaveDirectoryId, IHavePCAConnectorADConnectorTypesVpcInformationVpcInformation, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
        }

        public override string AWSTypeName { get => AWS.PCAConnectorAD.Connector; }

        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-connector.html#cfn-pcaconnectorad-connector-certificateauthorityarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-connector.html#cfn-pcaconnectorad-connector-directoryid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectoryId { get; set; }

        /// <summary>
        /// VpcInformation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-connector.html#cfn-pcaconnectorad-connector-vpcinformation
        /// Required: True
        /// UpdateType: Immutable
        /// Type: VpcInformation
        /// </summary>
        [Required]
        public Union<Humidifier.PCAConnectorAD.ConnectorTypes.VpcInformation, BaseFunction>? VpcInformation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorad-connector.html#cfn-pcaconnectorad-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectorTypes
    {
        public class VpcInformation : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-connector-vpcinformation.html#cfn-pcaconnectorad-connector-vpcinformation-ipaddresstype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorad-connector-vpcinformation.html#cfn-pcaconnectorad-connector-vpcinformation-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}