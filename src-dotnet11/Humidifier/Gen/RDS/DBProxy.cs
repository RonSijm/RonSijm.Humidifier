namespace Humidifier.RDS
{
    using global::System.Collections.Generic;
    using DBProxyTypes;

    public class DBProxy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDBProxyName, IHaveDebugLogging_Boolean, IHaveStringListOfVpcSubnetIds, IHaveRoleArn, IHaveRequireTLS_Boolean, IHaveIdleClientTimeout_Integer, IHaveTargetConnectionNetworkType, IHaveDefaultAuthScheme, IHaveStringListOfVpcSecurityGroupIds, IHaveListOfRDSDBProxyTypesAuthFormatAuth, IHaveEngineFamily, IHaveListOfRDSDBProxyTypesTagFormatTags, IHaveEndpointNetworkType
    {
        public class Attributes
        {
            public static string Endpoint =  "Endpoint" ;
            public static string VpcId =  "VpcId" ;
            public static string DBProxyArn =  "DBProxyArn" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBProxy; }
        public Union<string, BaseFunction>? DBProxyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DebugLogging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-debuglogging
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DebugLogging { get; set; }

        /// <summary>
        /// VpcSubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-vpcsubnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSubnetIds { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// RequireTLS
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-requiretls
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequireTLS { get; set; }
        /// <summary>
        /// IdleClientTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-idleclienttimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? IdleClientTimeout { get; set; }
        /// <summary>
        /// TargetConnectionNetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-targetconnectionnetworktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetConnectionNetworkType { get; set; }
        /// <summary>
        /// DefaultAuthScheme
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-defaultauthscheme
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultAuthScheme { get; set; }
        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        /// <summary>
        /// Auth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-auth
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AuthFormat
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RDS.DBProxyTypes.AuthFormat>, IReadOnlyList<Union<Humidifier.RDS.DBProxyTypes.AuthFormat, BaseFunction>>, BaseFunction>? Auth { get; set; }

        /// <summary>
        /// EngineFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-enginefamily
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EngineFamily { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagFormat
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RDS.DBProxyTypes.TagFormat>, IReadOnlyList<Union<Humidifier.RDS.DBProxyTypes.TagFormat, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// EndpointNetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbproxy.html#cfn-rds-dbproxy-endpointnetworktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointNetworkType { get; set; }
    }

    namespace DBProxyTypes
    {
        public class AuthFormat : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveDescription, IHaveIAMAuth, IHaveClientPasswordAuthType, IHaveAuthScheme
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html#cfn-rds-dbproxy-authformat-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html#cfn-rds-dbproxy-authformat-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// IAMAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html#cfn-rds-dbproxy-authformat-iamauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IAMAuth { get; set; }
            /// <summary>
            /// ClientPasswordAuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html#cfn-rds-dbproxy-authformat-clientpasswordauthtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientPasswordAuthType { get; set; }
            /// <summary>
            /// AuthScheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-authformat.html#cfn-rds-dbproxy-authformat-authscheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthScheme { get; set; }
        }

        public class TagFormat : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-tagformat.html#cfn-rds-dbproxy-tagformat-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbproxy-tagformat.html#cfn-rds-dbproxy-tagformat-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}