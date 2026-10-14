namespace Humidifier.ControlCatalog
{
    using global::System.Collections.Generic;
    using ControlTypes;

    public class Control : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Description =  "Description" ;
            public static string GovernedResources =  "GovernedResources" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Severity =  "Severity" ;
            public static string Aliases =  "Aliases" ;
            public static string Implementation =  "Implementation" ;
            public static string Name =  "Name" ;
            public static string RegionConfiguration =  "RegionConfiguration" ;
            public static string Behavior =  "Behavior" ;
            public static string Arn =  "Arn" ;
            public static string ControlId =  "ControlId" ;
        }

        public override string AWSTypeName { get => AWS.ControlCatalog.Control; }
    }

    namespace ControlTypes
    {
        public class ImplementationDetails : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-control-implementationdetails.html#cfn-controlcatalog-control-implementationdetails-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-control-implementationdetails.html#cfn-controlcatalog-control-implementationdetails-identifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class RegionConfiguration : Humidifier.Base.BaseSubResource, IHaveScope
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-control-regionconfiguration.html#cfn-controlcatalog-control-regionconfiguration-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
            /// <summary>
            /// DeployableRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-controlcatalog-control-regionconfiguration.html#cfn-controlcatalog-control-regionconfiguration-deployableregions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DeployableRegions { get; set; }
        }
    }
}