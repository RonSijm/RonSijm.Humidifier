namespace Humidifier.SSMQuickSetup
{
    using global::System.Collections.Generic;

    public class LifecycleAutomation : Humidifier.Base.BaseResource, IHaveAutomationParameters_Json, IHaveAutomationDocument, IHaveStringDictionaryOfTags, IHaveResourceKey
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.SSMQuickSetup.LifecycleAutomation; }

        /// <summary>
        /// AutomationParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-lifecycleautomation.html#cfn-ssmquicksetup-lifecycleautomation-automationparameters
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? AutomationParameters { get; set; }

        /// <summary>
        /// AutomationDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-lifecycleautomation.html#cfn-ssmquicksetup-lifecycleautomation-automationdocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AutomationDocument { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-lifecycleautomation.html#cfn-ssmquicksetup-lifecycleautomation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// ResourceKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmquicksetup-lifecycleautomation.html#cfn-ssmquicksetup-lifecycleautomation-resourcekey
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceKey { get; set; }
    }
}