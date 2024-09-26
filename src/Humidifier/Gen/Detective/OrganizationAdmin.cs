namespace Humidifier.Detective
{
    using System.Collections.Generic;

    public class OrganizationAdmin : Humidifier.Base.BaseResource, IHaveAccountId
    {
        public class Attributes
        {
            public static string GraphArn =  "GraphArn" ;
        }

        public override string AWSTypeName { get => AWS.Detective.OrganizationAdmin; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-organizationadmin.html#cfn-detective-organizationadmin-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccountId { get; set; }
    }
}