namespace Humidifier.CodePipeline
{
    using global::System.Collections.Generic;
    using WebhookTypes;

    public class Webhook : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCodePipelineWebhookTypesWebhookAuthConfigurationAuthenticationConfiguration, IHaveListOfCodePipelineWebhookTypesWebhookFilterRuleFilters, IHaveAuthentication, IHaveTargetPipeline, IHaveTargetAction, IHaveName, IHaveTargetPipelineVersion_Integer, IHaveRegisterWithThirdParty_Boolean
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.CodePipeline.Webhook; }

        /// <summary>
        /// AuthenticationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-authenticationconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: WebhookAuthConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Filters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-filters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WebhookFilterRule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule>, IReadOnlyList<Union<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule, BaseFunction>>, BaseFunction>? Filters { get; set; }

        /// <summary>
        /// Authentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-authentication
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Authentication { get; set; }

        /// <summary>
        /// TargetPipeline
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetpipeline
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetPipeline { get; set; }

        /// <summary>
        /// TargetAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetAction { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TargetPipelineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetpipelineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TargetPipelineVersion { get; set; }
        /// <summary>
        /// RegisterWithThirdParty
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-registerwiththirdparty
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RegisterWithThirdParty { get; set; }
    }

    namespace WebhookTypes
    {
        public class WebhookAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveAllowedIPRange, IHaveSecretToken
        {
            /// <summary>
            /// AllowedIPRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html#cfn-codepipeline-webhook-webhookauthconfiguration-allowediprange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowedIPRange { get; set; }
            /// <summary>
            /// SecretToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html#cfn-codepipeline-webhook-webhookauthconfiguration-secrettoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretToken { get; set; }
        }

        public class WebhookFilterRule : Humidifier.Base.BaseSubResource, IHaveJsonPath, IHaveMatchEquals
        {
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html#cfn-codepipeline-webhook-webhookfilterrule-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonPath { get; set; }
            /// <summary>
            /// MatchEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html#cfn-codepipeline-webhook-webhookfilterrule-matchequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchEquals { get; set; }
        }
    }
}