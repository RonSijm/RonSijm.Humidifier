namespace Humidifier.Inspector
{
    using global::System.Collections.Generic;

    public class ResourceGroup : Humidifier.Base.BaseResource, IHaveTagListOfResourceGroupTags
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
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? ResourceGroupTags { get; set; }
    }
}