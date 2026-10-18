namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;

    public class TelemetryEnrichment : Humidifier.Base.BaseResource, IHaveScope
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.TelemetryEnrichment; }

        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-telemetryenrichment.html#cfn-observabilityadmin-telemetryenrichment-scope
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Scope { get; set; }
    }
}