namespace Humidifier.AWSExternalAnthropic
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAWSExternalAnthropicWorkspaceTypesDataResidencyDataResidency, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AWSExternalAnthropic.Workspace; }
        /// <summary>
        /// DataResidency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-awsexternalanthropic-workspace.html#cfn-awsexternalanthropic-workspace-dataresidency
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataResidency
        /// </summary>
        public Union<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency, BaseFunction>? DataResidency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-awsexternalanthropic-workspace.html#cfn-awsexternalanthropic-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkspaceTypes
    {
        public class DataResidency : Humidifier.Base.BaseSubResource, IHaveDefaultInferenceGeo, IHaveStringListOfAllowedInferenceGeos, IHaveWorkspaceGeo
        {
            /// <summary>
            /// DefaultInferenceGeo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-defaultinferencegeo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultInferenceGeo { get; set; }
            /// <summary>
            /// AllowedInferenceGeos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-allowedinferencegeos
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInferenceGeos { get; set; }
            /// <summary>
            /// WorkspaceGeo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-workspacegeo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkspaceGeo { get; set; }
        }
    }
}