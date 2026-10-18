namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerTrafficPolicyTypes;

    public class MailManagerTrafficPolicy : Humidifier.Base.BaseResource, IHaveTags, IHaveDefaultAction, IHaveListOfSESMailManagerTrafficPolicyTypesPolicyStatementPolicyStatements, IHaveTrafficPolicyName, IHaveMaxMessageSizeBytes_Double
    {
        public class Attributes
        {
            public static string TrafficPolicyId =  "TrafficPolicyId" ;
            public static string TrafficPolicyArn =  "TrafficPolicyArn" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerTrafficPolicy; }

        /// <summary>
        /// DefaultAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-defaultaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DefaultAction { get; set; }

        /// <summary>
        /// PolicyStatements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-policystatements
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PolicyStatement
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement>, IReadOnlyList<Union<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyStatement, BaseFunction>>, BaseFunction>? PolicyStatements { get; set; }
        /// <summary>
        /// TrafficPolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-trafficpolicyname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TrafficPolicyName { get; set; }
        /// <summary>
        /// MaxMessageSizeBytes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-maxmessagesizebytes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? MaxMessageSizeBytes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagertrafficpolicy.html#cfn-ses-mailmanagertrafficpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MailManagerTrafficPolicyTypes
    {
        public class IngressAnalysis : Humidifier.Base.BaseSubResource, IHaveAnalyzer, IHaveResultField
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressanalysis.html#cfn-ses-mailmanagertrafficpolicy-ingressanalysis-analyzer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Analyzer { get; set; }
            /// <summary>
            /// ResultField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressanalysis.html#cfn-ses-mailmanagertrafficpolicy-ingressanalysis-resultfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultField { get; set; }
        }

        public class IngressBooleanExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerTrafficPolicyTypesIngressBooleanToEvaluateEvaluate
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleanexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleanexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleanexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleanexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressBooleanToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressBooleanToEvaluate, BaseFunction>? Evaluate { get; set; }
        }

        public class IngressBooleanToEvaluate : Humidifier.Base.BaseSubResource, IHaveSESMailManagerTrafficPolicyTypesIngressIsInAddressListIsInAddressList, IHaveSESMailManagerTrafficPolicyTypesIngressAnalysisAnalysis
        {
            /// <summary>
            /// IsInAddressList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate-isinaddresslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressIsInAddressList
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressIsInAddressList, BaseFunction>? IsInAddressList { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressbooleantoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressAnalysis
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressAnalysis, BaseFunction>? Analysis { get; set; }
        }

        public class IngressIpToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressiptoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressiptoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class IngressIpv4Expression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerTrafficPolicyTypesIngressIpToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressIpToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressIpToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv4expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv4expression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class IngressIpv6Expression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerTrafficPolicyTypesIngressIpv6ToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv6expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv6expression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv6expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv6expression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressIpv6ToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressIpv6ToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv6expression.html#cfn-ses-mailmanagertrafficpolicy-ingressipv6expression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class IngressIpv6ToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressipv6toevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressipv6toevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class IngressIsInAddressList : Humidifier.Base.BaseSubResource, IHaveAttribute, IHaveStringListOfAddressLists
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressisinaddresslist.html#cfn-ses-mailmanagertrafficpolicy-ingressisinaddresslist-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// AddressLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressisinaddresslist.html#cfn-ses-mailmanagertrafficpolicy-ingressisinaddresslist-addresslists
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AddressLists { get; set; }
        }

        public class IngressStringExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerTrafficPolicyTypesIngressStringToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressStringToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressStringToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringexpression.html#cfn-ses-mailmanagertrafficpolicy-ingressstringexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class IngressStringToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute, IHaveSESMailManagerTrafficPolicyTypesIngressAnalysisAnalysis
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringtoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressstringtoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingressstringtoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingressstringtoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressAnalysis
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressAnalysis, BaseFunction>? Analysis { get; set; }
        }

        public class IngressTlsProtocolExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerTrafficPolicyTypesIngressTlsProtocolToEvaluateEvaluate, IHaveValue
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IngressTlsProtocolToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressTlsProtocolToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocolexpression-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class IngressTlsProtocolToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-ingresstlsprotocoltoevaluate.html#cfn-ses-mailmanagertrafficpolicy-ingresstlsprotocoltoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class PolicyCondition : Humidifier.Base.BaseSubResource, IHaveSESMailManagerTrafficPolicyTypesIngressIpv6ExpressionIpv6Expression, IHaveSESMailManagerTrafficPolicyTypesIngressBooleanExpressionBooleanExpression, IHaveSESMailManagerTrafficPolicyTypesIngressStringExpressionStringExpression, IHaveSESMailManagerTrafficPolicyTypesIngressTlsProtocolExpressionTlsExpression, IHaveSESMailManagerTrafficPolicyTypesIngressIpv4ExpressionIpExpression
        {
            /// <summary>
            /// Ipv6Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-ipv6expression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressIpv6Expression
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressIpv6Expression, BaseFunction>? Ipv6Expression { get; set; }
            /// <summary>
            /// BooleanExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-booleanexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressBooleanExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressBooleanExpression, BaseFunction>? BooleanExpression { get; set; }
            /// <summary>
            /// StringExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-stringexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressStringExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressStringExpression, BaseFunction>? StringExpression { get; set; }
            /// <summary>
            /// TlsExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-tlsexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressTlsProtocolExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressTlsProtocolExpression, BaseFunction>? TlsExpression { get; set; }
            /// <summary>
            /// IpExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policycondition.html#cfn-ses-mailmanagertrafficpolicy-policycondition-ipexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IngressIpv4Expression
            /// </summary>
            public Union<Humidifier.SES.MailManagerTrafficPolicyTypes.IngressIpv4Expression, BaseFunction>? IpExpression { get; set; }
        }

        public class PolicyStatement : Humidifier.Base.BaseSubResource, IHaveAction, IHaveListOfSESMailManagerTrafficPolicyTypesPolicyConditionConditions
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policystatement.html#cfn-ses-mailmanagertrafficpolicy-policystatement-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagertrafficpolicy-policystatement.html#cfn-ses-mailmanagertrafficpolicy-policystatement-conditions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PolicyCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyCondition>, IReadOnlyList<Union<Humidifier.SES.MailManagerTrafficPolicyTypes.PolicyCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }
    }
}