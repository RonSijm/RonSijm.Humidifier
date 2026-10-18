namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using SubscriptionTargetTypes;

    public class SubscriptionTarget : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveEnvironmentIdentifier, IHaveManageAccessRole, IHaveListOfDataZoneSubscriptionTargetTypesSubscriptionTargetFormSubscriptionTargetConfig, IHaveStringListOfApplicableAssetTypes, IHaveStringListOfAuthorizedPrincipals, IHaveName, IHaveProvider, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string UpdatedBy =  "UpdatedBy" ;
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string DomainId =  "DomainId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ProjectId =  "ProjectId" ;
            public static string Id =  "Id" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.SubscriptionTarget; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-environmentidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// ManageAccessRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-manageaccessrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ManageAccessRole { get; set; }

        /// <summary>
        /// SubscriptionTargetConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-subscriptiontargetconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubscriptionTargetForm
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm>, IReadOnlyList<Union<Humidifier.DataZone.SubscriptionTargetTypes.SubscriptionTargetForm, BaseFunction>>, BaseFunction>? SubscriptionTargetConfig { get; set; }

        /// <summary>
        /// ApplicableAssetTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-applicableassettypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApplicableAssetTypes { get; set; }

        /// <summary>
        /// AuthorizedPrincipals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-authorizedprincipals
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthorizedPrincipals { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-provider
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Provider { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-subscriptiontarget.html#cfn-datazone-subscriptiontarget-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace SubscriptionTargetTypes
    {
        public class SubscriptionTargetForm : Humidifier.Base.BaseSubResource, IHaveContent, IHaveFormName
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-subscriptiontarget-subscriptiontargetform.html#cfn-datazone-subscriptiontarget-subscriptiontargetform-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
            /// <summary>
            /// FormName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-subscriptiontarget-subscriptiontargetform.html#cfn-datazone-subscriptiontarget-subscriptiontargetform-formname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FormName { get; set; }
        }
    }
}