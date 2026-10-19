namespace Humidifier.LicenseManagerUserSubscriptions
{
    using global::System.Collections.Generic;
    using LicenseServerEndpointTypes;

    public class LicenseServerEndpoint : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ServerType =  "ServerType" ;
            public static string LicenseServerEndpointId =  "LicenseServerEndpointId" ;
            public static string LicenseServerEndpointArn =  "LicenseServerEndpointArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ServerEndpoint =  "ServerEndpoint" ;
            public static string LicenseServerEndpointProvisioningStatus =  "LicenseServerEndpointProvisioningStatus" ;
            public static string LicenseServers =  "LicenseServers" ;
        }

        public override string AWSTypeName { get => AWS.LicenseManagerUserSubscriptions.LicenseServerEndpoint; }

        /// <summary>
        /// IdentityProviderArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerusersubscriptions-licenseserverendpoint.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-identityproviderarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdentityProviderArn { get; set; }
        /// <summary>
        /// LicenseServerSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerusersubscriptions-licenseserverendpoint.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserversettings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: LicenseServerSettings
        /// </summary>
        public Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings LicenseServerSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-licensemanagerusersubscriptions-licenseserverendpoint.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace LicenseServerEndpointTypes
    {
        public class CredentialsProvider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManagerCredentialsProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-credentialsprovider.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-credentialsprovider-secretsmanagercredentialsprovider
            /// Required: True
            /// UpdateType: Immutable
            /// Type: SecretsManagerCredentialsProvider
            /// </summary>
            public Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider SecretsManagerCredentialsProvider { get; set; }
        }

        public class LicenseServer : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// ProvisioningStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver-provisioningstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProvisioningStatus { get; set; }
            /// <summary>
            /// HealthStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver-healthstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HealthStatus { get; set; }
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv6Address { get; set; }
            /// <summary>
            /// Ipv4Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserver-ipv4address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv4Address { get; set; }
        }

        public class LicenseServerSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserversettings.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserversettings-servertype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerType { get; set; }
            /// <summary>
            /// ServerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-licenseserversettings.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-licenseserversettings-serversettings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ServerSettings
            /// </summary>
            public Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings ServerSettings { get; set; }
        }

        public class RdsSalSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RdsSalCredentialsProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-rdssalsettings.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-rdssalsettings-rdssalcredentialsprovider
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CredentialsProvider
            /// </summary>
            public Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider RdsSalCredentialsProvider { get; set; }
        }

        public class SecretsManagerCredentialsProvider : Humidifier.Base.BaseSubResource, IHaveSecretId
        {
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-secretsmanagercredentialsprovider.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-secretsmanagercredentialsprovider-secretid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretId { get; set; }
        }

        public class ServerEndpoint : Humidifier.Base.BaseSubResource, IHaveEndpoint
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-serverendpoint.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-serverendpoint-endpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
        }

        public class ServerSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RdsSalSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanagerusersubscriptions-licenseserverendpoint-serversettings.html#cfn-licensemanagerusersubscriptions-licenseserverendpoint-serversettings-rdssalsettings
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RdsSalSettings
            /// </summary>
            public Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings RdsSalSettings { get; set; }
        }
    }
}