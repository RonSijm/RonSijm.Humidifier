namespace Humidifier.AWSExternalAnthropic
{
    using global::System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency DataResidency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-awsexternalanthropic-workspace.html#cfn-awsexternalanthropic-workspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace WorkspaceTypes
    {
        public class DataResidency : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultInferenceGeo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-defaultinferencegeo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultInferenceGeo { get; set; }
            /// <summary>
            /// AllowedInferenceGeos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-allowedinferencegeos
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedInferenceGeos { get; set; }
            /// <summary>
            /// WorkspaceGeo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-awsexternalanthropic-workspace-dataresidency.html#cfn-awsexternalanthropic-workspace-dataresidency-workspacegeo
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkspaceGeo { get; set; }
        }
    }
}