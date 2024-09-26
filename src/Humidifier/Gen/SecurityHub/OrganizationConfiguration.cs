namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class OrganizationConfiguration : Humidifier.Base.BaseResource, IHaveConfigurationType
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
        public dynamic AutoEnable { get; set; }
        /// <summary>
        /// ConfigurationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-organizationconfiguration.html#cfn-securityhub-organizationconfiguration-configurationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConfigurationType { get; set; }
        /// <summary>
        /// AutoEnableStandards
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-organizationconfiguration.html#cfn-securityhub-organizationconfiguration-autoenablestandards
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoEnableStandards { get; set; }
    }
}