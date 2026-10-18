namespace Humidifier.EMR
{
    using global::System.Collections.Generic;

    public class WALWorkspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveWALWorkspaceName
    {
        public override string AWSTypeName { get => AWS.EMR.WALWorkspace; }
        public Union<string, BaseFunction>? WALWorkspaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-walworkspace.html#cfn-emr-walworkspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}