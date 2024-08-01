namespace Humidifier.EMR
{
    using System.Collections.Generic;

    public class WALWorkspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public override string AWSTypeName { get => AWS.EMR.WALWorkspace; }
        public dynamic WALWorkspaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-walworkspace.html#cfn-emr-walworkspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}