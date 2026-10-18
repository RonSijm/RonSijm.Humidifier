namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using ConfiguredAudienceModelTypes;

    public class ConfiguredAudienceModel : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Description =  "Description" ;
            public static string CreateTime =  "CreateTime" ;
            public static string MinMatchingSeedSize =  "MinMatchingSeedSize" ;
            public static string AudienceSizeConfig =  "AudienceSizeConfig" ;
            public static string Name =  "Name" ;
            public static string OutputConfig =  "OutputConfig" ;
            public static string SharedAudienceMetrics =  "SharedAudienceMetrics" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string ConfiguredAudienceModelArn =  "ConfiguredAudienceModelArn" ;
            public static string Tags =  "Tags" ;
            public static string AudienceModelArn =  "AudienceModelArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.ConfiguredAudienceModel; }
    }

    namespace ConfiguredAudienceModelTypes
    {
        public class AudienceDestination : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredAudienceModelTypesS3ConfigMapS3Destination
        {
            /// <summary>
            /// S3Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-audiencedestination.html#cfn-cleanroomsml-configuredaudiencemodel-audiencedestination-s3destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3ConfigMap
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredAudienceModelTypes.S3ConfigMap, BaseFunction>? S3Destination { get; set; }
        }

        public class AudienceSizeConfig : Humidifier.Base.BaseSubResource, IHaveIntegerListOfAudienceSizeBins, IHaveAudienceSizeType
        {
            /// <summary>
            /// AudienceSizeBins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-audiencesizeconfig.html#cfn-cleanroomsml-configuredaudiencemodel-audiencesizeconfig-audiencesizebins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? AudienceSizeBins { get; set; }
            /// <summary>
            /// AudienceSizeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-audiencesizeconfig.html#cfn-cleanroomsml-configuredaudiencemodel-audiencesizeconfig-audiencesizetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudienceSizeType { get; set; }
        }

        public class ConfiguredAudienceModelOutputConfig : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLConfiguredAudienceModelTypesAudienceDestinationDestination, IHaveRoleArn
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-configuredaudiencemodeloutputconfig.html#cfn-cleanroomsml-configuredaudiencemodel-configuredaudiencemodeloutputconfig-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudienceDestination
            /// </summary>
            public Union<Humidifier.CleanRoomsML.ConfiguredAudienceModelTypes.AudienceDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-configuredaudiencemodeloutputconfig.html#cfn-cleanroomsml-configuredaudiencemodel-configuredaudiencemodeloutputconfig-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class S3ConfigMap : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-configuredaudiencemodel-s3configmap.html#cfn-cleanroomsml-configuredaudiencemodel-s3configmap-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }
    }
}