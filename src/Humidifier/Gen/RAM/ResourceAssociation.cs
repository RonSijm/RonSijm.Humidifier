namespace Humidifier.RAM
{
    using global::System.Collections.Generic;

    public class ResourceAssociation : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AssociationType =  "AssociationType" ;
            public static string CreationTime =  "CreationTime" ;
            public static string External =  "External" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.RAM.ResourceAssociation; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceassociation.html#cfn-ram-resourceassociation-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// ResourceShareArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-resourceassociation.html#cfn-ram-resourceassociation-resourcesharearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceShareArn { get; set; }
    }
}