namespace Humidifier.SimSpaceWeaver
{
    using System.Collections.Generic;
    using SimulationTypes;

    public class Simulation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveRoleArn, IHaveMaximumDuration
    {
        public class Attributes
        {
            public static string DescribePayload =  "DescribePayload" ;
        }

        public override string AWSTypeName { get => AWS.SimSpaceWeaver.Simulation; }
        /// <summary>
        /// SchemaS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-simspaceweaver-simulation.html#cfn-simspaceweaver-simulation-schemas3location
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3Location
        /// </summary>
        public Humidifier.SimSpaceWeaver.SimulationTypes.S3Location SchemaS3Location { get; set; }
        /// <summary>
        /// SnapshotS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-simspaceweaver-simulation.html#cfn-simspaceweaver-simulation-snapshots3location
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3Location
        /// </summary>
        public Humidifier.SimSpaceWeaver.SimulationTypes.S3Location SnapshotS3Location { get; set; }
        /// <summary>
        /// MaximumDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-simspaceweaver-simulation.html#cfn-simspaceweaver-simulation-maximumduration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MaximumDuration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-simspaceweaver-simulation.html#cfn-simspaceweaver-simulation-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SimulationTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simspaceweaver-simulation-s3location.html#cfn-simspaceweaver-simulation-s3location-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simspaceweaver-simulation-s3location.html#cfn-simspaceweaver-simulation-s3location-objectkey
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKey { get; set; }
        }
    }
}