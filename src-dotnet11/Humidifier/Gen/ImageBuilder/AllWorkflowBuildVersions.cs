namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using AllWorkflowBuildVersionsTypes;

    public class AllWorkflowBuildVersions : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Owner =  "Owner" ;
            public static string Description =  "Description" ;
            public static string Parameters =  "Parameters" ;
            public static string DateCreated =  "DateCreated" ;
            public static string Data =  "Data" ;
            public static string Name =  "Name" ;
            public static string BuildNumber =  "BuildNumber" ;
            public static string Version =  "Version" ;
            public static string WorkflowType =  "WorkflowType" ;
            public static string ChangeDescription =  "ChangeDescription" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
            public static string WorkflowVersionArn =  "WorkflowVersionArn" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.AllWorkflowBuildVersions; }
    }

    namespace AllWorkflowBuildVersionsTypes
    {
        public class ParametersItems : Humidifier.Base.BaseSubResource, IHaveStringListOfDefaultValue, IHaveType, IHaveDescription, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-parametersitems.html#cfn-imagebuilder-allworkflowbuildversions-parametersitems-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-parametersitems.html#cfn-imagebuilder-allworkflowbuildversions-parametersitems-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-parametersitems.html#cfn-imagebuilder-allworkflowbuildversions-parametersitems-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-parametersitems.html#cfn-imagebuilder-allworkflowbuildversions-parametersitems-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-tagsitems.html#cfn-imagebuilder-allworkflowbuildversions-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-allworkflowbuildversions-tagsitems.html#cfn-imagebuilder-allworkflowbuildversions-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}