namespace Humidifier.IoTTwinMaker
{
    using global::System.Collections.Generic;

    public class Scene : Humidifier.Base.BaseResource, IHaveSceneId, IHaveDescription, IHaveStringDictionaryOfSceneMetadata, IHaveContentLocation, IHaveStringListOfCapabilities, IHaveWorkspaceId, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string UpdateDateTime =  "UpdateDateTime" ;
            public static string Arn =  "Arn" ;
            public static string GeneratedSceneMetadata =  "GeneratedSceneMetadata" ;
        }

        public override string AWSTypeName { get => AWS.IoTTwinMaker.Scene; }

        /// <summary>
        /// SceneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-sceneid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SceneId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SceneMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-scenemetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? SceneMetadata { get; set; }

        /// <summary>
        /// ContentLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-contentlocation
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContentLocation { get; set; }
        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-capabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Capabilities { get; set; }

        /// <summary>
        /// WorkspaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-workspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkspaceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iottwinmaker-scene.html#cfn-iottwinmaker-scene-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}