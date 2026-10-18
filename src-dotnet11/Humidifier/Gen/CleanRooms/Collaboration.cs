namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using CollaborationTypes;

    public class Collaboration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAnalyticsEngine, IHaveCreatorDisplayName, IHaveStringListOfCreatorMemberAbilities, IHaveDescription, IHaveIsMetricsEnabled_Boolean, IHaveCleanRoomsCollaborationTypesMLMemberAbilitiesCreatorMLMemberAbilities, IHaveName, IHaveJobLogStatus, IHaveQueryLogStatus, IHaveStringListOfAutoApprovedChangeTypes, IHaveCleanRoomsCollaborationTypesPaymentConfigurationCreatorPaymentConfiguration, IHaveCleanRoomsCollaborationTypesDataEncryptionMetadataDataEncryptionMetadata, IHaveListOfCleanRoomsCollaborationTypesMemberSpecificationMembers, IHaveStringListOfAllowedResultRegions
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.Collaboration; }
        /// <summary>
        /// AnalyticsEngine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-analyticsengine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AnalyticsEngine { get; set; }

        /// <summary>
        /// CreatorDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatordisplayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CreatorDisplayName { get; set; }
        /// <summary>
        /// CreatorMemberAbilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatormemberabilities
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CreatorMemberAbilities { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IsMetricsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-ismetricsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsMetricsEnabled { get; set; }
        /// <summary>
        /// CreatorMLMemberAbilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatormlmemberabilities
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MLMemberAbilities
        /// </summary>
        public Union<Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities, BaseFunction>? CreatorMLMemberAbilities { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// JobLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-joblogstatus
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobLogStatus { get; set; }

        /// <summary>
        /// QueryLogStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-querylogstatus
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueryLogStatus { get; set; }
        /// <summary>
        /// AutoApprovedChangeTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-autoapprovedchangetypes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoApprovedChangeTypes { get; set; }
        /// <summary>
        /// CreatorPaymentConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-creatorpaymentconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PaymentConfiguration
        /// </summary>
        public Union<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration, BaseFunction>? CreatorPaymentConfiguration { get; set; }
        /// <summary>
        /// DataEncryptionMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-dataencryptionmetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataEncryptionMetadata
        /// </summary>
        public Union<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata, BaseFunction>? DataEncryptionMetadata { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Members
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-members
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MemberSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification>, IReadOnlyList<Union<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification, BaseFunction>>, BaseFunction>? Members { get; set; }
        /// <summary>
        /// AllowedResultRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-collaboration.html#cfn-cleanrooms-collaboration-allowedresultregions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedResultRegions { get; set; }
    }

    namespace CollaborationTypes
    {
        public class DataEncryptionMetadata : Humidifier.Base.BaseSubResource, IHaveAllowCleartext_Boolean, IHavePreserveNulls_Boolean, IHaveAllowJoinsOnColumnsWithDifferentNames_Boolean, IHaveAllowDuplicates_Boolean
        {
            /// <summary>
            /// AllowCleartext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowcleartext
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowCleartext { get; set; }
            /// <summary>
            /// PreserveNulls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-preservenulls
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PreserveNulls { get; set; }
            /// <summary>
            /// AllowJoinsOnColumnsWithDifferentNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowjoinsoncolumnswithdifferentnames
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowJoinsOnColumnsWithDifferentNames { get; set; }
            /// <summary>
            /// AllowDuplicates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-dataencryptionmetadata.html#cfn-cleanrooms-collaboration-dataencryptionmetadata-allowduplicates
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowDuplicates { get; set; }
        }

        public class JobComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-jobcomputepaymentconfig.html#cfn-cleanrooms-collaboration-jobcomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class MLMemberAbilities : Humidifier.Base.BaseSubResource, IHaveStringListOfCustomMLMemberAbilities
        {
            /// <summary>
            /// CustomMLMemberAbilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-mlmemberabilities.html#cfn-cleanrooms-collaboration-mlmemberabilities-custommlmemberabilities
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CustomMLMemberAbilities { get; set; }
        }

        public class MLPaymentConfig : Humidifier.Base.BaseSubResource, IHaveCleanRoomsCollaborationTypesModelInferencePaymentConfigModelInference, IHaveCleanRoomsCollaborationTypesSyntheticDataGenerationPaymentConfigSyntheticDataGeneration, IHaveCleanRoomsCollaborationTypesModelTrainingPaymentConfigModelTraining
        {
            /// <summary>
            /// ModelInference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-mlpaymentconfig.html#cfn-cleanrooms-collaboration-mlpaymentconfig-modelinference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelInferencePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.ModelInferencePaymentConfig, BaseFunction>? ModelInference { get; set; }
            /// <summary>
            /// SyntheticDataGeneration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-mlpaymentconfig.html#cfn-cleanrooms-collaboration-mlpaymentconfig-syntheticdatageneration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SyntheticDataGenerationPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.SyntheticDataGenerationPaymentConfig, BaseFunction>? SyntheticDataGeneration { get; set; }
            /// <summary>
            /// ModelTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-mlpaymentconfig.html#cfn-cleanrooms-collaboration-mlpaymentconfig-modeltraining
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelTrainingPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.ModelTrainingPaymentConfig, BaseFunction>? ModelTraining { get; set; }
        }

        public class MemberSpecification : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveCleanRoomsCollaborationTypesMLMemberAbilitiesMLMemberAbilities, IHaveDisplayName, IHaveStringListOfMemberAbilities, IHaveCleanRoomsCollaborationTypesPaymentConfigurationPaymentConfiguration
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-accountid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// MLMemberAbilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-mlmemberabilities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MLMemberAbilities
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.MLMemberAbilities, BaseFunction>? MLMemberAbilities { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-displayname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
            /// <summary>
            /// MemberAbilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-memberabilities
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MemberAbilities { get; set; }
            /// <summary>
            /// PaymentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-memberspecification.html#cfn-cleanrooms-collaboration-memberspecification-paymentconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PaymentConfiguration
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration, BaseFunction>? PaymentConfiguration { get; set; }
        }

        public class ModelInferencePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-modelinferencepaymentconfig.html#cfn-cleanrooms-collaboration-modelinferencepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class ModelTrainingPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-modeltrainingpaymentconfig.html#cfn-cleanrooms-collaboration-modeltrainingpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class PaymentConfiguration : Humidifier.Base.BaseSubResource, IHaveCleanRoomsCollaborationTypesJobComputePaymentConfigJobCompute, IHaveCleanRoomsCollaborationTypesMLPaymentConfigMachineLearning, IHaveCleanRoomsCollaborationTypesQueryComputePaymentConfigQueryCompute
        {
            /// <summary>
            /// JobCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-paymentconfiguration.html#cfn-cleanrooms-collaboration-paymentconfiguration-jobcompute
            /// Required: False
            /// UpdateType: Immutable
            /// Type: JobComputePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.JobComputePaymentConfig, BaseFunction>? JobCompute { get; set; }
            /// <summary>
            /// MachineLearning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-paymentconfiguration.html#cfn-cleanrooms-collaboration-paymentconfiguration-machinelearning
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MLPaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.MLPaymentConfig, BaseFunction>? MachineLearning { get; set; }
            /// <summary>
            /// QueryCompute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-paymentconfiguration.html#cfn-cleanrooms-collaboration-paymentconfiguration-querycompute
            /// Required: True
            /// UpdateType: Immutable
            /// Type: QueryComputePaymentConfig
            /// </summary>
            public Union<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig, BaseFunction>? QueryCompute { get; set; }
        }

        public class QueryComputePaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-querycomputepaymentconfig.html#cfn-cleanrooms-collaboration-querycomputepaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }

        public class SyntheticDataGenerationPaymentConfig : Humidifier.Base.BaseSubResource, IHaveIsResponsible_Boolean
        {
            /// <summary>
            /// IsResponsible
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-collaboration-syntheticdatagenerationpaymentconfig.html#cfn-cleanrooms-collaboration-syntheticdatagenerationpaymentconfig-isresponsible
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsResponsible { get; set; }
        }
    }
}