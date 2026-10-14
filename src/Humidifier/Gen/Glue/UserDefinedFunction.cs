namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using UserDefinedFunctionTypes;

    public class UserDefinedFunction : Humidifier.Base.BaseResource, IHaveDatabaseName, IHaveFunctionName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.UserDefinedFunction; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// OwnerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-ownername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OwnerName { get; set; }
        /// <summary>
        /// OwnerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-ownertype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OwnerType { get; set; }
        /// <summary>
        /// FunctionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-functiontype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionType { get; set; }
        /// <summary>
        /// ResourceUris
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-resourceuris
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceUri
        /// </summary>
        public List<Humidifier.Glue.UserDefinedFunctionTypes.ResourceUri> ResourceUris { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatabaseName { get; set; }
        /// <summary>
        /// ClassName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-userdefinedfunction.html#cfn-glue-userdefinedfunction-classname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClassName { get; set; }
    }

    namespace UserDefinedFunctionTypes
    {
        public class ResourceUri : Humidifier.Base.BaseSubResource, IHaveResourceType, IHaveUri
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-userdefinedfunction-resourceuri.html#cfn-glue-userdefinedfunction-resourceuri-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-userdefinedfunction-resourceuri.html#cfn-glue-userdefinedfunction-resourceuri-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uri { get; set; }
        }
    }
}