namespace Humidifier.Shield
{
    using System.Collections.Generic;
    using ProtectionTypes;

    public class Protection : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string ProtectionArn =  "ProtectionArn" ;
            public static string ProtectionId =  "ProtectionId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Shield::Protection";
            }
        }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceArn { get; set; }
        /// <summary>
        /// HealthCheckArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-healthcheckarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic HealthCheckArns { get; set; }
        /// <summary>
        /// ApplicationLayerAutomaticResponseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationLayerAutomaticResponseConfiguration
        /// </summary>
        public ApplicationLayerAutomaticResponseConfiguration ApplicationLayerAutomaticResponseConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace ProtectionTypes
    {
        public class Action
        {
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-action.html#cfn-shield-protection-action-block
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Block { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-action.html#cfn-shield-protection-action-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Count { get; set; }
        }

        public class ApplicationLayerAutomaticResponseConfiguration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-applicationlayerautomaticresponseconfiguration.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-applicationlayerautomaticresponseconfiguration.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Action Action { get; set; }
        }
    }
}