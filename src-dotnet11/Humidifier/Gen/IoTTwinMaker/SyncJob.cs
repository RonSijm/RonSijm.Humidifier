namespace Humidifier.IoTTwinMaker
{
    using global::System.Collections.Generic;

    public class SyncJob : Humidifier.Base.BaseResource, IHaveSyncSource, IHaveSyncRole, IHaveWorkspaceId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string State =  "State" ;
            public static string UpdateDateTime =  "UpdateDateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTTwinMaker.SyncJob; }

        /// <summary>
        /// SyncSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-syncjob.html#cfn-iottwinmaker-syncjob-syncsource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SyncSource { get; set; }

        /// <summary>
        /// SyncRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-syncjob.html#cfn-iottwinmaker-syncjob-syncrole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SyncRole { get; set; }

        /// <summary>
        /// WorkspaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-syncjob.html#cfn-iottwinmaker-syncjob-workspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-syncjob.html#cfn-iottwinmaker-syncjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}