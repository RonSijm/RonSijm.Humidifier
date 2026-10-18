namespace Humidifier.Connect
{
    using global::System.Collections.Generic;

    public class UseCase : Humidifier.Base.BaseResource, IHaveTags, IHaveInstanceId, IHaveIntegrationAssociationId, IHaveUseCaseType
    {
        public class Attributes
        {
            public static string UseCaseArn =  "UseCaseArn" ;
            public static string UseCaseId =  "UseCaseId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.UseCase; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-usecase.html#cfn-connect-usecase-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }

        /// <summary>
        /// IntegrationAssociationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-usecase.html#cfn-connect-usecase-integrationassociationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IntegrationAssociationId { get; set; }

        /// <summary>
        /// UseCaseType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-usecase.html#cfn-connect-usecase-usecasetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UseCaseType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-usecase.html#cfn-connect-usecase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}