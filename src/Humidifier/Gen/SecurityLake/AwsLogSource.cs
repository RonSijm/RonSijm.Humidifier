namespace Humidifier.SecurityLake
{
    using System.Collections.Generic;

    public class AwsLogSource : Humidifier.Base.BaseResource, IHaveSourceVersion, IHaveSourceName, IHaveAccounts, IHaveDataLakeArn
    {
        public override string AWSTypeName { get => AWS.SecurityLake.AwsLogSource; }

        /// <summary>
        /// SourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-sourcename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SourceName { get; set; }

        /// <summary>
        /// SourceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-sourceversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SourceVersion { get; set; }
        /// <summary>
        /// Accounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-accounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Accounts { get; set; }

        /// <summary>
        /// DataLakeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-datalakearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataLakeArn { get; set; }
    }
}