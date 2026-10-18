namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;
    using ContainerTypes;

    public class Container : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfLightsailContainerTypesPublicDomainNamePublicDomainNames, IHaveServiceName, IHaveLightsailContainerTypesPrivateRegistryAccessPrivateRegistryAccess, IHaveLightsailContainerTypesContainerServiceDeploymentContainerServiceDeployment, IHaveIsDisabled_Boolean, IHaveScale_Integer, IHavePower
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
        public Union<IReadOnlyList<Humidifier.Lightsail.ContainerTypes.PublicDomainName>, IReadOnlyList<Union<Humidifier.Lightsail.ContainerTypes.PublicDomainName, BaseFunction>>, BaseFunction>? PublicDomainNames { get; set; }

        /// <summary>
        /// ServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-servicename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceName { get; set; }
        /// <summary>
        /// PrivateRegistryAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-privateregistryaccess
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PrivateRegistryAccess
        /// </summary>
        public Union<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess, BaseFunction>? PrivateRegistryAccess { get; set; }
        /// <summary>
        /// ContainerServiceDeployment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-containerservicedeployment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContainerServiceDeployment
        /// </summary>
        public Union<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment, BaseFunction>? ContainerServiceDeployment { get; set; }
        /// <summary>
        /// IsDisabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-isdisabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsDisabled { get; set; }

        /// <summary>
        /// Scale
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-scale
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Scale { get; set; }

        /// <summary>
        /// Power
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-power
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Power { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-container.html#cfn-lightsail-container-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ContainerTypes
    {
        public class Container : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveStringListOfCommand, IHaveListOfLightsailContainerTypesEnvironmentVariableEnvironment, IHaveListOfLightsailContainerTypesPortInfoPorts, IHaveImage
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Command { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.ContainerTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.Lightsail.ContainerTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? Environment { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortInfo
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.ContainerTypes.PortInfo>, IReadOnlyList<Union<Humidifier.Lightsail.ContainerTypes.PortInfo, BaseFunction>>, BaseFunction>? Ports { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-container.html#cfn-lightsail-container-container-image
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
        }

        public class ContainerServiceDeployment : Humidifier.Base.BaseSubResource, IHaveListOfLightsailContainerTypesContainerContainers, IHaveLightsailContainerTypesPublicEndpointPublicEndpoint
        {
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-containerservicedeployment.html#cfn-lightsail-container-containerservicedeployment-containers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Container
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lightsail.ContainerTypes.Container>, IReadOnlyList<Union<Humidifier.Lightsail.ContainerTypes.Container, BaseFunction>>, BaseFunction>? Containers { get; set; }
            /// <summary>
            /// PublicEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-containerservicedeployment.html#cfn-lightsail-container-containerservicedeployment-publicendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PublicEndpoint
            /// </summary>
            public Union<Humidifier.Lightsail.ContainerTypes.PublicEndpoint, BaseFunction>? PublicEndpoint { get; set; }
        }

        public class EcrImagePullerRole : Humidifier.Base.BaseSubResource, IHavePrincipalArn, IHaveIsActive_Boolean
        {
            /// <summary>
            /// PrincipalArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-ecrimagepullerrole.html#cfn-lightsail-container-ecrimagepullerrole-principalarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalArn { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-ecrimagepullerrole.html#cfn-lightsail-container-ecrimagepullerrole-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveVariable, IHaveValue
        {
            /// <summary>
            /// Variable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-environmentvariable.html#cfn-lightsail-container-environmentvariable-variable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Variable { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-environmentvariable.html#cfn-lightsail-container-environmentvariable-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class HealthCheckConfig : Humidifier.Base.BaseSubResource, IHavePath, IHaveTimeoutSeconds_Integer, IHaveSuccessCodes, IHaveUnhealthyThreshold_Integer, IHaveHealthyThreshold_Integer, IHaveIntervalSeconds_Integer
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// TimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-timeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutSeconds { get; set; }
            /// <summary>
            /// SuccessCodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-successcodes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuccessCodes { get; set; }
            /// <summary>
            /// UnhealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-unhealthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnhealthyThreshold { get; set; }
            /// <summary>
            /// HealthyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-healthythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HealthyThreshold { get; set; }
            /// <summary>
            /// IntervalSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-healthcheckconfig.html#cfn-lightsail-container-healthcheckconfig-intervalseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? IntervalSeconds { get; set; }
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
            public Union<string, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-portinfo.html#cfn-lightsail-container-portinfo-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class PrivateRegistryAccess : Humidifier.Base.BaseSubResource, IHaveLightsailContainerTypesEcrImagePullerRoleEcrImagePullerRole
        {
            /// <summary>
            /// EcrImagePullerRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-privateregistryaccess.html#cfn-lightsail-container-privateregistryaccess-ecrimagepullerrole
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcrImagePullerRole
            /// </summary>
            public Union<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole, BaseFunction>? EcrImagePullerRole { get; set; }
        }

        public class PublicDomainName : Humidifier.Base.BaseSubResource, IHaveCertificateName, IHaveStringListOfDomainNames
        {
            /// <summary>
            /// CertificateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicdomainname.html#cfn-lightsail-container-publicdomainname-certificatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateName { get; set; }
            /// <summary>
            /// DomainNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicdomainname.html#cfn-lightsail-container-publicdomainname-domainnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DomainNames { get; set; }
        }

        public class PublicEndpoint : Humidifier.Base.BaseSubResource, IHaveContainerName, IHaveContainerPort_Integer, IHaveLightsailContainerTypesHealthCheckConfigHealthCheckConfig
        {
            /// <summary>
            /// ContainerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-containername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerName { get; set; }
            /// <summary>
            /// ContainerPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-containerport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ContainerPort { get; set; }
            /// <summary>
            /// HealthCheckConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lightsail-container-publicendpoint.html#cfn-lightsail-container-publicendpoint-healthcheckconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HealthCheckConfig
            /// </summary>
            public Union<Humidifier.Lightsail.ContainerTypes.HealthCheckConfig, BaseFunction>? HealthCheckConfig { get; set; }
        }
    }
}