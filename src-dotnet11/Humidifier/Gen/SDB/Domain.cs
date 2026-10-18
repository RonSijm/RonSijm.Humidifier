namespace Humidifier.SDB
{
    using global::System.Collections.Generic;

    public class Domain : Humidifier.Base.BaseResource, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SDB.Domain; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sdb-domain.html#cfn-sdb-domain-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
    }
}