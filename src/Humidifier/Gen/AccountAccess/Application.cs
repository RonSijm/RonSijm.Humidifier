namespace Humidifier.AccountAccess
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.AccountAccess.ApplicationTypes.IdentitySource IdentitySource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accountaccess-application.html#cfn-accountaccess-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ApplicationTypes
    {
        public class IdentityCenter : Humidifier.Base.BaseSubResource, IHaveInstanceArn, IHaveApplicationArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitycenter.html#cfn-accountaccess-application-identitycenter-applicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationArn { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitycenter.html#cfn-accountaccess-application-identitycenter-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceArn { get; set; }
        }

        public class IdentitySource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdentityCenter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accountaccess-application-identitysource.html#cfn-accountaccess-application-identitysource-identitycenter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IdentityCenter
            /// </summary>
            public Humidifier.AccountAccess.ApplicationTypes.IdentityCenter IdentityCenter { get; set; }
        }
    }
}