namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;

    public class ContactMethod : Humidifier.Base.BaseResource, IHaveContactEndpoint, IHaveProtocol
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SupportCode =  "SupportCode" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ResourceType =  "ResourceType" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.ContactMethod; }

        /// <summary>
        /// ContactEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-contactmethod.html#cfn-lightsail-contactmethod-contactendpoint
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ContactEndpoint { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-contactmethod.html#cfn-lightsail-contactmethod-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
    }
}