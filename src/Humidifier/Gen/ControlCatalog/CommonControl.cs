namespace Humidifier.ControlCatalog
{
    using global::System.Collections.Generic;
    using CommonControlTypes;

    public class CommonControl : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Objective =  "Objective" ;
            public static string Description =  "Description" ;
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
            public static string Domain =  "Domain" ;
            public static string CommonControlId =  "CommonControlId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ControlCatalog.CommonControl; }
    }

    namespace CommonControlTypes
    {
        public class Domain : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-commoncontrol-domain.html#cfn-controlcatalog-commoncontrol-domain-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-commoncontrol-domain.html#cfn-controlcatalog-commoncontrol-domain-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Objective : Humidifier.Base.BaseSubResource, IHaveName, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-commoncontrol-objective.html#cfn-controlcatalog-commoncontrol-objective-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-commoncontrol-objective.html#cfn-controlcatalog-commoncontrol-objective-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}