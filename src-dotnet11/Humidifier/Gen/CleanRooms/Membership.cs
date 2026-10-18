namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using MembershipTypes;

    public class Membership : Humidifier.Base.BaseResource, IHaveTags, IHaveCollaborationIdentifier, IHaveJobLogStatus, IHaveCleanRoomsMembershipTypesMembershipProtectedQueryResultConfigurationDefaultResultConfiguration, IHaveIsMetricsEnabled_Boolean, IHaveQueryLogStatus, IHaveCleanRoomsMembershipTypesMembershipProtectedJobResultConfigurationDefaultJobResultConfiguration, IHaveCleanRoomsMembershipTypesMembershipPaymentConfigurationPaymentConfiguration
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
        public Union<string, BaseFunction>? CollaborationIdentifier { get; set; }
        /// <summary>
        /// JobLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-joblogstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobLogStatus { get; set; }
        /// <summary>
        /// DefaultResultConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-defaultresultconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipProtectedQueryResultConfiguration
        /// </summary>
        public Union<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration, BaseFunction>? DefaultResultConfiguration { get; set; }
        /// <summary>
        /// IsMetricsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-ismetricsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsMetricsEnabled { get; set; }

        /// <summary>
        /// QueryLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-querylogstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueryLogStatus { get; set; }
        /// <summary>
        /// DefaultJobResultConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-defaultjobresultconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipProtectedJobResultConfiguration
        /// </summary>
        public Union<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration, BaseFunction>? DefaultJobResultConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PaymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-membership.html#cfn-cleanrooms-membership-paymentconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MembershipPaymentConfiguration
        /// </summary>
        public Union<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration, BaseFunction>? PaymentConfiguration { get; set; }
    }

    namespace MembershipTypes
    {
        public class MembershipJobComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipjobcomputepaymentconfig.html#cfn-cleanrooms-membership-membershipjobcomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class MembershipMLPaymentConfig : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesMembershipModelInferencePaymentConfigModelInference, IHaveCleanRoomsMembershipTypesMembershipSyntheticDataGenerationPaymentConfigSyntheticDataGeneration, IHaveCleanRoomsMembershipTypesMembershipModelTrainingPaymentConfigModelTraining
        {
            /// <summary>
            /// ModelInference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-modelinference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipModelInferencePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipModelInferencePaymentConfig, BaseFunction>? ModelInference { get; set; }
            /// <summary>
            /// SyntheticDataGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-syntheticdatageneration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipSyntheticDataGenerationPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipSyntheticDataGenerationPaymentConfig, BaseFunction>? SyntheticDataGeneration { get; set; }
            /// <summary>
            /// ModelTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmlpaymentconfig.html#cfn-cleanrooms-membership-membershipmlpaymentconfig-modeltraining
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipModelTrainingPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipModelTrainingPaymentConfig, BaseFunction>? ModelTraining { get; set; }
        }

        public class MembershipModelInferencePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmodelinferencepaymentconfig.html#cfn-cleanrooms-membership-membershipmodelinferencepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class MembershipModelTrainingPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipmodeltrainingpaymentconfig.html#cfn-cleanrooms-membership-membershipmodeltrainingpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class MembershipPaymentConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesMembershipJobComputePaymentConfigJobCompute, IHaveCleanRoomsMembershipTypesMembershipQueryComputePaymentConfigQueryCompute, IHaveCleanRoomsMembershipTypesMembershipMLPaymentConfigMachineLearning
        {
            /// <summary>
            /// JobCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-jobcompute
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipJobComputePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipJobComputePaymentConfig, BaseFunction>? JobCompute { get; set; }
            /// <summary>
            /// QueryCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-querycompute
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipQueryComputePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipQueryComputePaymentConfig, BaseFunction>? QueryCompute { get; set; }
            /// <summary>
            /// MachineLearning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershippaymentconfiguration.html#cfn-cleanrooms-membership-membershippaymentconfiguration-machinelearning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MembershipMLPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipMLPaymentConfig, BaseFunction>? MachineLearning { get; set; }
        }

        public class MembershipProtectedJobOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesProtectedJobS3OutputConfigurationInputS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjoboutputconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjoboutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedJobS3OutputConfigurationInput
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.ProtectedJobS3OutputConfigurationInput, BaseFunction>? S3 { get; set; }
        }

        public class MembershipProtectedJobResultConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesMembershipProtectedJobOutputConfigurationOutputConfiguration, IHaveRoleArn
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjobresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjobresultconfiguration-outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipProtectedJobOutputConfiguration
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration, BaseFunction>? OutputConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedjobresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedjobresultconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class MembershipProtectedQueryOutputConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesProtectedQueryS3OutputConfigurationS3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryoutputconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryoutputconfiguration-s3
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedQueryS3OutputConfiguration
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.ProtectedQueryS3OutputConfiguration, BaseFunction>? S3 { get; set; }
        }

        public class MembershipProtectedQueryResultConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMembershipTypesMembershipProtectedQueryOutputConfigurationOutputConfiguration, IHaveRoleArn
        {
            /// <summary>
            /// OutputConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-outputconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MembershipProtectedQueryOutputConfiguration
            /// </summary>
            public Union<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration, BaseFunction>? OutputConfiguration { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipprotectedqueryresultconfiguration.html#cfn-cleanrooms-membership-membershipprotectedqueryresultconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class MembershipQueryComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipquerycomputepaymentconfig.html#cfn-cleanrooms-membership-membershipquerycomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class MembershipSyntheticDataGenerationPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-membershipsyntheticdatagenerationpaymentconfig.html#cfn-cleanrooms-membership-membershipsyntheticdatagenerationpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
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
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedjobs3outputconfigurationinput.html#cfn-cleanrooms-membership-protectedjobs3outputconfigurationinput-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
        }

        public class ProtectedQueryS3OutputConfiguration : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveResultFormat, IHaveKeyPrefix, IHaveSingleFileOutput_Boolean
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// ResultFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-resultformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultFormat { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
            /// <summary>
            /// SingleFileOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-membership-protectedquerys3outputconfiguration.html#cfn-cleanrooms-membership-protectedquerys3outputconfiguration-singlefileoutput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SingleFileOutput { get; set; }
        }
    }
}