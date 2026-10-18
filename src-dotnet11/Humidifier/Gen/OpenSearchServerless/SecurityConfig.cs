namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using SecurityConfigTypes;

    public class SecurityConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveDescription, IHaveOpenSearchServerlessSecurityConfigTypesSamlConfigOptionsSamlOptions, IHaveOpenSearchServerlessSecurityConfigTypesIamFederationConfigOptionsIamFederationOptions, IHaveName, IHaveOpenSearchServerlessSecurityConfigTypesIamIdentityCenterConfigOptionsIamIdentityCenterOptions
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchServerless.SecurityConfig; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SamlOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-samloptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SamlConfigOptions
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions, BaseFunction>? SamlOptions { get; set; }
        /// <summary>
        /// IamFederationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-iamfederationoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IamFederationConfigOptions
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamFederationConfigOptions, BaseFunction>? IamFederationOptions { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IamIdentityCenterOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-iamidentitycenteroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IamIdentityCenterConfigOptions
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions, BaseFunction>? IamIdentityCenterOptions { get; set; }
    }

    namespace SecurityConfigTypes
    {
        public class IamFederationConfigOptions : Humidifier.Base.BaseSubResource, IHaveUserAttribute, IHaveGroupAttribute
        {
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamfederationconfigoptions.html#cfn-opensearchserverless-securityconfig-iamfederationconfigoptions-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAttribute { get; set; }
            /// <summary>
            /// GroupAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamfederationconfigoptions.html#cfn-opensearchserverless-securityconfig-iamfederationconfigoptions-groupattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupAttribute { get; set; }
        }

        public class IamIdentityCenterConfigOptions : Humidifier.Base.BaseSubResource, IHaveApplicationArn, IHaveApplicationName, IHaveUserAttribute, IHaveInstanceArn, IHaveApplicationDescription, IHaveGroupAttribute
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationName { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAttribute { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceArn { get; set; }
            /// <summary>
            /// ApplicationDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationDescription { get; set; }
            /// <summary>
            /// GroupAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-groupattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupAttribute { get; set; }
        }

        public class SamlConfigOptions : Humidifier.Base.BaseSubResource, IHaveSessionTimeout_Integer, IHaveOpenSearchServerlessEntityId, IHaveUserAttribute, IHaveMetadata, IHaveGroupAttribute
        {
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SessionTimeout { get; set; }
            /// <summary>
            /// OpenSearchServerlessEntityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-opensearchserverlessentityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OpenSearchServerlessEntityId { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAttribute { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-metadata
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// GroupAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-groupattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupAttribute { get; set; }
        }
    }
}