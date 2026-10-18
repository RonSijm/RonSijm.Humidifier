namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using AnalysisTemplateTypes;

    public class AnalysisTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMembershipIdentifier, IHaveDescription, IHaveFormat, IHaveCleanRoomsAnalysisTemplateTypesAnalysisSourceMetadataSourceMetadata, IHaveCleanRoomsAnalysisTemplateTypesErrorMessageConfigurationErrorMessageConfiguration, IHaveListOfCleanRoomsAnalysisTemplateTypesAnalysisParameterAnalysisParameters, IHaveCleanRoomsAnalysisTemplateTypesAnalysisSchemaSchema, IHaveCleanRoomsAnalysisTemplateTypesSyntheticDataParametersSyntheticDataParameters, IHaveCleanRoomsAnalysisTemplateTypesAnalysisSourceSource, IHaveName
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationArn =  "CollaborationArn" ;
            public static string AnalysisTemplateIdentifier =  "AnalysisTemplateIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.AnalysisTemplate; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// SourceMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-sourcemetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalysisSourceMetadata
        /// </summary>
        public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata, BaseFunction>? SourceMetadata { get; set; }
        /// <summary>
        /// ErrorMessageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-errormessageconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ErrorMessageConfiguration
        /// </summary>
        public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration, BaseFunction>? ErrorMessageConfiguration { get; set; }
        /// <summary>
        /// AnalysisParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-analysisparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AnalysisParameter
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter>, IReadOnlyList<Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter, BaseFunction>>, BaseFunction>? AnalysisParameters { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-schema
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AnalysisSchema
        /// </summary>
        public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema, BaseFunction>? Schema { get; set; }
        /// <summary>
        /// SyntheticDataParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-syntheticdataparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SyntheticDataParameters
        /// </summary>
        public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters, BaseFunction>? SyntheticDataParameters { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AnalysisSource
        /// </summary>
        [Required]
        public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AnalysisTemplateTypes
    {
        public class AnalysisParameter : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveType, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class AnalysisSchema : Humidifier.Base.BaseSubResource, IHaveStringListOfReferencedTables
        {
            /// <summary>
            /// ReferencedTables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisschema.html#cfn-cleanrooms-analysistemplate-analysisschema-referencedtables
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReferencedTables { get; set; }
        }

        public class AnalysisSource : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesAnalysisTemplateArtifactsArtifacts, IHaveText
        {
            /// <summary>
            /// Artifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissource.html#cfn-cleanrooms-analysistemplate-analysissource-artifacts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AnalysisTemplateArtifacts
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts, BaseFunction>? Artifacts { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissource.html#cfn-cleanrooms-analysistemplate-analysissource-text
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class AnalysisSourceMetadata : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesAnalysisTemplateArtifactMetadataArtifacts
        {
            /// <summary>
            /// Artifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissourcemetadata.html#cfn-cleanrooms-analysistemplate-analysissourcemetadata-artifacts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AnalysisTemplateArtifactMetadata
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata, BaseFunction>? Artifacts { get; set; }
        }

        public class AnalysisTemplateArtifact : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesS3LocationLocation
        {
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifact.html#cfn-cleanrooms-analysistemplate-analysistemplateartifact-location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location, BaseFunction>? Location { get; set; }
        }

        public class AnalysisTemplateArtifactMetadata : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesHashEntryPointHash, IHaveListOfCleanRoomsAnalysisTemplateTypesHashAdditionalArtifactHashes
        {
            /// <summary>
            /// EntryPointHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifactmetadata.html#cfn-cleanrooms-analysistemplate-analysistemplateartifactmetadata-entrypointhash
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Hash
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash, BaseFunction>? EntryPointHash { get; set; }
            /// <summary>
            /// AdditionalArtifactHashes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifactmetadata.html#cfn-cleanrooms-analysistemplate-analysistemplateartifactmetadata-additionalartifacthashes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Hash
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash>, IReadOnlyList<Union<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash, BaseFunction>>, BaseFunction>? AdditionalArtifactHashes { get; set; }
        }

        public class AnalysisTemplateArtifacts : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsAnalysisTemplateTypesAnalysisTemplateArtifactAdditionalArtifacts, IHaveCleanRoomsAnalysisTemplateTypesAnalysisTemplateArtifactEntryPoint, IHaveRoleArn
        {
            /// <summary>
            /// AdditionalArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-additionalartifacts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AnalysisTemplateArtifact
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact>, IReadOnlyList<Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact, BaseFunction>>, BaseFunction>? AdditionalArtifacts { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AnalysisTemplateArtifact
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact, BaseFunction>? EntryPoint { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ColumnClassificationDetails : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsAnalysisTemplateTypesSyntheticDataColumnPropertiesColumnMapping
        {
            /// <summary>
            /// ColumnMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-columnclassificationdetails.html#cfn-cleanrooms-analysistemplate-columnclassificationdetails-columnmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SyntheticDataColumnProperties
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataColumnProperties>, IReadOnlyList<Union<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataColumnProperties, BaseFunction>>, BaseFunction>? ColumnMapping { get; set; }
        }

        public class ErrorMessageConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-errormessageconfiguration.html#cfn-cleanrooms-analysistemplate-errormessageconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class Hash : Humidifier.Base.BaseSubResource, IHaveSha256
        {
            /// <summary>
            /// Sha256
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-hash.html#cfn-cleanrooms-analysistemplate-hash-sha256
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sha256 { get; set; }
        }

        public class MLSyntheticDataParameters : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesColumnClassificationDetailsColumnClassification, IHaveEpsilon_Double, IHaveMaxMembershipInferenceAttackScore_Double
        {
            /// <summary>
            /// ColumnClassification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-columnclassification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ColumnClassificationDetails
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails, BaseFunction>? ColumnClassification { get; set; }
            /// <summary>
            /// Epsilon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-epsilon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Epsilon { get; set; }
            /// <summary>
            /// MaxMembershipInferenceAttackScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-maxmembershipinferenceattackscore
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxMembershipInferenceAttackScore { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-s3location.html#cfn-cleanrooms-analysistemplate-s3location-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-s3location.html#cfn-cleanrooms-analysistemplate-s3location-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class SyntheticDataColumnProperties : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveColumnType, IHaveIsPredictiveValue_Boolean
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-columnname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-columntype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnType { get; set; }
            /// <summary>
            /// IsPredictiveValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-ispredictivevalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsPredictiveValue { get; set; }
        }

        public class SyntheticDataParameters : Humidifier.Base.BaseSubResource, IHaveCleanRoomsAnalysisTemplateTypesMLSyntheticDataParametersMlSyntheticDataParameters
        {
            /// <summary>
            /// MlSyntheticDataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdataparameters.html#cfn-cleanrooms-analysistemplate-syntheticdataparameters-mlsyntheticdataparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MLSyntheticDataParameters
            /// </summary>
            public Union<Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters, BaseFunction>? MlSyntheticDataParameters { get; set; }
        }
    }
}