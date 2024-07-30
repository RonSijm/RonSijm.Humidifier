namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class DelegatedAdmin : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DelegatedAdminIdentifier =  "DelegatedAdminIdentifier" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecurityHub::DelegatedAdmin";
            }
        }

        /// <summary>
        /// AdminAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-delegatedadmin.html#cfn-securityhub-delegatedadmin-adminaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AdminAccountId { get; set; }
    }
}