namespace Humidifier.Proton
{
    using global::System.Collections.Generic;

    public class EnvironmentAccountConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveEnvironmentName, IHaveComponentRoleArn, IHaveManagementAccountId, IHaveCodebuildRoleArn, IHaveEnvironmentAccountId, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Proton.EnvironmentAccountConnection; }
        /// <summary>
        /// EnvironmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-environmentname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentName { get; set; }
        /// <summary>
        /// ComponentRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-componentrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComponentRoleArn { get; set; }
        /// <summary>
        /// ManagementAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-managementaccountid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ManagementAccountId { get; set; }
        /// <summary>
        /// CodebuildRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-codebuildrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CodebuildRoleArn { get; set; }
        /// <summary>
        /// EnvironmentAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-environmentaccountid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentAccountId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-proton-environmentaccountconnection.html#cfn-proton-environmentaccountconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}