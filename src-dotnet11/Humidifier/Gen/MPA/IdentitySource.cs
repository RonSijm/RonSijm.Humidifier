namespace Humidifier.MPA
{
    using global::System.Collections.Generic;
    using IdentitySourceTypes;

    public class IdentitySource : Humidifier.Base.BaseResource, IHaveTags, IHaveMPAIdentitySourceTypesIdentitySourceParametersIdentitySourceParameters
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
        public Union<Humidifier.MPA.IdentitySourceTypes.IdentitySourceParameters, BaseFunction>? IdentitySourceParameters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mpa-identitysource.html#cfn-mpa-identitysource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IdentitySourceTypes
    {
        public class IamIdentityCenter : Humidifier.Base.BaseSubResource, IHaveApprovalPortalUrl, IHaveInstanceArn, IHaveRegion
        {
            /// <summary>
            /// ApprovalPortalUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-approvalportalurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApprovalPortalUrl { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-iamidentitycenter.html#cfn-mpa-identitysource-iamidentitycenter-region
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class IdentitySourceParameters : Humidifier.Base.BaseSubResource, IHaveMPAIdentitySourceTypesIamIdentityCenterIamIdentityCenter
        {
            /// <summary>
            /// IamIdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mpa-identitysource-identitysourceparameters.html#cfn-mpa-identitysource-identitysourceparameters-iamidentitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IamIdentityCenter
            /// </summary>
            public Union<Humidifier.MPA.IdentitySourceTypes.IamIdentityCenter, BaseFunction>? IamIdentityCenter { get; set; }
        }
    }
}