namespace Humidifier.PCAConnectorSCEP
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveCertificateAuthorityArn, IHavePCAConnectorSCEPConnectorTypesMobileDeviceManagementMobileDeviceManagement, IHaveVpcEndpointId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
            public static string Type =  "Type" ;
            public static string Endpoint =  "Endpoint" ;
            public static string OpenIdConfiguration =  "OpenIdConfiguration" ;
        }

        public override string AWSTypeName { get => AWS.PCAConnectorSCEP.Connector; }

        /// <summary>
        /// CertificateAuthorityArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-connector.html#cfn-pcaconnectorscep-connector-certificateauthorityarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CertificateAuthorityArn { get; set; }
        /// <summary>
        /// MobileDeviceManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-connector.html#cfn-pcaconnectorscep-connector-mobiledevicemanagement
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MobileDeviceManagement
        /// </summary>
        public Union<Humidifier.PCAConnectorSCEP.ConnectorTypes.MobileDeviceManagement, BaseFunction>? MobileDeviceManagement { get; set; }
        /// <summary>
        /// VpcEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-connector.html#cfn-pcaconnectorscep-connector-vpcendpointid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pcaconnectorscep-connector.html#cfn-pcaconnectorscep-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectorTypes
    {
        public class IntuneConfiguration : Humidifier.Base.BaseSubResource, IHaveAzureApplicationId, IHaveDomain
        {
            /// <summary>
            /// AzureApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-intuneconfiguration.html#cfn-pcaconnectorscep-connector-intuneconfiguration-azureapplicationid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AzureApplicationId { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-intuneconfiguration.html#cfn-pcaconnectorscep-connector-intuneconfiguration-domain
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class MobileDeviceManagement : Humidifier.Base.BaseSubResource, IHavePCAConnectorSCEPConnectorTypesIntuneConfigurationIntune
        {
            /// <summary>
            /// Intune
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-mobiledevicemanagement.html#cfn-pcaconnectorscep-connector-mobiledevicemanagement-intune
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IntuneConfiguration
            /// </summary>
            public Union<Humidifier.PCAConnectorSCEP.ConnectorTypes.IntuneConfiguration, BaseFunction>? Intune { get; set; }
        }

        public class OpenIdConfiguration : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveAudience, IHaveSubject
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-openidconfiguration.html#cfn-pcaconnectorscep-connector-openidconfiguration-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// Audience
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-openidconfiguration.html#cfn-pcaconnectorscep-connector-openidconfiguration-audience
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Audience { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pcaconnectorscep-connector-openidconfiguration.html#cfn-pcaconnectorscep-connector-openidconfiguration-subject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
        }
    }
}