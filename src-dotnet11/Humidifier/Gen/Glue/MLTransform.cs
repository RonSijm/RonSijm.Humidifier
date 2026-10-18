namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using MLTransformTypes;

    public class MLTransform : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMaxRetries_Integer, IHaveDescription, IHaveGlueMLTransformTypesTransformEncryptionTransformEncryption, IHaveTimeout_Integer, IHaveName, IHaveRole, IHaveWorkerType, IHaveGlueVersion, IHaveGlueMLTransformTypesTransformParametersTransformParameters, IHaveNumberOfWorkers_Integer, IHaveGlueMLTransformTypesInputRecordTablesInputRecordTables, IHaveStringDictionaryOfTags, IHaveMaxCapacity_Double
    {
        public class Attributes
        {
            public static string TransformId =  "TransformId" ;
        }

        public override string AWSTypeName { get => AWS.Glue.MLTransform; }
        /// <summary>
        /// MaxRetries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-maxretries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxRetries { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TransformEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-transformencryption
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TransformEncryption
        /// </summary>
        public Union<Humidifier.Glue.MLTransformTypes.TransformEncryption, BaseFunction>? TransformEncryption { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Timeout { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-role
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// WorkerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-workertype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkerType { get; set; }
        /// <summary>
        /// GlueVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-glueversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlueVersion { get; set; }

        /// <summary>
        /// TransformParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-transformparameters
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TransformParameters
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.MLTransformTypes.TransformParameters, BaseFunction>? TransformParameters { get; set; }
        /// <summary>
        /// NumberOfWorkers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-numberofworkers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumberOfWorkers { get; set; }

        /// <summary>
        /// InputRecordTables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-inputrecordtables
        /// Required: True
        /// UpdateType: Immutable
        /// Type: InputRecordTables
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.MLTransformTypes.InputRecordTables, BaseFunction>? InputRecordTables { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-mltransform.html#cfn-glue-mltransform-maxcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MaxCapacity { get; set; }
    }

    namespace MLTransformTypes
    {
        public class FindMatchesParameters : Humidifier.Base.BaseSubResource, IHavePrecisionRecallTradeoff_Double, IHaveEnforceProvidedLabels_Boolean, IHavePrimaryKeyColumnName, IHaveAccuracyCostTradeoff_Double
        {
            /// <summary>
            /// PrecisionRecallTradeoff
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-findmatchesparameters.html#cfn-glue-mltransform-findmatchesparameters-precisionrecalltradeoff
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PrecisionRecallTradeoff { get; set; }
            /// <summary>
            /// EnforceProvidedLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-findmatchesparameters.html#cfn-glue-mltransform-findmatchesparameters-enforceprovidedlabels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnforceProvidedLabels { get; set; }
            /// <summary>
            /// PrimaryKeyColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-findmatchesparameters.html#cfn-glue-mltransform-findmatchesparameters-primarykeycolumnname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryKeyColumnName { get; set; }
            /// <summary>
            /// AccuracyCostTradeoff
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-findmatchesparameters.html#cfn-glue-mltransform-findmatchesparameters-accuracycosttradeoff
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? AccuracyCostTradeoff { get; set; }
        }

        public class GlueTables : Humidifier.Base.BaseSubResource, IHaveConnectionName, IHaveTableName, IHaveDatabaseName, IHaveCatalogId
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-gluetables.html#cfn-glue-mltransform-gluetables-connectionname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionName { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-gluetables.html#cfn-glue-mltransform-gluetables-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-gluetables.html#cfn-glue-mltransform-gluetables-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-gluetables.html#cfn-glue-mltransform-gluetables-catalogid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class InputRecordTables : Humidifier.Base.BaseSubResource, IHaveListOfGlueMLTransformTypesGlueTablesGlueTables
        {
            /// <summary>
            /// GlueTables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-inputrecordtables.html#cfn-glue-mltransform-inputrecordtables-gluetables
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: GlueTables
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.MLTransformTypes.GlueTables>, IReadOnlyList<Union<Humidifier.Glue.MLTransformTypes.GlueTables, BaseFunction>>, BaseFunction>? GlueTables { get; set; }
        }

        public class MLUserDataEncryption : Humidifier.Base.BaseSubResource, IHaveMLUserDataEncryptionMode, IHaveKmsKeyId
        {
            /// <summary>
            /// MLUserDataEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-mluserdataencryption.html#cfn-glue-mltransform-mluserdataencryption-mluserdataencryptionmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MLUserDataEncryptionMode { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-mluserdataencryption.html#cfn-glue-mltransform-mluserdataencryption-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class TransformEncryption : Humidifier.Base.BaseSubResource, IHaveGlueMLTransformTypesMLUserDataEncryptionMLUserDataEncryption, IHaveTaskRunSecurityConfigurationName
        {
            /// <summary>
            /// MLUserDataEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption.html#cfn-glue-mltransform-transformencryption-mluserdataencryption
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MLUserDataEncryption
            /// </summary>
            public Union<Humidifier.Glue.MLTransformTypes.MLUserDataEncryption, BaseFunction>? MLUserDataEncryption { get; set; }
            /// <summary>
            /// TaskRunSecurityConfigurationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption.html#cfn-glue-mltransform-transformencryption-taskrunsecurityconfigurationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskRunSecurityConfigurationName { get; set; }
        }

        public class TransformParameters : Humidifier.Base.BaseSubResource, IHaveTransformType, IHaveGlueMLTransformTypesFindMatchesParametersFindMatchesParameters
        {
            /// <summary>
            /// TransformType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformparameters.html#cfn-glue-mltransform-transformparameters-transformtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransformType { get; set; }
            /// <summary>
            /// FindMatchesParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformparameters.html#cfn-glue-mltransform-transformparameters-findmatchesparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FindMatchesParameters
            /// </summary>
            public Union<Humidifier.Glue.MLTransformTypes.FindMatchesParameters, BaseFunction>? FindMatchesParameters { get; set; }
        }
    }
}