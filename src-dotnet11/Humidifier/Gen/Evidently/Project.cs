namespace Humidifier.Evidently
{
    using global::System.Collections.Generic;
    using ProjectTypes;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEvidentlyProjectTypesDataDeliveryObjectDataDelivery, IHaveDescription, IHaveEvidentlyProjectTypesAppConfigResourceObjectAppConfigResource, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Evidently.Project; }
        /// <summary>
        /// DataDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-project.html#cfn-evidently-project-datadelivery
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataDeliveryObject
        /// </summary>
        public Union<Humidifier.Evidently.ProjectTypes.DataDeliveryObject, BaseFunction>? DataDelivery { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-project.html#cfn-evidently-project-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AppConfigResource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-project.html#cfn-evidently-project-appconfigresource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AppConfigResourceObject
        /// </summary>
        public Union<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject, BaseFunction>? AppConfigResource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-project.html#cfn-evidently-project-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ProjectTypes
    {
        public class AppConfigResourceObject : Humidifier.Base.BaseSubResource, IHaveEnvironmentId, IHaveApplicationId
        {
            /// <summary>
            /// EnvironmentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-appconfigresourceobject.html#cfn-evidently-project-appconfigresourceobject-environmentid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnvironmentId { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-appconfigresourceobject.html#cfn-evidently-project-appconfigresourceobject-applicationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationId { get; set; }
        }

        public class DataDeliveryObject : Humidifier.Base.BaseSubResource, IHaveEvidentlyProjectTypesS3DestinationS3, IHaveLogGroup
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-datadeliveryobject.html#cfn-evidently-project-datadeliveryobject-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Destination
            /// </summary>
            public Union<Humidifier.Evidently.ProjectTypes.S3Destination, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-datadeliveryobject.html#cfn-evidently-project-datadeliveryobject-loggroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
        }

        public class S3Destination : Humidifier.Base.BaseSubResource, IHaveBucketName, IHavePrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-s3destination.html#cfn-evidently-project-s3destination-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-project-s3destination.html#cfn-evidently-project-s3destination-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
        }
    }
}