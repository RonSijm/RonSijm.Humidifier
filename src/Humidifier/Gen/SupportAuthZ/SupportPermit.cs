namespace Humidifier.SupportAuthZ
{
    using global::System.Collections.Generic;
    using SupportPermitTypes;

    public class SupportPermit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// Permit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-permit
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Permit
        /// </summary>
        [Required]
        public Humidifier.SupportAuthZ.SupportPermitTypes.Permit Permit { get; set; }

        /// <summary>
        /// SigningKeyInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-signingkeyinfo
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SigningKeyInfo
        /// </summary>
        [Required]
        public Humidifier.SupportAuthZ.SupportPermitTypes.SigningKeyInfo SigningKeyInfo { get; set; }
        /// <summary>
        /// SupportCaseDisplayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-supportcasedisplayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SupportCaseDisplayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportauthz-supportpermit.html#cfn-supportauthz-supportpermit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SupportPermitTypes
    {
        public class ActionSet : Humidifier.Base.BaseSubResource, IHaveActions
        {
            /// <summary>
            /// AllActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-actionset.html#cfn-supportauthz-supportpermit-actionset-allactions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllActions { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-actionset.html#cfn-supportauthz-supportpermit-actionset-actions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-condition.html#cfn-supportauthz-supportpermit-condition-allowafter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowAfter { get; set; }
            /// <summary>
            /// AllowBefore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-condition.html#cfn-supportauthz-supportpermit-condition-allowbefore
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllowBefore { get; set; }
        }

        public class Permit : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-actions
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ActionSet
            /// </summary>
            public Humidifier.SupportAuthZ.SupportPermitTypes.ActionSet Actions { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-resources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceSet
            /// </summary>
            public Humidifier.SupportAuthZ.SupportPermitTypes.ResourceSet Resources { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-permit.html#cfn-supportauthz-supportpermit-permit-conditions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public List<Humidifier.SupportAuthZ.SupportPermitTypes.Condition> Conditions { get; set; }
        }

        public class ResourceSet : Humidifier.Base.BaseSubResource, IHaveResources
        {
            /// <summary>
            /// AllResourcesInRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-resourceset.html#cfn-supportauthz-supportpermit-resourceset-allresourcesinregion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic AllResourcesInRegion { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-supportauthz-supportpermit-resourceset.html#cfn-supportauthz-supportpermit-resourceset-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources { get; set; }
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
            public dynamic KmsKey { get; set; }
        }
    }
}