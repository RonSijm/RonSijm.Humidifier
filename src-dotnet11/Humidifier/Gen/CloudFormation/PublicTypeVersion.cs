namespace Humidifier.CloudFormation
{
    using global::System.Collections.Generic;

    public class PublicTypeVersion : Humidifier.Base.BaseResource, IHaveTypeName, IHaveLogDeliveryBucket, IHaveType, IHavePublicVersionNumber, IHaveArn
    {
        public class Attributes
        {
            public static string PublicTypeArn =  "PublicTypeArn" ;
            public static string PublisherId =  "PublisherId" ;
            public static string TypeVersionArn =  "TypeVersionArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudFormation.PublicTypeVersion; }
        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html#cfn-cloudformation-publictypeversion-typename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TypeName { get; set; }
        /// <summary>
        /// LogDeliveryBucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html#cfn-cloudformation-publictypeversion-logdeliverybucket
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogDeliveryBucket { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html#cfn-cloudformation-publictypeversion-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// PublicVersionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html#cfn-cloudformation-publictypeversion-publicversionnumber
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PublicVersionNumber { get; set; }
        /// <summary>
        /// Arn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-publictypeversion.html#cfn-cloudformation-publictypeversion-arn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Arn { get; set; }
    }
}