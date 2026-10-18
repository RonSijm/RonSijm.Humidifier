namespace Humidifier.DirectoryService
{
    using global::System.Collections.Generic;
    using MicrosoftADTypes;

    public class MicrosoftAD : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDirectoryServiceMicrosoftADTypesVpcSettingsVpcSettings, IHaveCreateAlias_Boolean, IHaveEnableSso_Boolean, IHaveShortName, IHaveEdition, IHaveName, IHavePassword
    {
        public class Attributes
        {
            public static string DirectoryId =  "DirectoryId" ;
            public static string Alias =  "Alias" ;
            public static string DnsIpAddresses =  "DnsIpAddresses" ;
        }

        public override string AWSTypeName { get => AWS.DirectoryService.MicrosoftAD; }

        /// <summary>
        /// VpcSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-vpcsettings
        /// Required: True
        /// UpdateType: Immutable
        /// Type: VpcSettings
        /// </summary>
        [Required]
        public Union<Humidifier.DirectoryService.MicrosoftADTypes.VpcSettings, BaseFunction>? VpcSettings { get; set; }
        /// <summary>
        /// CreateAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-createalias
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CreateAlias { get; set; }
        /// <summary>
        /// EnableSso
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-enablesso
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSso { get; set; }
        /// <summary>
        /// ShortName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-shortname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ShortName { get; set; }
        /// <summary>
        /// Edition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-edition
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Edition { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-microsoftad.html#cfn-directoryservice-microsoftad-password
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Password { get; set; }
    }

    namespace MicrosoftADTypes
    {
        public class VpcSettings : Humidifier.Base.BaseSubResource, IHaveVpcId, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-microsoftad-vpcsettings.html#cfn-directoryservice-microsoftad-vpcsettings-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-microsoftad-vpcsettings.html#cfn-directoryservice-microsoftad-vpcsettings-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}