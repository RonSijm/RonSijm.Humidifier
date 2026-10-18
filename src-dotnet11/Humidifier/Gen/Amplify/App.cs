namespace Humidifier.Amplify
{
    using global::System.Collections.Generic;
    using AppTypes;

    public class App : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAmplifyAppTypesAutoBranchCreationConfigAutoBranchCreationConfig, IHaveOauthToken, IHaveDescription, IHavePlatform, IHaveEnableBranchAutoDeletion_Boolean, IHaveAmplifyAppTypesJobConfigJobConfig, IHaveName, IHaveComputeRoleArn, IHaveRepository, IHaveListOfAmplifyAppTypesEnvironmentVariableEnvironmentVariables, IHaveAccessToken, IHaveBuildSpec, IHaveListOfAmplifyAppTypesCustomRuleCustomRules, IHaveAmplifyAppTypesBasicAuthConfigBasicAuthConfig, IHaveAmplifyAppTypesCacheConfigCacheConfig, IHaveCustomHeaders, IHaveIAMServiceRole
    {
        public class Attributes
        {
            public static string AppId =  "AppId" ;
            public static string Arn =  "Arn" ;
            public static string DefaultDomain =  "DefaultDomain" ;
            public static string AppName =  "AppName" ;
        }

        public override string AWSTypeName { get => AWS.Amplify.App; }
        /// <summary>
        /// AutoBranchCreationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-autobranchcreationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoBranchCreationConfig
        /// </summary>
        public Union<Humidifier.Amplify.AppTypes.AutoBranchCreationConfig, BaseFunction>? AutoBranchCreationConfig { get; set; }
        /// <summary>
        /// OauthToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-oauthtoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OauthToken { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Platform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-platform
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Platform { get; set; }
        /// <summary>
        /// EnableBranchAutoDeletion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-enablebranchautodeletion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableBranchAutoDeletion { get; set; }
        /// <summary>
        /// JobConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-jobconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobConfig
        /// </summary>
        public Union<Humidifier.Amplify.AppTypes.JobConfig, BaseFunction>? JobConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ComputeRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-computerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputeRoleArn { get; set; }
        /// <summary>
        /// Repository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-repository
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Repository { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentVariable
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Amplify.AppTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.Amplify.AppTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
        /// <summary>
        /// AccessToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-accesstoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccessToken { get; set; }
        /// <summary>
        /// BuildSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-buildspec
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BuildSpec { get; set; }
        /// <summary>
        /// CustomRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomRule
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Amplify.AppTypes.CustomRule>, IReadOnlyList<Union<Humidifier.Amplify.AppTypes.CustomRule, BaseFunction>>, BaseFunction>? CustomRules { get; set; }
        /// <summary>
        /// BasicAuthConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-basicauthconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BasicAuthConfig
        /// </summary>
        public Union<Humidifier.Amplify.AppTypes.BasicAuthConfig, BaseFunction>? BasicAuthConfig { get; set; }
        /// <summary>
        /// CacheConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-cacheconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheConfig
        /// </summary>
        public Union<Humidifier.Amplify.AppTypes.CacheConfig, BaseFunction>? CacheConfig { get; set; }
        /// <summary>
        /// CustomHeaders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customheaders
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomHeaders { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IAMServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-iamservicerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IAMServiceRole { get; set; }
    }

    namespace AppTypes
    {
        public class AutoBranchCreationConfig : Humidifier.Base.BaseSubResource, IHaveListOfAmplifyAppTypesEnvironmentVariableEnvironmentVariables, IHaveStringListOfAutoBranchCreationPatterns, IHaveEnableAutoBranchCreation_Boolean, IHavePullRequestEnvironmentName, IHaveEnablePullRequestPreview_Boolean, IHaveEnableAutoBuild_Boolean, IHaveEnablePerformanceMode_Boolean, IHaveBuildSpec, IHaveStage, IHaveAmplifyAppTypesBasicAuthConfigBasicAuthConfig, IHaveFramework
        {
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Amplify.AppTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.Amplify.AppTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }
            /// <summary>
            /// AutoBranchCreationPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-autobranchcreationpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AutoBranchCreationPatterns { get; set; }
            /// <summary>
            /// EnableAutoBranchCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enableautobranchcreation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAutoBranchCreation { get; set; }
            /// <summary>
            /// PullRequestEnvironmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-pullrequestenvironmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PullRequestEnvironmentName { get; set; }
            /// <summary>
            /// EnablePullRequestPreview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enablepullrequestpreview
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnablePullRequestPreview { get; set; }
            /// <summary>
            /// EnableAutoBuild
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enableautobuild
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableAutoBuild { get; set; }
            /// <summary>
            /// EnablePerformanceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enableperformancemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnablePerformanceMode { get; set; }
            /// <summary>
            /// BuildSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-buildspec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildSpec { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-stage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stage { get; set; }
            /// <summary>
            /// BasicAuthConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-basicauthconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthConfig
            /// </summary>
            public Union<Humidifier.Amplify.AppTypes.BasicAuthConfig, BaseFunction>? BasicAuthConfig { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-framework
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Framework { get; set; }
        }

        public class BasicAuthConfig : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveEnableBasicAuth_Boolean, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// EnableBasicAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-enablebasicauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableBasicAuth { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class CacheConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-cacheconfig.html#cfn-amplify-app-cacheconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class CustomRule : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveStatus, IHaveTarget, IHaveSource
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-condition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Target { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-environmentvariable.html#cfn-amplify-app-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-environmentvariable.html#cfn-amplify-app-environmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class JobConfig : Humidifier.Base.BaseSubResource, IHaveBuildComputeType
        {
            /// <summary>
            /// BuildComputeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-jobconfig.html#cfn-amplify-app-jobconfig-buildcomputetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildComputeType { get; set; }
        }
    }
}