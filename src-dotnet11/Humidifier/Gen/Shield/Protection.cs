namespace Humidifier.Shield
{
    using global::System.Collections.Generic;
    using ProtectionTypes;

    public class Protection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceArn, IHaveStringListOfHealthCheckArns, IHaveShieldProtectionTypesApplicationLayerAutomaticResponseConfigurationApplicationLayerAutomaticResponseConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string ProtectionArn =  "ProtectionArn" ;
            public static string ProtectionId =  "ProtectionId" ;
        }

        public override string AWSTypeName { get => AWS.Shield.Protection; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }
        /// <summary>
        /// HealthCheckArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-healthcheckarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? HealthCheckArns { get; set; }
        /// <summary>
        /// ApplicationLayerAutomaticResponseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationLayerAutomaticResponseConfiguration
        /// </summary>
        public Union<Humidifier.Shield.ProtectionTypes.ApplicationLayerAutomaticResponseConfiguration, BaseFunction>? ApplicationLayerAutomaticResponseConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-shield-protection.html#cfn-shield-protection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ProtectionTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveBlock_Json, IHaveCount_Json
        {
            /// <summary>
            /// Block
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-action.html#cfn-shield-protection-action-block
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Block { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-action.html#cfn-shield-protection-action-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Count { get; set; }
        }

        public class ApplicationLayerAutomaticResponseConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveShieldProtectionTypesActionAction
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-applicationlayerautomaticresponseconfiguration.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-shield-protection-applicationlayerautomaticresponseconfiguration.html#cfn-shield-protection-applicationlayerautomaticresponseconfiguration-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Union<Humidifier.Shield.ProtectionTypes.Action, BaseFunction>? Action { get; set; }
        }
    }
}