namespace Humidifier.DataZone
{
    using System.Collections.Generic;
    using UserProfileTypes;

    public class UserProfile : Humidifier.Base.BaseResource, IHaveStatus, IHaveDomainIdentifier, IHaveUserIdentifier
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string Details =  "Details" ;
            public static string DomainId =  "DomainId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.UserProfile; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status { get; set; }

        /// <summary>
        /// UserIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-useridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UserIdentifier { get; set; }
        /// <summary>
        /// UserType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-usertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserType { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainIdentifier { get; set; }
    }

    namespace UserProfileTypes
    {
        public class IamUserProfileDetails : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-iamuserprofiledetails.html#cfn-datazone-userprofile-iamuserprofiledetails-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class SsoUserProfileDetails : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveFirstName, IHaveLastName
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-ssouserprofiledetails.html#cfn-datazone-userprofile-ssouserprofiledetails-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-ssouserprofiledetails.html#cfn-datazone-userprofile-ssouserprofiledetails-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirstName { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-ssouserprofiledetails.html#cfn-datazone-userprofile-ssouserprofiledetails-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastName { get; set; }
        }

        public class UserProfileDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-userprofiledetails.html#cfn-datazone-userprofile-userprofiledetails-iam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamUserProfileDetails
            /// </summary>
            public Humidifier.DataZone.UserProfileTypes.IamUserProfileDetails Iam { get; set; }
            /// <summary>
            /// Sso
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-userprofiledetails.html#cfn-datazone-userprofile-userprofiledetails-sso
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsoUserProfileDetails
            /// </summary>
            public Humidifier.DataZone.UserProfileTypes.SsoUserProfileDetails Sso { get; set; }
        }
    }
}