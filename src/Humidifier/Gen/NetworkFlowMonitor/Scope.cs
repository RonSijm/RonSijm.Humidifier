namespace Humidifier.NetworkFlowMonitor
{
    using global::System.Collections.Generic;
    using ScopeTypes;

    public class Scope : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ScopeArn =  "ScopeArn" ;
            public static string ScopeId =  "ScopeId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkFlowMonitor.Scope; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-scope.html#cfn-networkflowmonitor-scope-targets
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: TargetResource
        /// </summary>
        [Required]
        public List<Humidifier.NetworkFlowMonitor.ScopeTypes.TargetResource> Targets { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkflowmonitor-scope.html#cfn-networkflowmonitor-scope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ScopeTypes
    {
        public class TargetId : Humidifier.Base.BaseSubResource, IHaveAccountId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-scope-targetid.html#cfn-networkflowmonitor-scope-targetid-accountid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
        }

        public class TargetIdentifier : Humidifier.Base.BaseSubResource, IHaveTargetType
        {
            /// <summary>
            /// TargetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-scope-targetidentifier.html#cfn-networkflowmonitor-scope-targetidentifier-targettype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetType { get; set; }
            /// <summary>
            /// TargetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-scope-targetidentifier.html#cfn-networkflowmonitor-scope-targetidentifier-targetid
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TargetId
            /// </summary>
            public Humidifier.NetworkFlowMonitor.ScopeTypes.TargetId TargetId { get; set; }
        }

        public class TargetResource : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// TargetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-scope-targetresource.html#cfn-networkflowmonitor-scope-targetresource-targetidentifier
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TargetIdentifier
            /// </summary>
            public Humidifier.NetworkFlowMonitor.ScopeTypes.TargetIdentifier TargetIdentifier { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkflowmonitor-scope-targetresource.html#cfn-networkflowmonitor-scope-targetresource-region
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }
    }
}