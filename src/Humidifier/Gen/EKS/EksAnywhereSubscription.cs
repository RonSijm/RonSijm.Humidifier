namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using EksAnywhereSubscriptionTypes;

    public class EksAnywhereSubscription : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ExpirationDate =  "ExpirationDate" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Licenses =  "Licenses" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string LicenseArns =  "LicenseArns" ;
            public static string EffectiveDate =  "EffectiveDate" ;
        }

        public override string AWSTypeName { get => AWS.EKS.EksAnywhereSubscription; }
        /// <summary>
        /// AutoRenew
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-eksanywheresubscription.html#cfn-eks-eksanywheresubscription-autorenew
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoRenew { get; set; }
        /// <summary>
        /// Term
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-eksanywheresubscription.html#cfn-eks-eksanywheresubscription-term
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EksAnywhereSubscriptionTerm
        /// </summary>
        public Humidifier.EKS.EksAnywhereSubscriptionTypes.EksAnywhereSubscriptionTerm Term { get; set; }
        /// <summary>
        /// LicenseQuantity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-eksanywheresubscription.html#cfn-eks-eksanywheresubscription-licensequantity
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic LicenseQuantity { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-eksanywheresubscription.html#cfn-eks-eksanywheresubscription-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// LicenseType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-eksanywheresubscription.html#cfn-eks-eksanywheresubscription-licensetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LicenseType { get; set; }
    }

    namespace EksAnywhereSubscriptionTypes
    {
        public class EksAnywhereSubscriptionTerm : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveDuration
        {
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-eksanywheresubscription-eksanywheresubscriptionterm.html#cfn-eks-eksanywheresubscription-eksanywheresubscriptionterm-duration
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Duration { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-eksanywheresubscription-eksanywheresubscriptionterm.html#cfn-eks-eksanywheresubscription-eksanywheresubscriptionterm-unit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class License : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-eksanywheresubscription-license.html#cfn-eks-eksanywheresubscription-license-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}