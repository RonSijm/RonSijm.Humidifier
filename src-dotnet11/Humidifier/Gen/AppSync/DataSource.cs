namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveAppSyncDataSourceTypesOpenSearchServiceConfigOpenSearchServiceConfig, IHaveType, IHaveDescription, IHaveServiceRoleArn, IHaveAppSyncDataSourceTypesEventBridgeConfigEventBridgeConfig, IHaveAppSyncDataSourceTypesHttpConfigHttpConfig, IHaveAppSyncDataSourceTypesRelationalDatabaseConfigRelationalDatabaseConfig, IHaveAppSyncDataSourceTypesLambdaConfigLambdaConfig, IHaveApiId, IHaveMetricsConfig, IHaveName, IHaveAppSyncDataSourceTypesDynamoDBConfigDynamoDBConfig
    {
        public class Attributes
        {
            public static string DataSourceArn =  "DataSourceArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.DataSource; }
        /// <summary>
        /// OpenSearchServiceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-opensearchserviceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenSearchServiceConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.OpenSearchServiceConfig, BaseFunction>? OpenSearchServiceConfig { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ServiceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-servicerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceRoleArn { get; set; }
        /// <summary>
        /// EventBridgeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-eventbridgeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EventBridgeConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.EventBridgeConfig, BaseFunction>? EventBridgeConfig { get; set; }
        /// <summary>
        /// HttpConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-httpconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: HttpConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.HttpConfig, BaseFunction>? HttpConfig { get; set; }
        /// <summary>
        /// RelationalDatabaseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-relationaldatabaseconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RelationalDatabaseConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.RelationalDatabaseConfig, BaseFunction>? RelationalDatabaseConfig { get; set; }
        /// <summary>
        /// LambdaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-lambdaconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.LambdaConfig, BaseFunction>? LambdaConfig { get; set; }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApiId { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-metricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MetricsConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DynamoDBConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-datasource.html#cfn-appsync-datasource-dynamodbconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DynamoDBConfig
        /// </summary>
        public Union<Humidifier.AppSync.DataSourceTypes.DynamoDBConfig, BaseFunction>? DynamoDBConfig { get; set; }
    }

    namespace DataSourceTypes
    {
        public class AuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveAppSyncDataSourceTypesAwsIamConfigAwsIamConfig, IHaveAuthorizationType
        {
            /// <summary>
            /// AwsIamConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-authorizationconfig.html#cfn-appsync-datasource-authorizationconfig-awsiamconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsIamConfig
            /// </summary>
            public Union<Humidifier.AppSync.DataSourceTypes.AwsIamConfig, BaseFunction>? AwsIamConfig { get; set; }
            /// <summary>
            /// AuthorizationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-authorizationconfig.html#cfn-appsync-datasource-authorizationconfig-authorizationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationType { get; set; }
        }

        public class AwsIamConfig : Humidifier.Base.BaseSubResource, IHaveSigningRegion, IHaveSigningServiceName
        {
            /// <summary>
            /// SigningRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-awsiamconfig.html#cfn-appsync-datasource-awsiamconfig-signingregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningRegion { get; set; }
            /// <summary>
            /// SigningServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-awsiamconfig.html#cfn-appsync-datasource-awsiamconfig-signingservicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningServiceName { get; set; }
        }

        public class DeltaSyncConfig : Humidifier.Base.BaseSubResource, IHaveBaseTableTTL, IHaveDeltaSyncTableTTL, IHaveDeltaSyncTableName
        {
            /// <summary>
            /// BaseTableTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-basetablettl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseTableTTL { get; set; }
            /// <summary>
            /// DeltaSyncTableTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-deltasynctablettl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeltaSyncTableTTL { get; set; }
            /// <summary>
            /// DeltaSyncTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-deltasynctablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeltaSyncTableName { get; set; }
        }

        public class DynamoDBConfig : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveAwsRegion, IHaveVersioned_Boolean, IHaveAppSyncDataSourceTypesDeltaSyncConfigDeltaSyncConfig, IHaveUseCallerCredentials_Boolean
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-awsregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// Versioned
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-versioned
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Versioned { get; set; }
            /// <summary>
            /// DeltaSyncConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-deltasyncconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeltaSyncConfig
            /// </summary>
            public Union<Humidifier.AppSync.DataSourceTypes.DeltaSyncConfig, BaseFunction>? DeltaSyncConfig { get; set; }
            /// <summary>
            /// UseCallerCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-usecallercredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseCallerCredentials { get; set; }
        }

        public class EventBridgeConfig : Humidifier.Base.BaseSubResource, IHaveEventBusArn
        {
            /// <summary>
            /// EventBusArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-eventbridgeconfig.html#cfn-appsync-datasource-eventbridgeconfig-eventbusarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventBusArn { get; set; }
        }

        public class HttpConfig : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveAppSyncDataSourceTypesAuthorizationConfigAuthorizationConfig
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-httpconfig.html#cfn-appsync-datasource-httpconfig-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-httpconfig.html#cfn-appsync-datasource-httpconfig-authorizationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationConfig
            /// </summary>
            public Union<Humidifier.AppSync.DataSourceTypes.AuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
        }

        public class LambdaConfig : Humidifier.Base.BaseSubResource, IHaveLambdaFunctionArn
        {
            /// <summary>
            /// LambdaFunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-lambdaconfig.html#cfn-appsync-datasource-lambdaconfig-lambdafunctionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaFunctionArn { get; set; }
        }

        public class OpenSearchServiceConfig : Humidifier.Base.BaseSubResource, IHaveAwsRegion, IHaveEndpoint
        {
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-opensearchserviceconfig.html#cfn-appsync-datasource-opensearchserviceconfig-awsregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-opensearchserviceconfig.html#cfn-appsync-datasource-opensearchserviceconfig-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
        }

        public class RdsHttpEndpointConfig : Humidifier.Base.BaseSubResource, IHaveAwsRegion, IHaveSchema, IHaveDatabaseName, IHaveDbClusterIdentifier, IHaveAwsSecretStoreArn
        {
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html#cfn-appsync-datasource-rdshttpendpointconfig-awsregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html#cfn-appsync-datasource-rdshttpendpointconfig-schema
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html#cfn-appsync-datasource-rdshttpendpointconfig-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// DbClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html#cfn-appsync-datasource-rdshttpendpointconfig-dbclusteridentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbClusterIdentifier { get; set; }
            /// <summary>
            /// AwsSecretStoreArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-rdshttpendpointconfig.html#cfn-appsync-datasource-rdshttpendpointconfig-awssecretstorearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsSecretStoreArn { get; set; }
        }

        public class RelationalDatabaseConfig : Humidifier.Base.BaseSubResource, IHaveAppSyncDataSourceTypesRdsHttpEndpointConfigRdsHttpEndpointConfig, IHaveRelationalDatabaseSourceType
        {
            /// <summary>
            /// RdsHttpEndpointConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-relationaldatabaseconfig.html#cfn-appsync-datasource-relationaldatabaseconfig-rdshttpendpointconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RdsHttpEndpointConfig
            /// </summary>
            public Union<Humidifier.AppSync.DataSourceTypes.RdsHttpEndpointConfig, BaseFunction>? RdsHttpEndpointConfig { get; set; }
            /// <summary>
            /// RelationalDatabaseSourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-relationaldatabaseconfig.html#cfn-appsync-datasource-relationaldatabaseconfig-relationaldatabasesourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RelationalDatabaseSourceType { get; set; }
        }
    }
}