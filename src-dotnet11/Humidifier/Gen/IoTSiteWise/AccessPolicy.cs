namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using AccessPolicyTypes;

    public class AccessPolicy : Humidifier.Base.BaseResource, IHaveIoTSiteWiseAccessPolicyTypesAccessPolicyResourceAccessPolicyResource, IHaveIoTSiteWiseAccessPolicyTypesAccessPolicyIdentityAccessPolicyIdentity, IHaveAccessPolicyPermission
    {
        public class Attributes
        {
            public static string AccessPolicyArn =  "AccessPolicyArn" ;
            public static string AccessPolicyId =  "AccessPolicyId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.AccessPolicy; }

        /// <summary>
        /// AccessPolicyResource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyresource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccessPolicyResource
        /// </summary>
        [Required]
        public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource, BaseFunction>? AccessPolicyResource { get; set; }

        /// <summary>
        /// AccessPolicyIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccessPolicyIdentity
        /// </summary>
        [Required]
        public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyIdentity, BaseFunction>? AccessPolicyIdentity { get; set; }

        /// <summary>
        /// AccessPolicyPermission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicypermission
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccessPolicyPermission { get; set; }
    }

    namespace AccessPolicyTypes
    {
        public class AccessPolicyIdentity : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseAccessPolicyTypesUserUser, IHaveIoTSiteWiseAccessPolicyTypesIamUserIamUser, IHaveIoTSiteWiseAccessPolicyTypesIamRoleIamRole
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-user
            /// Required: False
            /// UpdateType: Mutable
            /// Type: User
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.User, BaseFunction>? User { get; set; }
            /// <summary>
            /// IamUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-iamuser
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamUser
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.IamUser, BaseFunction>? IamUser { get; set; }
            /// <summary>
            /// IamRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-iamrole
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamRole
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.IamRole, BaseFunction>? IamRole { get; set; }
        }

        public class AccessPolicyResource : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseAccessPolicyTypesProjectProject, IHaveIoTSiteWiseAccessPolicyTypesPortalPortal
        {
            /// <summary>
            /// Project
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyresource.html#cfn-iotsitewise-accesspolicy-accesspolicyresource-project
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Project
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.Project, BaseFunction>? Project { get; set; }
            /// <summary>
            /// Portal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyresource.html#cfn-iotsitewise-accesspolicy-accesspolicyresource-portal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Portal
            /// </summary>
            public Union<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal, BaseFunction>? Portal { get; set; }
        }

        public class IamRole : Humidifier.Base.BaseSubResource, IHavearn
        {
            /// <summary>
            /// arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamrole.html#cfn-iotsitewise-accesspolicy-iamrole-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? arn { get; set; }
        }

        public class IamUser : Humidifier.Base.BaseSubResource, IHavearn
        {
            /// <summary>
            /// arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamuser.html#cfn-iotsitewise-accesspolicy-iamuser-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? arn { get; set; }
        }

        public class Portal : Humidifier.Base.BaseSubResource, IHaveid
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-portal.html#cfn-iotsitewise-accesspolicy-portal-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? id { get; set; }
        }

        public class Project : Humidifier.Base.BaseSubResource, IHaveid
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-project.html#cfn-iotsitewise-accesspolicy-project-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? id { get; set; }
        }

        public class User : Humidifier.Base.BaseSubResource, IHaveid
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-user.html#cfn-iotsitewise-accesspolicy-user-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? id { get; set; }
        }
    }
}