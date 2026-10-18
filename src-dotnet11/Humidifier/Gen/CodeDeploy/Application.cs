namespace Humidifier.CodeDeploy
{
    using global::System.Collections.Generic;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveApplicationName, IHaveComputePlatform
    {
        public override string AWSTypeName { get => AWS.CodeDeploy.Application; }
        public Union<string, BaseFunction>? ApplicationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ComputePlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-application.html#cfn-codedeploy-application-computeplatform
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputePlatform { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-application.html#cfn-codedeploy-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}