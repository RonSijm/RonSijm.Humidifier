namespace Humidifier.Cases
{
    using global::System.Collections.Generic;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string DomainId =  "DomainId" ;
            public static string DomainArn =  "DomainArn" ;
            public static string DomainStatus =  "DomainStatus" ;
        }

        public override string AWSTypeName { get => AWS.Cases.Domain; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cases-domain.html#cfn-cases-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}