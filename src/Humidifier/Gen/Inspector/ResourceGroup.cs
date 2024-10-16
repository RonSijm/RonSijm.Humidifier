namespace Humidifier.Inspector
{
    using System.Collections.Generic;

    public class ResourceGroup : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Inspector.ResourceGroup; }

        /// <summary>
        /// ResourceGroupTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspector-resourcegroup.html#cfn-inspector-resourcegroup-resourcegrouptags
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        [Required]
        public List<Tag> ResourceGroupTags { get; set; }
    }
}