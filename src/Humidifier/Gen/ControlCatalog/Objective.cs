namespace Humidifier.ControlCatalog
{
    using global::System.Collections.Generic;
    using ObjectiveTypes;

    public class Objective : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ObjectiveId =  "ObjectiveId" ;
            public static string Description =  "Description" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
            public static string Domain =  "Domain" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ControlCatalog.Objective; }
    }

    namespace ObjectiveTypes
    {
        public class Domain : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-objective-domain.html#cfn-controlcatalog-objective-domain-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-objective-domain.html#cfn-controlcatalog-objective-domain-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}