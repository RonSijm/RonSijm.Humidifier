namespace Humidifier.ServiceCatalog
{
    using System.Collections.Generic;

    public class LaunchNotificationConstraint : Humidifier.Base.BaseResource, IHaveDescription, IHaveAcceptLanguage, IHaveProductId, IHavePortfolioId, IHaveNotificationArns
    {
        public override string AWSTypeName { get => AWS.ServiceCatalog.LaunchNotificationConstraint; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html#cfn-servicecatalog-launchnotificationconstraint-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// NotificationArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html#cfn-servicecatalog-launchnotificationconstraint-notificationarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic NotificationArns { get; set; }
        /// <summary>
        /// AcceptLanguage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html#cfn-servicecatalog-launchnotificationconstraint-acceptlanguage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AcceptLanguage { get; set; }

        /// <summary>
        /// PortfolioId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html#cfn-servicecatalog-launchnotificationconstraint-portfolioid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PortfolioId { get; set; }

        /// <summary>
        /// ProductId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicecatalog-launchnotificationconstraint.html#cfn-servicecatalog-launchnotificationconstraint-productid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ProductId { get; set; }
    }
}