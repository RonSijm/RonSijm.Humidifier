namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using DLPSettingTypes;

    public class DLPSetting : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveEnabled, IHaveAwsAccountId, IHaveProviderType
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.DLPSetting; }

        /// <summary>
        /// DlpSettingId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-dlpsettingid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DlpSettingId { get; set; }

        /// <summary>
        /// ProviderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-providerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ProviderConfig
        /// </summary>
        [Required]
        public Humidifier.QuickSight.DLPSettingTypes.ProviderConfig ProviderConfig { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AwsAccountId { get; set; }

        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-enabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic Enabled { get; set; }

        /// <summary>
        /// ProviderOutageAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-provideroutageaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProviderOutageAction { get; set; }

        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-providertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DLPSettingTypes
    {
        public class LabelActionMapping : Humidifier.Base.BaseSubResource, IHaveAction
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelName { get; set; }
            /// <summary>
            /// LabelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-labelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LabelId { get; set; }
        }

        public class MicrosoftPurviewCredentials : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewcredentials.html#cfn-quicksight-dlpsetting-microsoftpurviewcredentials-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
        }

        public class MicrosoftPurviewProviderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LabelActionMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-labelactionmappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LabelActionMapping
            /// </summary>
            public List<Humidifier.QuickSight.DLPSettingTypes.LabelActionMapping> LabelActionMappings { get; set; }
            /// <summary>
            /// UnmappedAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-unmappedaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnmappedAction { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-credentials
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MicrosoftPurviewCredentials
            /// </summary>
            public Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials Credentials { get; set; }
        }

        public class ProviderConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MicrosoftPurview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-providerconfig.html#cfn-quicksight-dlpsetting-providerconfig-microsoftpurview
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MicrosoftPurviewProviderConfig
            /// </summary>
            public Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig MicrosoftPurview { get; set; }
        }
    }
}