namespace Humidifier.Invoicing
{
    using global::System.Collections.Generic;
    using InvoiceUnitTypes;

    public class InvoiceUnit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveTaxInheritanceDisabled_Boolean, IHaveListOfInvoicingInvoiceUnitTypesResourceTagResourceTags, IHaveInvoicingInvoiceUnitTypesRuleRule, IHaveInvoiceReceiver, IHaveName
    {
        public class Attributes
        {
            public static string LastModified =  "LastModified" ;
            public static string InvoiceUnitArn =  "InvoiceUnitArn" ;
        }

        public override string AWSTypeName { get => AWS.Invoicing.InvoiceUnit; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-invoiceunit.html#cfn-invoicing-invoiceunit-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TaxInheritanceDisabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-invoiceunit.html#cfn-invoicing-invoiceunit-taxinheritancedisabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TaxInheritanceDisabled { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-invoiceunit.html#cfn-invoicing-invoiceunit-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.Invoicing.InvoiceUnitTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-invoiceunit.html#cfn-invoicing-invoiceunit-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Union<Humidifier.Invoicing.InvoiceUnitTypes.Rule, BaseFunction>? Rule { get; set; }

        /// <summary>
        /// InvoiceReceiver
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-invoiceunit.html#cfn-invoicing-invoiceunit-invoicereceiver
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InvoiceReceiver { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InvoiceUnitTypes
    {
        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-invoiceunit-resourcetag.html#cfn-invoicing-invoiceunit-resourcetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-invoiceunit-resourcetag.html#cfn-invoicing-invoiceunit-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveStringListOfLinkedAccounts
        {
            /// <summary>
            /// LinkedAccounts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-invoiceunit-rule.html#cfn-invoicing-invoiceunit-rule-linkedaccounts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LinkedAccounts { get; set; }
        }
    }
}