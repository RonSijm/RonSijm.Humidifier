namespace Humidifier.IoT
{
    using global::System.Collections.Generic;

    public class CertificateProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLambdaFunctionArn, IHaveCertificateProviderName, IHaveStringListOfAccountDefaultForOperations
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.CertificateProvider; }

        /// <summary>
        /// LambdaFunctionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificateprovider.html#cfn-iot-certificateprovider-lambdafunctionarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LambdaFunctionArn { get; set; }
        public Union<string, BaseFunction>? CertificateProviderName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// AccountDefaultForOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificateprovider.html#cfn-iot-certificateprovider-accountdefaultforoperations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountDefaultForOperations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificateprovider.html#cfn-iot-certificateprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}