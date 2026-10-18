namespace Humidifier.SecurityLake
{
    using global::System.Collections.Generic;

    public class AwsLogSource : Humidifier.Base.BaseResource, IHaveSourceName, IHaveSourceVersion, IHaveStringListOfAccounts, IHaveDataLakeArn
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
        public Union<string, BaseFunction>? SourceName { get; set; }

        /// <summary>
        /// SourceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-sourceversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceVersion { get; set; }
        /// <summary>
        /// Accounts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-accounts
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Accounts { get; set; }

        /// <summary>
        /// DataLakeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securitylake-awslogsource.html#cfn-securitylake-awslogsource-datalakearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataLakeArn { get; set; }
    }
}