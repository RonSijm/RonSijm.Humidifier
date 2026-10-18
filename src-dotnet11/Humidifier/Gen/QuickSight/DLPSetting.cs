namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using DLPSettingTypes;

    public class DLPSetting : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDlpSettingId, IHaveQuickSightDLPSettingTypesProviderConfigProviderConfig, IHaveAwsAccountId, IHaveEnabled_Boolean, IHaveProviderOutageAction, IHaveProviderType, IHaveName
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
        public Union<string, BaseFunction>? DlpSettingId { get; set; }

        /// <summary>
        /// ProviderConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-providerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ProviderConfig
        /// </summary>
        [Required]
        public Union<Humidifier.QuickSight.DLPSettingTypes.ProviderConfig, BaseFunction>? ProviderConfig { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }

        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-enabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? Enabled { get; set; }

        /// <summary>
        /// ProviderOutageAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-provideroutageaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProviderOutageAction { get; set; }

        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-providertype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProviderType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-dlpsetting.html#cfn-quicksight-dlpsetting-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DLPSettingTypes
    {
        public class LabelActionMapping : Humidifier.Base.BaseSubResource, IHaveAction, IHaveLabelName, IHaveLabelId
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// LabelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-labelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelName { get; set; }
            /// <summary>
            /// LabelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-labelactionmapping.html#cfn-quicksight-dlpsetting-labelactionmapping-labelid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LabelId { get; set; }
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
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class MicrosoftPurviewProviderConfig : Humidifier.Base.BaseSubResource, IHaveListOfQuickSightDLPSettingTypesLabelActionMappingLabelActionMappings, IHaveUnmappedAction, IHaveQuickSightDLPSettingTypesMicrosoftPurviewCredentialsCredentials
        {
            /// <summary>
            /// LabelActionMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-labelactionmappings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LabelActionMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.QuickSight.DLPSettingTypes.LabelActionMapping>, IReadOnlyList<Union<Humidifier.QuickSight.DLPSettingTypes.LabelActionMapping, BaseFunction>>, BaseFunction>? LabelActionMappings { get; set; }
            /// <summary>
            /// UnmappedAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-unmappedaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnmappedAction { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-microsoftpurviewproviderconfig.html#cfn-quicksight-dlpsetting-microsoftpurviewproviderconfig-credentials
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MicrosoftPurviewCredentials
            /// </summary>
            public Union<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewCredentials, BaseFunction>? Credentials { get; set; }
        }

        public class ProviderConfig : Humidifier.Base.BaseSubResource, IHaveQuickSightDLPSettingTypesMicrosoftPurviewProviderConfigMicrosoftPurview
        {
            /// <summary>
            /// MicrosoftPurview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-dlpsetting-providerconfig.html#cfn-quicksight-dlpsetting-providerconfig-microsoftpurview
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MicrosoftPurviewProviderConfig
            /// </summary>
            public Union<Humidifier.QuickSight.DLPSettingTypes.MicrosoftPurviewProviderConfig, BaseFunction>? MicrosoftPurview { get; set; }
        }
    }
}