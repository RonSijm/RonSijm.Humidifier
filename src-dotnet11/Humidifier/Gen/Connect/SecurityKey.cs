namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class SecurityKey : Humidifier.Base.BaseResource, IHaveInstanceId, IHaveKey
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.SecurityKey; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securitykey.html#cfn-connect-securitykey-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }

        /// <summary>
        /// Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-securitykey.html#cfn-connect-securitykey-key
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Key { get; set; }
    }
}