namespace Humidifier.ResourceExplorer2
{
    using System.Collections.Generic;

    public class DefaultViewAssociation : Humidifier.Base.BaseResource, IHaveViewArn
    {
        public class Attributes
        {
            public static string AssociatedAwsPrincipal =  "AssociatedAwsPrincipal" ;
        }

        public override string AWSTypeName { get => AWS.ResourceExplorer2.DefaultViewAssociation; }

        /// <summary>
        /// ViewArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resourceexplorer2-defaultviewassociation.html#cfn-resourceexplorer2-defaultviewassociation-viewarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ViewArn { get; set; }
    }
}