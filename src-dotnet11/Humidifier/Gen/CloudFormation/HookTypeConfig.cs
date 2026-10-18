namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;

    public class HookTypeConfig : Humidifier.Base.BaseResource, IHaveTypeName, IHaveConfiguration, IHaveTypeArn, IHaveConfigurationAlias
    {
        public class Attributes
        {
            public static string ConfigurationArn =  "ConfigurationArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.HookTypeConfig; }
        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hooktypeconfig.html#cfn-cloudformation-hooktypeconfig-typename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TypeName { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hooktypeconfig.html#cfn-cloudformation-hooktypeconfig-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// TypeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hooktypeconfig.html#cfn-cloudformation-hooktypeconfig-typearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TypeArn { get; set; }
        /// <summary>
        /// ConfigurationAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-hooktypeconfig.html#cfn-cloudformation-hooktypeconfig-configurationalias
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfigurationAlias { get; set; }
    }
}