namespace Humidifier.Events
{
    using global::System.Collections.Generic;

    public class EventBusPolicy : Humidifier.Base.BaseResource, IHaveEventBusName, IHaveStatementId, IHaveStatement_Json
    {
        public override string AWSTypeName { get => AWS.Events.EventBusPolicy; }
        /// <summary>
        /// EventBusName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-eventbusname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EventBusName { get; set; }

        /// <summary>
        /// StatementId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-statementid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StatementId { get; set; }
        /// <summary>
        /// Statement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-eventbuspolicy.html#cfn-events-eventbuspolicy-statement
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Statement { get; set; }
    }
}