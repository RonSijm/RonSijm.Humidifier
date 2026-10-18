namespace Humidifier.Glue
{
    using global::System.Collections.Generic;

    public class Blueprint : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveBlueprintLocation, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ParameterSpec =  "ParameterSpec" ;
            public static string LastModifiedOn =  "LastModifiedOn" ;
            public static string CreatedOn =  "CreatedOn" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Blueprint; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-blueprint.html#cfn-glue-blueprint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// BlueprintLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-blueprint.html#cfn-glue-blueprint-blueprintlocation
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BlueprintLocation { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-blueprint.html#cfn-glue-blueprint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}