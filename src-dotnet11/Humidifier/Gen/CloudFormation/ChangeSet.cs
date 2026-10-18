namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;
    using ChangeSetTypes;

    public class ChangeSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveUsePreviousTemplate_Boolean, IHaveDescription, IHaveIncludeNestedStacks_Boolean, IHaveStringListOfNotificationARNs, IHaveTemplateBody, IHaveChangeSetName, IHaveRoleARN, IHaveImportExistingResources_Boolean, IHaveTemplateURL, IHaveOnStackFailure, IHaveStringListOfCapabilities, IHaveChangeSetType, IHaveDeploymentMode, IHaveStackName, IHaveListOfCloudFormationChangeSetTypesTagsItemsTags
    {
        public class Attributes
        {
            public static string ChangeSetId =  "ChangeSetId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string StackId =  "StackId" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.ChangeSet; }
        /// <summary>
        /// UsePreviousTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-useprevioustemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UsePreviousTemplate { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IncludeNestedStacks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-includenestedstacks
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IncludeNestedStacks { get; set; }
        /// <summary>
        /// NotificationARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-notificationarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotificationARNs { get; set; }
        /// <summary>
        /// TemplateBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-templatebody
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateBody { get; set; }
        public Union<string, BaseFunction>? ChangeSetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleARN { get; set; }
        /// <summary>
        /// ImportExistingResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-importexistingresources
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ImportExistingResources { get; set; }
        /// <summary>
        /// TemplateURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-templateurl
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TemplateURL { get; set; }
        /// <summary>
        /// OnStackFailure
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-onstackfailure
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OnStackFailure { get; set; }
        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-capabilities
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Capabilities { get; set; }
        /// <summary>
        /// ChangeSetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-changesettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ChangeSetType { get; set; }
        /// <summary>
        /// DeploymentMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-deploymentmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentMode { get; set; }

        /// <summary>
        /// StackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-stackname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StackName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-changeset.html#cfn-cloudformation-changeset-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudFormation.ChangeSetTypes.TagsItems>, IReadOnlyList<Union<Humidifier.CloudFormation.ChangeSetTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ChangeSetTypes
    {
        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-changeset-tagsitems.html#cfn-cloudformation-changeset-tagsitems-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudformation-changeset-tagsitems.html#cfn-cloudformation-changeset-tagsitems-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}