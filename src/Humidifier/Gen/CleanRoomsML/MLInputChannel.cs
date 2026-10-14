namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using MLInputChannelTypes;

    public class MLInputChannel : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string NumberOfRecords =  "NumberOfRecords" ;
            public static string Name =  "Name" ;
            public static string RetentionInDays =  "RetentionInDays" ;
            public static string MembershipIdentifier =  "MembershipIdentifier" ;
            public static string KmsKeyArn =  "KmsKeyArn" ;
            public static string ConfiguredModelAlgorithmAssociations =  "ConfiguredModelAlgorithmAssociations" ;
            public static string InputChannel =  "InputChannel" ;
            public static string MlInputChannelArn =  "MlInputChannelArn" ;
            public static string ProtectedQueryIdentifier =  "ProtectedQueryIdentifier" ;
            public static string PrivacyBudgets =  "PrivacyBudgets" ;
            public static string Tags =  "Tags" ;
            public static string Status =  "Status" ;
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string CreateTime =  "CreateTime" ;
            public static string SyntheticDataConfiguration =  "SyntheticDataConfiguration" ;
            public static string SizeInGb =  "SizeInGb" ;
            public static string NumberOfFiles =  "NumberOfFiles" ;
            public static string UpdateTime =  "UpdateTime" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.MLInputChannel; }
    }

    namespace MLInputChannelTypes
    {
        public class AccessBudget : Humidifier.Base.BaseSubResource, IHaveResourceArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudget.html#cfn-cleanroomsml-mlinputchannel-accessbudget-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// Details
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudget.html#cfn-cleanroomsml-mlinputchannel-accessbudget-details
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AccessBudgetDetails
            /// </summary>
            public List<Humidifier.CleanRoomsML.MLInputChannelTypes.AccessBudgetDetails> Details { get; set; }
            /// <summary>
            /// AggregateRemainingBudget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudget.html#cfn-cleanroomsml-mlinputchannel-accessbudget-aggregateremainingbudget
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AggregateRemainingBudget { get; set; }
        }

        public class AccessBudgetDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RemainingBudget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudgetdetails.html#cfn-cleanroomsml-mlinputchannel-accessbudgetdetails-remainingbudget
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RemainingBudget { get; set; }
            /// <summary>
            /// Budget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudgetdetails.html#cfn-cleanroomsml-mlinputchannel-accessbudgetdetails-budget
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Budget { get; set; }
            /// <summary>
            /// BudgetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudgetdetails.html#cfn-cleanroomsml-mlinputchannel-accessbudgetdetails-budgettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BudgetType { get; set; }
            /// <summary>
            /// AutoRefresh
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-accessbudgetdetails.html#cfn-cleanroomsml-mlinputchannel-accessbudgetdetails-autorefresh
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoRefresh { get; set; }
        }

        public class ColumnClassificationDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-columnclassificationdetails.html#cfn-cleanroomsml-mlinputchannel-columnclassificationdetails-columnmapping
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SyntheticDataColumnProperties
            /// </summary>
            public List<Humidifier.CleanRoomsML.MLInputChannelTypes.SyntheticDataColumnProperties> ColumnMapping { get; set; }
        }

        public class ComputeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Worker
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-computeconfiguration.html#cfn-cleanroomsml-mlinputchannel-computeconfiguration-worker
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WorkerComputeConfiguration
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.WorkerComputeConfiguration Worker { get; set; }
        }

        public class InputChannel : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-inputchannel.html#cfn-cleanroomsml-mlinputchannel-inputchannel-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-inputchannel.html#cfn-cleanroomsml-mlinputchannel-inputchannel-datasource
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InputChannelDataSource
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.InputChannelDataSource DataSource { get; set; }
        }

        public class InputChannelDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProtectedQueryInputParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-inputchanneldatasource.html#cfn-cleanroomsml-mlinputchannel-inputchanneldatasource-protectedqueryinputparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedQueryInputParameters
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.ProtectedQueryInputParameters ProtectedQueryInputParameters { get; set; }
        }

        public class MLSyntheticDataParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnClassification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-mlsyntheticdataparameters.html#cfn-cleanroomsml-mlinputchannel-mlsyntheticdataparameters-columnclassification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ColumnClassificationDetails
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.ColumnClassificationDetails ColumnClassification { get; set; }
            /// <summary>
            /// Epsilon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-mlsyntheticdataparameters.html#cfn-cleanroomsml-mlinputchannel-mlsyntheticdataparameters-epsilon
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Epsilon { get; set; }
            /// <summary>
            /// MaxMembershipInferenceAttackScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-mlsyntheticdataparameters.html#cfn-cleanroomsml-mlinputchannel-mlsyntheticdataparameters-maxmembershipinferenceattackscore
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxMembershipInferenceAttackScore { get; set; }
        }

        public class PrivacyBudgets : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccessBudgets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-privacybudgets.html#cfn-cleanroomsml-mlinputchannel-privacybudgets-accessbudgets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AccessBudget
            /// </summary>
            public List<Humidifier.CleanRoomsML.MLInputChannelTypes.AccessBudget> AccessBudgets { get; set; }
        }

        public class Properties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Spark
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-properties.html#cfn-cleanroomsml-mlinputchannel-properties-spark
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Spark { get; set; }
        }

        public class ProtectedQueryInputParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SqlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedqueryinputparameters.html#cfn-cleanroomsml-mlinputchannel-protectedqueryinputparameters-sqlparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProtectedQuerySQLParameters
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.ProtectedQuerySQLParameters SqlParameters { get; set; }
            /// <summary>
            /// ResultFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedqueryinputparameters.html#cfn-cleanroomsml-mlinputchannel-protectedqueryinputparameters-resultformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultFormat { get; set; }
            /// <summary>
            /// ComputeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedqueryinputparameters.html#cfn-cleanroomsml-mlinputchannel-protectedqueryinputparameters-computeconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComputeConfiguration
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.ComputeConfiguration ComputeConfiguration { get; set; }
        }

        public class ProtectedQuerySQLParameters : Humidifier.Base.BaseSubResource, IHaveQueryString
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedquerysqlparameters.html#cfn-cleanroomsml-mlinputchannel-protectedquerysqlparameters-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Parameters { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedquerysqlparameters.html#cfn-cleanroomsml-mlinputchannel-protectedquerysqlparameters-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// AnalysisTemplateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-protectedquerysqlparameters.html#cfn-cleanroomsml-mlinputchannel-protectedquerysqlparameters-analysistemplatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AnalysisTemplateArn { get; set; }
        }

        public class SyntheticDataColumnProperties : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveColumnType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties.html#cfn-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties-columnname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties.html#cfn-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties-columntype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnType { get; set; }
            /// <summary>
            /// IsPredictiveValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties.html#cfn-cleanroomsml-mlinputchannel-syntheticdatacolumnproperties-ispredictivevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsPredictiveValue { get; set; }
        }

        public class SyntheticDataConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SyntheticDataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-syntheticdataconfiguration.html#cfn-cleanroomsml-mlinputchannel-syntheticdataconfiguration-syntheticdataparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MLSyntheticDataParameters
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.MLSyntheticDataParameters SyntheticDataParameters { get; set; }
        }

        public class WorkerComputeConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-workercomputeconfiguration.html#cfn-cleanroomsml-mlinputchannel-workercomputeconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Number
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-workercomputeconfiguration.html#cfn-cleanroomsml-mlinputchannel-workercomputeconfiguration-number
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Number { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-mlinputchannel-workercomputeconfiguration.html#cfn-cleanroomsml-mlinputchannel-workercomputeconfiguration-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Properties
            /// </summary>
            public Humidifier.CleanRoomsML.MLInputChannelTypes.Properties Properties { get; set; }
        }
    }
}