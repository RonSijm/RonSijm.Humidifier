namespace Humidifier.Personalize
{
    using System.Collections.Generic;

    public class Schema : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDomain
    {
        public class Attributes
        {
            public static string SchemaArn =  "SchemaArn" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.Schema; }

        /// <summary>
        /// Schema_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-schema.html#cfn-personalize-schema-schema
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Schema_ { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-schema.html#cfn-personalize-schema-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Domain { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}