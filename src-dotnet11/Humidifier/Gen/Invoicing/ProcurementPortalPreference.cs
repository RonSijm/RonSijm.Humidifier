namespace Humidifier.Invoicing
{
    using global::System.Collections.Generic;
    using ProcurementPortalPreferenceTypes;

    public class ProcurementPortalPreference : Humidifier.Base.BaseResource, IHaveTags, IHaveSupplierIdentifier, IHaveBuyerDomain, IHaveSupplierDomain, IHaveProcurementPortalSharedSecret, IHaveInvoicingProcurementPortalPreferenceTypesTestEnvPreferenceTestEnvPreference, IHavePurchaseOrderRetrievalEnabled_Boolean, IHaveListOfInvoicingProcurementPortalPreferenceTypesContactContacts, IHaveBuyerIdentifier, IHaveEinvoiceDeliveryEnabled_Boolean, IHaveInvoicingProcurementPortalPreferenceTypesEinvoiceDeliveryPreferenceEinvoiceDeliveryPreference, IHaveProcurementPortalInstanceEndpoint, IHaveProcurementPortalName, IHaveInvoicingProcurementPortalPreferenceTypesProcurementPortalPreferenceSelectorSelector
    {
        public class Attributes
        {
            public static string ProcurementPortalPreferenceArn =  "ProcurementPortalPreferenceArn" ;
            public static string PurchaseOrderRetrievalPreferenceStatus =  "PurchaseOrderRetrievalPreferenceStatus" ;
            public static string EinvoiceDeliveryPreferenceStatus =  "EinvoiceDeliveryPreferenceStatus" ;
            public static string Version =  "Version" ;
            public static string AwsAccountId =  "AwsAccountId" ;
            public static string PurchaseOrderRetrievalEndpoint =  "PurchaseOrderRetrievalEndpoint" ;
            public static string CreateDate =  "CreateDate" ;
            public static string LastUpdateDate =  "LastUpdateDate" ;
        }

        public override string AWSTypeName { get => AWS.Invoicing.ProcurementPortalPreference; }

        /// <summary>
        /// SupplierIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-supplieridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SupplierIdentifier { get; set; }

        /// <summary>
        /// BuyerDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-buyerdomain
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BuyerDomain { get; set; }

        /// <summary>
        /// SupplierDomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-supplierdomain
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SupplierDomain { get; set; }
        /// <summary>
        /// ProcurementPortalSharedSecret
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-procurementportalsharedsecret
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProcurementPortalSharedSecret { get; set; }
        /// <summary>
        /// TestEnvPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TestEnvPreference
        /// </summary>
        public Union<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference, BaseFunction>? TestEnvPreference { get; set; }

        /// <summary>
        /// PurchaseOrderRetrievalEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-purchaseorderretrievalenabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? PurchaseOrderRetrievalEnabled { get; set; }

        /// <summary>
        /// Contacts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-contacts
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Contact
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact>, IReadOnlyList<Union<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.Contact, BaseFunction>>, BaseFunction>? Contacts { get; set; }

        /// <summary>
        /// BuyerIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-buyeridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BuyerIdentifier { get; set; }

        /// <summary>
        /// EinvoiceDeliveryEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliveryenabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? EinvoiceDeliveryEnabled { get; set; }
        /// <summary>
        /// EinvoiceDeliveryPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EinvoiceDeliveryPreference
        /// </summary>
        public Union<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.EinvoiceDeliveryPreference, BaseFunction>? EinvoiceDeliveryPreference { get; set; }
        /// <summary>
        /// ProcurementPortalInstanceEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-procurementportalinstanceendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProcurementPortalInstanceEndpoint { get; set; }

        /// <summary>
        /// ProcurementPortalName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-procurementportalname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ProcurementPortalName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Selector
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-invoicing-procurementportalpreference.html#cfn-invoicing-procurementportalpreference-selector
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProcurementPortalPreferenceSelector
        /// </summary>
        public Union<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.ProcurementPortalPreferenceSelector, BaseFunction>? Selector { get; set; }
    }

    namespace ProcurementPortalPreferenceTypes
    {
        public class Contact : Humidifier.Base.BaseSubResource, IHaveEmail, IHaveName
        {
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-contact.html#cfn-invoicing-procurementportalpreference-contact-email
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Email { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-contact.html#cfn-invoicing-procurementportalpreference-contact-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class EinvoiceDeliveryPreference : Humidifier.Base.BaseSubResource, IHaveConnectionTestingMethod, IHaveEinvoiceDeliveryActivationDate, IHaveStringListOfEinvoiceDeliveryDocumentTypes, IHaveProtocol, IHaveListOfInvoicingProcurementPortalPreferenceTypesPurchaseOrderDataSourcePurchaseOrderDataSources, IHaveStringListOfEinvoiceDeliveryAttachmentTypes
        {
            /// <summary>
            /// ConnectionTestingMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-connectiontestingmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionTestingMethod { get; set; }
            /// <summary>
            /// EinvoiceDeliveryActivationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-einvoicedeliveryactivationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EinvoiceDeliveryActivationDate { get; set; }
            /// <summary>
            /// EinvoiceDeliveryDocumentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-einvoicedeliverydocumenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EinvoiceDeliveryDocumentTypes { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// PurchaseOrderDataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-purchaseorderdatasources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PurchaseOrderDataSource
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.PurchaseOrderDataSource>, IReadOnlyList<Union<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.PurchaseOrderDataSource, BaseFunction>>, BaseFunction>? PurchaseOrderDataSources { get; set; }
            /// <summary>
            /// EinvoiceDeliveryAttachmentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-einvoicedeliverypreference.html#cfn-invoicing-procurementportalpreference-einvoicedeliverypreference-einvoicedeliveryattachmenttypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EinvoiceDeliveryAttachmentTypes { get; set; }
        }

        public class ProcurementPortalPreferenceSelector : Humidifier.Base.BaseSubResource, IHaveStringListOfInvoiceUnitArns
        {
            /// <summary>
            /// InvoiceUnitArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-procurementportalpreferenceselector.html#cfn-invoicing-procurementportalpreference-procurementportalpreferenceselector-invoiceunitarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InvoiceUnitArns { get; set; }
        }

        public class PurchaseOrderDataSource : Humidifier.Base.BaseSubResource, IHaveEinvoiceDeliveryDocumentType, IHavePurchaseOrderDataSourceType
        {
            /// <summary>
            /// EinvoiceDeliveryDocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-purchaseorderdatasource.html#cfn-invoicing-procurementportalpreference-purchaseorderdatasource-einvoicedeliverydocumenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EinvoiceDeliveryDocumentType { get; set; }
            /// <summary>
            /// PurchaseOrderDataSourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-purchaseorderdatasource.html#cfn-invoicing-procurementportalpreference-purchaseorderdatasource-purchaseorderdatasourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PurchaseOrderDataSourceType { get; set; }
        }

        public class TestEnvPreference : Humidifier.Base.BaseSubResource, IHaveSupplierIdentifier, IHaveBuyerDomain, IHaveSupplierDomain, IHaveBuyerIdentifier, IHaveProcurementPortalInstanceEndpoint, IHaveProcurementPortalSharedSecret
        {
            /// <summary>
            /// SupplierIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-supplieridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupplierIdentifier { get; set; }
            /// <summary>
            /// BuyerDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-buyerdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuyerDomain { get; set; }
            /// <summary>
            /// SupplierDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-supplierdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupplierDomain { get; set; }
            /// <summary>
            /// BuyerIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-buyeridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuyerIdentifier { get; set; }
            /// <summary>
            /// ProcurementPortalInstanceEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-procurementportalinstanceendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcurementPortalInstanceEndpoint { get; set; }
            /// <summary>
            /// ProcurementPortalSharedSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-invoicing-procurementportalpreference-testenvpreference.html#cfn-invoicing-procurementportalpreference-testenvpreference-procurementportalsharedsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProcurementPortalSharedSecret { get; set; }
        }
    }
}