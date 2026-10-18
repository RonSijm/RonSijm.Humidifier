namespace Humidifier.SupportApp
{
    using global::System.Collections.Generic;

    public class AccountAlias : Humidifier.Base.BaseResource, IHaveAccountAlias_
    {
        public class Attributes
        {
            public static string AccountAliasResourceId =  "AccountAliasResourceId" ;
        }

        public override string AWSTypeName { get => AWS.SupportApp.AccountAlias; }

        /// <summary>
        /// AccountAlias_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-accountalias.html#cfn-supportapp-accountalias-accountalias
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AccountAlias_ { get; set; }
    }
}