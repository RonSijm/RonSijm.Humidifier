namespace Humidifier.Amplify
{
    using global::System.Collections.Generic;
    using BranchTypes;

    public class Branch : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEnablePerformanceMode_Boolean, IHaveComputeRoleArn, IHaveAmplifyBranchTypesBackendBackend, IHaveListOfAmplifyBranchTypesEnvironmentVariableEnvironmentVariables, IHaveAppId, IHavePullRequestEnvironmentName, IHaveEnablePullRequestPreview_Boolean, IHaveEnableSkewProtection_Boolean, IHaveEnableAutoBuild_Boolean, IHaveBuildSpec, IHaveStage, IHaveBranchName, IHaveAmplifyBranchTypesBasicAuthConfigBasicAuthConfig, IHaveFramework
    {
        public class Attributes
        {
            public static string BranchName =  "BranchName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Amplify.Branch; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnablePerformanceMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-enableperformancemode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnablePerformanceMode { get; set; }
        /// <summary>
        /// ComputeRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-computerolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputeRoleArn { get; set; }
        /// <summary>
        /// Backend
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-backend
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Backend
        /// </summary>
        public Union<Humidifier.Amplify.BranchTypes.Backend, BaseFunction>? Backend { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentVariable
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Amplify.BranchTypes.EnvironmentVariable>, IReadOnlyList<Union<Humidifier.Amplify.BranchTypes.EnvironmentVariable, BaseFunction>>, BaseFunction>? EnvironmentVariables { get; set; }

        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-appid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppId { get; set; }
        /// <summary>
        /// PullRequestEnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-pullrequestenvironmentname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PullRequestEnvironmentName { get; set; }
        /// <summary>
        /// EnablePullRequestPreview
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-enablepullrequestpreview
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnablePullRequestPreview { get; set; }
        /// <summary>
        /// EnableSkewProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-enableskewprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSkewProtection { get; set; }
        /// <summary>
        /// EnableAutoBuild
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-enableautobuild
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableAutoBuild { get; set; }
        /// <summary>
        /// BuildSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-buildspec
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BuildSpec { get; set; }
        /// <summary>
        /// Stage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-stage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Stage { get; set; }
        public Union<string, BaseFunction>? BranchName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BasicAuthConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-basicauthconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BasicAuthConfig
        /// </summary>
        public Union<Humidifier.Amplify.BranchTypes.BasicAuthConfig, BaseFunction>? BasicAuthConfig { get; set; }
        /// <summary>
        /// Framework
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-framework
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Framework { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-branch.html#cfn-amplify-branch-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BranchTypes
    {
        public class Backend : Humidifier.Base.BaseSubResource, IHaveStackArn
        {
            /// <summary>
            /// StackArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-backend.html#cfn-amplify-branch-backend-stackarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StackArn { get; set; }
        }

        public class BasicAuthConfig : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveEnableBasicAuth_Boolean, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-basicauthconfig.html#cfn-amplify-branch-basicauthconfig-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// EnableBasicAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-basicauthconfig.html#cfn-amplify-branch-basicauthconfig-enablebasicauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableBasicAuth { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-basicauthconfig.html#cfn-amplify-branch-basicauthconfig-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class EnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-environmentvariable.html#cfn-amplify-branch-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-branch-environmentvariable.html#cfn-amplify-branch-environmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}