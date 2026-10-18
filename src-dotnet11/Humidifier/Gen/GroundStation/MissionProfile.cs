namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using MissionProfileTypes;

    public class MissionProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTelemetrySinkConfigArn, IHaveGroundStationMissionProfileTypesStreamsKmsKeyStreamsKmsKey, IHaveMinimumViableContactDurationSeconds_Integer, IHaveContactPostPassDurationSeconds_Integer, IHaveListOfGroundStationMissionProfileTypesDataflowEdgeDataflowEdges, IHaveTrackingConfigArn, IHaveStreamsKmsRole, IHaveName, IHaveContactPrePassDurationSeconds_Integer
    {
        public class Attributes
        {
            public static string Region =  "Region" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.GroundStation.MissionProfile; }
        /// <summary>
        /// TelemetrySinkConfigArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-telemetrysinkconfigarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TelemetrySinkConfigArn { get; set; }
        /// <summary>
        /// StreamsKmsKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-streamskmskey
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamsKmsKey
        /// </summary>
        public Union<Humidifier.GroundStation.MissionProfileTypes.StreamsKmsKey, BaseFunction>? StreamsKmsKey { get; set; }

        /// <summary>
        /// MinimumViableContactDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-minimumviablecontactdurationseconds
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MinimumViableContactDurationSeconds { get; set; }
        /// <summary>
        /// ContactPostPassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-contactpostpassdurationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPostPassDurationSeconds { get; set; }

        /// <summary>
        /// DataflowEdges
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-dataflowedges
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataflowEdge
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge>, IReadOnlyList<Union<Humidifier.GroundStation.MissionProfileTypes.DataflowEdge, BaseFunction>>, BaseFunction>? DataflowEdges { get; set; }

        /// <summary>
        /// TrackingConfigArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-trackingconfigarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrackingConfigArn { get; set; }
        /// <summary>
        /// StreamsKmsRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-streamskmsrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StreamsKmsRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContactPrePassDurationSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-groundstation-missionprofile.html#cfn-groundstation-missionprofile-contactprepassdurationseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ContactPrePassDurationSeconds { get; set; }
    }

    namespace MissionProfileTypes
    {
        public class DataflowEdge : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveSource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-dataflowedge.html#cfn-groundstation-missionprofile-dataflowedge-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-dataflowedge.html#cfn-groundstation-missionprofile-dataflowedge-source
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }

        public class StreamsKmsKey : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveKmsAliasArn, IHaveKmsAliasName
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-streamskmskey.html#cfn-groundstation-missionprofile-streamskmskey-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// KmsAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-streamskmskey.html#cfn-groundstation-missionprofile-streamskmskey-kmsaliasarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsAliasArn { get; set; }
            /// <summary>
            /// KmsAliasName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-missionprofile-streamskmskey.html#cfn-groundstation-missionprofile-streamskmskey-kmsaliasname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsAliasName { get; set; }
        }
    }
}