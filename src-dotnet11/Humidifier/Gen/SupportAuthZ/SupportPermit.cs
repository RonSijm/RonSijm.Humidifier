namespace Humidifier.SupportAuthZ
{
    using global::System.Collections.Generic;
    using SupportPermitTypes;

    public class SupportPermit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveSupportAuthZSupportPermitTypesPermitPermit, IHaveSupportAuthZSupportPermitTypesSigningKeyInfoSigningKeyInfo, IHaveSupportCaseDisplayId, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PermitId =  "PermitId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SupportAuthZ.SupportPermit; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Permit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-permit
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Permit
        /// </summary>
        [Required]
        public Union<Humidifier.SupportAuthZ.SupportPermitTypes.Permit, BaseFunction>? Permit { get; set; }

        /// <summary>
        /// SigningKeyInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-signingkeyinfo
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SigningKeyInfo
        /// </summary>
        [Required]
        public Union<Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo, BaseFunction>? SigningKeyInfo { get; set; }
        /// <summary>
        /// SupportCaseDisplayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-supportcasedisplayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SupportCaseDisplayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SupportPermitTypes
    {
        public class ActionSet : Humidifier.Base.BaseSubResource, IHaveAllActions_Json, IHaveStringListOfActions
        {
            /// <summary>
            /// AllActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-actionset.html#cfn-supportauthz-supportpermit-actionset-allactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllActions { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-actionset.html#cfn-supportauthz-supportpermit-actionset-actions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveAllowAfter, IHaveAllowBefore
        {
            /// <summary>
            /// AllowAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-condition.html#cfn-supportauthz-supportpermit-condition-allowafter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowAfter { get; set; }
            /// <summary>
            /// AllowBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-condition.html#cfn-supportauthz-supportpermit-condition-allowbefore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllowBefore { get; set; }
        }

        public class Permit : Humidifier.Base.BaseSubResource, IHaveSupportAuthZSupportPermitTypesActionSetActions, IHaveSupportAuthZSupportPermitTypesResourceSetResources, IHaveListOfSupportAuthZSupportPermitTypesConditionConditions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-actions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ActionSet
            /// </summary>
            public Union<Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-resources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceSet
            /// </summary>
            public Union<Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-conditions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SupportAuthZ.SupportPermitTypes.Condition>, IReadOnlyList<Union<Humidifier.SupportAuthZ.SupportPermitTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }

        public class ResourceSet : Humidifier.Base.BaseSubResource, IHaveAllResourcesInRegion_Json, IHaveStringListOfResources
        {
            /// <summary>
            /// AllResourcesInRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-resourceset.html#cfn-supportauthz-supportpermit-resourceset-allresourcesinregion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AllResourcesInRegion { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-resourceset.html#cfn-supportauthz-supportpermit-resourceset-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
        }

        public class SigningKeyInfo : Humidifier.Base.BaseSubResource, IHaveKmsKey
        {
            /// <summary>
            /// KmsKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-signingkeyinfo.html#cfn-supportauthz-supportpermit-signingkeyinfo-kmskey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKey { get; set; }
        }
    }
}