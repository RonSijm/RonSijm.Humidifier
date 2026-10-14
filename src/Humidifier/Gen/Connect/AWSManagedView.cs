namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class AWSManagedView : Humidifier.Base.BaseResource, IHaveInstanceId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string Description =  "Description" ;
            public static string Version =  "Version" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Connect.AWSManagedView; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-awsmanagedview.html#cfn-connect-awsmanagedview-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceId { get; set; }
        /// <summary>
        /// ViewId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-awsmanagedview.html#cfn-connect-awsmanagedview-viewid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ViewId { get; set; }
    }
}