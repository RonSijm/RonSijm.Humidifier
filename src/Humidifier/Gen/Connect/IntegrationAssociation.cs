namespace Humidifier.Connect
{
    using System.Collections.Generic;

    public class IntegrationAssociation : Humidifier.Base.BaseResource, IHaveInstanceId, IHaveIntegrationType
    {
        public class Attributes
        {
            public static string IntegrationAssociationId =  "IntegrationAssociationId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.IntegrationAssociation; }

        /// <summary>
        /// IntegrationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-integrationassociation.html#cfn-connect-integrationassociation-integrationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IntegrationArn { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-integrationassociation.html#cfn-connect-integrationassociation-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }

        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-integrationassociation.html#cfn-connect-integrationassociation-integrationtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IntegrationType { get; set; }
    }
}