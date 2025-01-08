namespace Humidifier.CodePipeline
{
    using System.Collections.Generic;
    using WebhookTypes;

    public class Webhook : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveAuthentication
    {
        public class Attributes
        {
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
        public Humidifier.CodePipeline.WebhookTypes.WebhookAuthConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Filters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-filters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WebhookFilterRule
        /// </summary>
        [Required]
        public List<Humidifier.CodePipeline.WebhookTypes.WebhookFilterRule> Filters { get; set; }

        /// <summary>
        /// Authentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-authentication
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Authentication { get; set; }

        /// <summary>
        /// TargetPipeline
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetpipeline
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetPipeline { get; set; }

        /// <summary>
        /// TargetAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetAction { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// TargetPipelineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-targetpipelineversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic TargetPipelineVersion { get; set; }
        /// <summary>
        /// RegisterWithThirdParty
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-webhook.html#cfn-codepipeline-webhook-registerwiththirdparty
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RegisterWithThirdParty { get; set; }
    }

    namespace WebhookTypes
    {
        public class WebhookAuthConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowedIPRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html#cfn-codepipeline-webhook-webhookauthconfiguration-allowediprange
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowedIPRange { get; set; }
            /// <summary>
            /// SecretToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookauthconfiguration.html#cfn-codepipeline-webhook-webhookauthconfiguration-secrettoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretToken { get; set; }
        }

        public class WebhookFilterRule : Humidifier.Base.BaseSubResource, IHaveJsonPath
        {
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html#cfn-codepipeline-webhook-webhookfilterrule-jsonpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonPath { get; set; }
            /// <summary>
            /// MatchEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-webhook-webhookfilterrule.html#cfn-codepipeline-webhook-webhookfilterrule-matchequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchEquals { get; set; }
        }
    }
}