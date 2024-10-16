namespace Humidifier.SupportApp
{
    using System.Collections.Generic;

    public class AccountAlias : Humidifier.Base.BaseResource
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
        public dynamic AccountAlias_ { get; set; }
    }
}