namespace Humidifier.RAM
{
    using global::System.Collections.Generic;

    public class SourceAssociation : Humidifier.Base.BaseResource, IHaveResourceShareArn, IHaveSourceId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SourceType =  "SourceType" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.RAM.SourceAssociation; }

        /// <summary>
        /// ResourceShareArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-sourceassociation.html#cfn-ram-sourceassociation-resourcesharearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceShareArn { get; set; }

        /// <summary>
        /// SourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-sourceassociation.html#cfn-ram-sourceassociation-sourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceId { get; set; }
    }
}