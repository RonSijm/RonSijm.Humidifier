namespace Humidifier.OpenSearchServerless
{
    using System.Collections.Generic;
    using SecurityConfigTypes;

    public class SecurityConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveType
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
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// SamlOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-samloptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SamlConfigOptions
        /// </summary>
        public Humidifier.OpenSearchServerless.SecurityConfigTypes.SamlConfigOptions SamlOptions { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// IamIdentityCenterOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-securityconfig.html#cfn-opensearchserverless-securityconfig-iamidentitycenteroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IamIdentityCenterConfigOptions
        /// </summary>
        public Humidifier.OpenSearchServerless.SecurityConfigTypes.IamIdentityCenterConfigOptions IamIdentityCenterOptions { get; set; }
    }

    namespace SecurityConfigTypes
    {
        public class IamIdentityCenterConfigOptions : Humidifier.Base.BaseSubResource, IHaveInstanceArn, IHaveApplicationName, IHaveApplicationArn, IHaveApplicationDescription, IHaveUserAttribute, IHaveGroupAttribute
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationArn { get; set; }
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationName { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserAttribute { get; set; }
            /// <summary>
            /// InstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-instancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceArn { get; set; }
            /// <summary>
            /// ApplicationDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-applicationdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationDescription { get; set; }
            /// <summary>
            /// GroupAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-iamidentitycenterconfigoptions.html#cfn-opensearchserverless-securityconfig-iamidentitycenterconfigoptions-groupattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupAttribute { get; set; }
        }

        public class SamlConfigOptions : Humidifier.Base.BaseSubResource, IHaveSessionTimeout, IHaveUserAttribute, IHaveMetadata, IHaveGroupAttribute
        {
            /// <summary>
            /// SessionTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-sessiontimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SessionTimeout { get; set; }
            /// <summary>
            /// UserAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-userattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserAttribute { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-metadata
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Metadata { get; set; }
            /// <summary>
            /// GroupAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-securityconfig-samlconfigoptions.html#cfn-opensearchserverless-securityconfig-samlconfigoptions-groupattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupAttribute { get; set; }
        }
    }
}