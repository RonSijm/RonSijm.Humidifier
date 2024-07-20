namespace Humidifier.CleanRooms
{
    using System.Collections.Generic;
    using MembershipTypes;

    public class Membership : Humidifier.Resource
    {
        public class Attributes
        {
            public static string MembershipIdentifier =  "MembershipIdentifier" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationCreatorAccountId =  "CollaborationCreatorAccountId" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CleanRooms::Membership";
            }
        }

        /// <summary>
        /// CollaborationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-collaborationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CollaborationIdentifier { get; set; }
        /// <summary>
        /// DefaultResultConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-defaultresultconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipProtectedQueryResultConfiguration
        /// </summary>
        public MembershipProtectedQueryResultConfiguration DefaultResultConfiguration { get; set; }
        /// <summary>
        /// QueryLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-querylogstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic QueryLogStatus { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// PaymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-paymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipPaymentConfiguration
        /// </summary>
        public MembershipPaymentConfiguration PaymentConfiguration { get; set; }
    }

    namespace MembershipTypes
    {
        public class MembershipPaymentConfiguration
        {
            /// <summary>
            /// QueryCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-querycompute
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipQueryComputePaymentConfig
            /// </summary>
            public MembershipQueryComputePaymentConfig QueryCompute { get; set; }
        }

        public class MembershipProtectedQueryOutputConfiguration
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryoutputconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryoutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedQueryS3OutputConfiguration
            /// </summary>
            public ProtectedQueryS3OutputConfiguration S3 { get; set; }
        }

        public class MembershipProtectedQueryResultConfiguration
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipProtectedQueryOutputConfiguration
            /// </summary>
            public MembershipProtectedQueryOutputConfiguration OutputConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class MembershipQueryComputePaymentConfig
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipquerycomputepaymentconfig.html#cfn-cleanrooms-membership-membershipquerycomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }

        public class ProtectedQueryS3OutputConfiguration
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// ResultFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-resultformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultFormat { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }
    }
}