namespace Humidifier.Lightsail
{
    using System.Collections.Generic;
    using ContainerTypes;

    public class Container : Humidifier.Base.BaseResource, IHaveTags, IHaveServiceName, IHaveScale
    {
        public class Attributes
        {
            public static string PrincipalArn =  "PrincipalArn" ;
            public static string ContainerArn =  "ContainerArn" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Container; }
        /// <summary>
        /// PublicDomainNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-publicdomainnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PublicDomainName
        /// </summary>
        public List<Humidifier.Lightsail.ContainerTypes.PublicDomainName> PublicDomainNames { get; set; }

        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-servicename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceName { get; set; }
        /// <summary>
        /// PrivateRegistryAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-privateregistryaccess
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateRegistryAccess
        /// </summary>
        public Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess PrivateRegistryAccess { get; set; }
        /// <summary>
        /// ContainerServiceDeployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-containerservicedeployment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContainerServiceDeployment
        /// </summary>
        public Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment ContainerServiceDeployment { get; set; }
        /// <summary>
        /// IsDisabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-isdisabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsDisabled { get; set; }

        /// <summary>
        /// Scale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-scale
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Scale { get; set; }

        /// <summary>
        /// Power
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-power
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Power { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ContainerTypes
    {
        public class Container : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveImage, IHaveCommand
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public List<Humidifier.Lightsail.ContainerTypes.EnvironmentVariable> Environment { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortInfo
            /// </summary>
            public List<Humidifier.Lightsail.ContainerTypes.PortInfo> Ports { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
        }

        public class ContainerServiceDeployment : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-containerservicedeployment.html#cfn-lightsail-container-containerservicedeployment-containers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Container
            /// </summary>
            public List<Humidifier.Lightsail.ContainerTypes.Container> Containers { get; set; }
            /// <summary>
            /// PublicEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-containerservicedeployment.html#cfn-lightsail-container-containerservicedeployment-publicendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicEndpoint
            /// </summary>
            public Humidifier.Lightsail.ContainerTypes.PublicEndpoint PublicEndpoint { get; set; }
        }

        public class EcrImagePullerRole : Humidifier.Base.BaseSubResource, IHaveIsActive, IHavePrincipalArn
        {
            /// <summary>
            /// PrincipalArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-ecrimagepullerrole.html#cfn-lightsail-container-ecrimagepullerrole-principalarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrincipalArn { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-ecrimagepullerrole.html#cfn-lightsail-container-ecrimagepullerrole-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveVariable
        {
            /// <summary>
            /// Variable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-environmentvariable.html#cfn-lightsail-container-environmentvariable-variable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Variable { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-environmentvariable.html#cfn-lightsail-container-environmentvariable-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class HealthCheckConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveUnhealthyThreshold, IHaveHealthyThreshold, IHaveTimeoutSeconds
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutSeconds { get; set; }
            /// <summary>
            /// SuccessCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-successcodes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SuccessCodes { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-unhealthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UnhealthyThreshold { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-healthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HealthyThreshold { get; set; }
            /// <summary>
            /// IntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-intervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalSeconds { get; set; }
        }

        public class PortInfo : Humidifier.Base.BaseSubResource, IHavePort, IHaveProtocol
        {
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-portinfo.html#cfn-lightsail-container-portinfo-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-portinfo.html#cfn-lightsail-container-portinfo-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }

        public class PrivateRegistryAccess : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EcrImagePullerRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-privateregistryaccess.html#cfn-lightsail-container-privateregistryaccess-ecrimagepullerrole
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcrImagePullerRole
            /// </summary>
            public Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole EcrImagePullerRole { get; set; }
        }

        public class PublicDomainName : Humidifier.Base.BaseSubResource, IHaveCertificateName
        {
            /// <summary>
            /// CertificateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicdomainname.html#cfn-lightsail-container-publicdomainname-certificatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateName { get; set; }
            /// <summary>
            /// DomainNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicdomainname.html#cfn-lightsail-container-publicdomainname-domainnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DomainNames { get; set; }
        }

        public class PublicEndpoint : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveContainerPort
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ContainerPort { get; set; }
            /// <summary>
            /// HealthCheckConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-healthcheckconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HealthCheckConfig
            /// </summary>
            public Humidifier.Lightsail.ContainerTypes.HealthCheckConfig HealthCheckConfig { get; set; }
        }
    }
}