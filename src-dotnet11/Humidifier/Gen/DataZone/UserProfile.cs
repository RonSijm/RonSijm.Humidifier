namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using UserProfileTypes;

    public class UserProfile : Humidifier.Base.BaseResource, IHaveStatus, IHaveUserIdentifier, IHaveUserType, IHaveSessionName, IHaveDomainIdentifier
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
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// UserIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-useridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserIdentifier { get; set; }
        /// <summary>
        /// UserType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-usertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserType { get; set; }
        /// <summary>
        /// SessionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-sessionname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SessionName { get; set; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-userprofile.html#cfn-datazone-userprofile-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace UserProfileTypes
    {
        public class IamUserProfileDetails : Humidifier.Base.BaseSubResource, IHaveGroupProfileId, IHaveArn, IHaveSessionName
        {
            /// <summary>
            /// GroupProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-iamuserprofiledetails.html#cfn-datazone-userprofile-iamuserprofiledetails-groupprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupProfileId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-iamuserprofiledetails.html#cfn-datazone-userprofile-iamuserprofiledetails-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// SessionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-iamuserprofiledetails.html#cfn-datazone-userprofile-iamuserprofiledetails-sessionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SessionName { get; set; }
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
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// FirstName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-ssouserprofiledetails.html#cfn-datazone-userprofile-ssouserprofiledetails-firstname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FirstName { get; set; }
            /// <summary>
            /// LastName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-ssouserprofiledetails.html#cfn-datazone-userprofile-ssouserprofiledetails-lastname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastName { get; set; }
        }

        public class UserProfileDetails : Humidifier.Base.BaseSubResource, IHaveDataZoneUserProfileTypesIamUserProfileDetailsIam, IHaveDataZoneUserProfileTypesSsoUserProfileDetailsSso
        {
            /// <summary>
            /// Iam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-userprofiledetails.html#cfn-datazone-userprofile-userprofiledetails-iam
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamUserProfileDetails
            /// </summary>
            public Union<Humidifier.DataZone.UserProfileTypes.IamUserProfileDetails, BaseFunction>? Iam { get; set; }
            /// <summary>
            /// Sso
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-userprofile-userprofiledetails.html#cfn-datazone-userprofile-userprofiledetails-sso
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SsoUserProfileDetails
            /// </summary>
            public Union<Humidifier.DataZone.UserProfileTypes.SsoUserProfileDetails, BaseFunction>? Sso { get; set; }
        }
    }
}