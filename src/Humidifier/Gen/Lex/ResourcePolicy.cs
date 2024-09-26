namespace Humidifier.Lex
{
    using System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHavePolicy, IHaveResourceArn
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string RevisionId =  "RevisionId" ;
        }

        public override string AWSTypeName { get => AWS.Lex.ResourcePolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-resourcepolicy.html#cfn-lex-resourcepolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-resourcepolicy.html#cfn-lex-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }
    }
}