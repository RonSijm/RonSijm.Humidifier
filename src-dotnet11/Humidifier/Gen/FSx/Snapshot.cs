namespace Humidifier.FSx
{
    using global::System.Collections.Generic;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVolumeId, IHaveName
    {
        public class Attributes
        {
            public static string ResourceARN =  "ResourceARN" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.FSx.Snapshot; }

        /// <summary>
        /// VolumeId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-snapshot.html#cfn-fsx-snapshot-volumeid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VolumeId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-snapshot.html#cfn-fsx-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}