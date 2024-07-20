namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;
    using AccessPolicyTypes;

    public class AccessPolicy : Humidifier.Resource
    {
        public class Attributes
        {
            public static string AccessPolicyArn =  "AccessPolicyArn" ;
            public static string AccessPolicyId =  "AccessPolicyId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTSiteWise::AccessPolicy";
            }
        }

        /// <summary>
        /// AccessPolicyResource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyresource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccessPolicyResource
        /// </summary>
        public AccessPolicyResource AccessPolicyResource { get; set; }
        /// <summary>
        /// AccessPolicyIdentity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccessPolicyIdentity
        /// </summary>
        public AccessPolicyIdentity AccessPolicyIdentity { get; set; }
        /// <summary>
        /// AccessPolicyPermission
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicypermission
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessPolicyPermission { get; set; }
    }

    namespace AccessPolicyTypes
    {
        public class AccessPolicyIdentity
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-user
            /// Required: False
            /// UpdateType: Mutable
            /// Type: User
            /// </summary>
            public User User { get; set; }
            /// <summary>
            /// IamUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-iamuser
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamUser
            /// </summary>
            public IamUser IamUser { get; set; }
            /// <summary>
            /// IamRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity-iamrole
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamRole
            /// </summary>
            public IamRole IamRole { get; set; }
        }

        public class AccessPolicyResource
        {
            /// <summary>
            /// Project
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyresource.html#cfn-iotsitewise-accesspolicy-accesspolicyresource-project
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Project
            /// </summary>
            public Project Project { get; set; }
            /// <summary>
            /// Portal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyresource.html#cfn-iotsitewise-accesspolicy-accesspolicyresource-portal
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Portal
            /// </summary>
            public Portal Portal { get; set; }
        }

        public class IamRole
        {
            /// <summary>
            /// arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamrole.html#cfn-iotsitewise-accesspolicy-iamrole-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic arn { get; set; }
        }

        public class IamUser
        {
            /// <summary>
            /// arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamuser.html#cfn-iotsitewise-accesspolicy-iamuser-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic arn { get; set; }
        }

        public class Portal
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-portal.html#cfn-iotsitewise-accesspolicy-portal-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic id { get; set; }
        }

        public class Project
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-project.html#cfn-iotsitewise-accesspolicy-project-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic id { get; set; }
        }

        public class User
        {
            /// <summary>
            /// id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-user.html#cfn-iotsitewise-accesspolicy-user-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic id { get; set; }
        }
    }
}