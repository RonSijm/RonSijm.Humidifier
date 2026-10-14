namespace Humidifier.MPA
{
    using global::System.Collections.Generic;
    using IdentitySourceTypes;

    public class IdentitySource : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IdentitySourceArn =  "IdentitySourceArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string IdentitySourceType =  "IdentitySourceType" ;
            public static string StatusCode =  "StatusCode" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.MPA.IdentitySource; }

        /// <summary>
        /// IdentitySourceParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-identitysource.html#cfn-mpa-identitysource-identitysourceparameters
        /// Required: True
        /// UpdateType: Immutable
        /// Type: IdentitySourceParameters
        /// </summary>
        [Required]
        public Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters IdentitySourceParameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-identitysource.html#cfn-mpa-identitysource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace IdentitySourceTypes
    {
        public class IamIdentityCenter : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveInstanceArn
        {
            /// <summary>
            /// ApprovalPortalUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-approvalportalurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApprovalPortalUrl { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-region
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }

        public class IdentitySourceParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IamIdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-identitysourceparameters.html#cfn-mpa-identitysource-identitysourceparameters-iamidentitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IamIdentityCenter
            /// </summary>
            public Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter IamIdentityCenter { get; set; }
        }
    }
}