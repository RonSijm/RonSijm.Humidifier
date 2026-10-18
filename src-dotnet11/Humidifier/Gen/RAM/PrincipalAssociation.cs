namespace Humidifier.RAM
{
    using global::System.Collections.Generic;

    public class PrincipalAssociation : Humidifier.Base.BaseResource, IHaveResourceShareArn, IHavePrincipal
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AssociationType =  "AssociationType" ;
            public static string CreationTime =  "CreationTime" ;
            public static string External =  "External" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
        }

        public override string AWSTypeName { get => AWS.RAM.PrincipalAssociation; }

        /// <summary>
        /// ResourceShareArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-principalassociation.html#cfn-ram-principalassociation-resourcesharearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceShareArn { get; set; }

        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ram-principalassociation.html#cfn-ram-principalassociation-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Principal { get; set; }
    }
}