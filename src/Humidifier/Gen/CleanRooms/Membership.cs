namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using MembershipTypes;

    public class Membership : Humidifier.Base.BaseResource, IHaveTags, IHaveQueryLogStatus
    {
        public class Attributes
        {
            public static string MembershipIdentifier =  "MembershipIdentifier" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationCreatorAccountId =  "CollaborationCreatorAccountId" ;
            public static string CollaborationArn =  "CollaborationArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.Membership; }

        /// <summary>
        /// CollaborationIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-collaborationidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CollaborationIdentifier { get; set; }
        /// <summary>
        /// JobLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-joblogstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobLogStatus { get; set; }
        /// <summary>
        /// DefaultResultConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-defaultresultconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipProtectedQueryResultConfiguration
        /// </summary>
        public Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration DefaultResultConfiguration { get; set; }
        /// <summary>
        /// IsMetricsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-ismetricsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsMetricsEnabled { get; set; }

        /// <summary>
        /// QueryLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-querylogstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueryLogStatus { get; set; }
        /// <summary>
        /// DefaultJobResultConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-defaultjobresultconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipProtectedJobResultConfiguration
        /// </summary>
        public Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration DefaultJobResultConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// PaymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-paymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipPaymentConfiguration
        /// </summary>
        public Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration PaymentConfiguration { get; set; }
    }

    namespace MembershipTypes
    {
        public class MembershipJobComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipjobcomputepaymentconfig.html#cfn-cleanrooms-membership-membershipjobcomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }

        public class MembershipMLPaymentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelInference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-modelinference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipModelInferencePaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig ModelInference { get; set; }
            /// <summary>
            /// SyntheticDataGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-syntheticdatageneration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipSyntheticDataGenerationPaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig SyntheticDataGeneration { get; set; }
            /// <summary>
            /// ModelTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-modeltraining
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipModelTrainingPaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig ModelTraining { get; set; }
        }

        public class MembershipModelInferencePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmodelinferencepaymentconfig.html#cfn-cleanrooms-membership-membershipmodelinferencepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }

        public class MembershipModelTrainingPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmodeltrainingpaymentconfig.html#cfn-cleanrooms-membership-membershipmodeltrainingpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }

        public class MembershipPaymentConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// JobCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-jobcompute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipJobComputePaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig JobCompute { get; set; }
            /// <summary>
            /// QueryCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-querycompute
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipQueryComputePaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig QueryCompute { get; set; }
            /// <summary>
            /// MachineLearning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-machinelearning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipMLPaymentConfig
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipMLPaymentConfig MachineLearning { get; set; }
        }

        public class MembershipProtectedJobOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjoboutputconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjoboutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedJobS3OutputConfigurationInput
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput S3 { get; set; }
        }

        public class MembershipProtectedJobResultConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjobresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjobresultconfiguration-outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipProtectedJobOutputConfiguration
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration OutputConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjobresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjobresultconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class MembershipProtectedQueryOutputConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryoutputconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryoutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedQueryS3OutputConfiguration
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration S3 { get; set; }
        }

        public class MembershipProtectedQueryResultConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipProtectedQueryOutputConfiguration
            /// </summary>
            public Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration OutputConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class MembershipQueryComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
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

        public class MembershipSyntheticDataGenerationPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipsyntheticdatagenerationpaymentconfig.html#cfn-cleanrooms-membership-membershipsyntheticdatagenerationpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsResponsible { get; set; }
        }

        public class ProtectedJobS3OutputConfigurationInput : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKeyPrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedjobs3outputconfigurationinput.html#cfn-cleanrooms-membership-protectedjobs3outputconfigurationinput-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedjobs3outputconfigurationinput.html#cfn-cleanrooms-membership-protectedjobs3outputconfigurationinput-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }

        public class ProtectedQueryS3OutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKeyPrefix
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
            /// <summary>
            /// SingleFileOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-singlefileoutput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SingleFileOutput { get; set; }
        }
    }
}