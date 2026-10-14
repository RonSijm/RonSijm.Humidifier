namespace Humidifier.NetworkSecurityManager
{
    using global::System.Collections.Generic;

    public class Scope : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ScopeArn =  "ScopeArn" ;
            public static string Version =  "Version" ;
            public static string ScopeId =  "ScopeId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkSecurityManager.Scope; }
        public dynamic ScopeName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ScopeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-scope.html#cfn-networksecuritymanager-scope-scopeconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScopeConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-scope.html#cfn-networksecuritymanager-scope-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ScopeDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networksecuritymanager-scope.html#cfn-networksecuritymanager-scope-scopedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScopeDescription { get; set; }

        [Ignore]
        public dynamic Description { get => ScopeDescription; set => ScopeDescription = value; }
    }
}