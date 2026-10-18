namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;

    public class OrganizationConfiguration : Humidifier.Base.BaseResource, IHaveAutoEnable_Boolean, IHaveConfigurationType, IHaveAutoEnableStandards
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OrganizationConfigurationIdentifier =  "OrganizationConfigurationIdentifier" ;
            public static string MemberAccountLimitReached =  "MemberAccountLimitReached" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.OrganizationConfiguration; }

        /// <summary>
        /// AutoEnable
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-organizationconfiguration.html#cfn-securityhub-organizationconfiguration-autoenable
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? AutoEnable { get; set; }
        /// <summary>
        /// ConfigurationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-organizationconfiguration.html#cfn-securityhub-organizationconfiguration-configurationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfigurationType { get; set; }
        /// <summary>
        /// AutoEnableStandards
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-organizationconfiguration.html#cfn-securityhub-organizationconfiguration-autoenablestandards
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AutoEnableStandards { get; set; }
    }
}