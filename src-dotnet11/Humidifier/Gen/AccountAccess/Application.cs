namespace Humidifier.AccountAccess
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags, IHaveAccountAccessApplicationTypesIdentitySourceIdentitySource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TenantId =  "TenantId" ;
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AccountAccess.Application; }

        /// <summary>
        /// IdentitySource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-application.html#cfn-accountaccess-application-identitysource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: IdentitySource
        /// </summary>
        [Required]
        public Union<Humidifier.AccountAccess.ApplicationTypes.IdentitySource, BaseFunction>? IdentitySource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-application.html#cfn-accountaccess-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class IdentityCenter : Humidifier.Base.BaseSubResource, IHaveApplicationArn, IHaveInstanceArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitycenter.html#cfn-accountaccess-application-identitycenter-applicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitycenter.html#cfn-accountaccess-application-identitycenter-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceArn { get; set; }
        }

        public class IdentitySource : Humidifier.Base.BaseSubResource, IHaveAccountAccessApplicationTypesIdentityCenterIdentityCenter
        {
            /// <summary>
            /// IdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitysource.html#cfn-accountaccess-application-identitysource-identitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IdentityCenter
            /// </summary>
            public Union<Humidifier.AccountAccess.ApplicationTypes.IdentityCenter, BaseFunction>? IdentityCenter { get; set; }
        }
    }
}