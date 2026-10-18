namespace Humidifier.IVS
{
    using global::System.Collections.Generic;

    public class IngestConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveUserId, IHaveIngestProtocol, IHaveStageArn, IHaveInsecureIngest_Boolean, IHaveName
    {
        public class Attributes
        {
            public static string ParticipantId =  "ParticipantId" ;
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string StreamKey =  "StreamKey" ;
        }

        public override string AWSTypeName { get => AWS.IVS.IngestConfiguration; }
        /// <summary>
        /// UserId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-ingestconfiguration.html#cfn-ivs-ingestconfiguration-userid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UserId { get; set; }
        /// <summary>
        /// IngestProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-ingestconfiguration.html#cfn-ivs-ingestconfiguration-ingestprotocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IngestProtocol { get; set; }
        /// <summary>
        /// StageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-ingestconfiguration.html#cfn-ivs-ingestconfiguration-stagearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StageArn { get; set; }
        /// <summary>
        /// InsecureIngest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-ingestconfiguration.html#cfn-ivs-ingestconfiguration-insecureingest
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? InsecureIngest { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-ingestconfiguration.html#cfn-ivs-ingestconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}