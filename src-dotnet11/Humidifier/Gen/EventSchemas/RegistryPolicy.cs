namespace Humidifier.EventSchemas
{
    using global::System.Collections.Generic;

    public class RegistryPolicy : Humidifier.Base.BaseResource, IHavePolicy_Json, IHaveRegistryName, IHaveRevisionId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EventSchemas.RegistryPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-registrypolicy.html#cfn-eventschemas-registrypolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// RegistryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-registrypolicy.html#cfn-eventschemas-registrypolicy-registryname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RegistryName { get; set; }
        /// <summary>
        /// RevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventschemas-registrypolicy.html#cfn-eventschemas-registrypolicy-revisionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RevisionId { get; set; }
    }
}