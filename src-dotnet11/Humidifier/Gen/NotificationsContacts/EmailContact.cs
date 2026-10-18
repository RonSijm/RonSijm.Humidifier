namespace Humidifier.NotificationsContacts
{
    using global::System.Collections.Generic;
    using EmailContactTypes;

    public class EmailContact : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEmailAddress, IHaveName
    {
        public class Attributes
        {
            public static string EmailContact =  "EmailContact" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.NotificationsContacts.EmailContact; }

        /// <summary>
        /// EmailAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notificationscontacts-emailcontact.html#cfn-notificationscontacts-emailcontact-emailaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EmailAddress { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-notificationscontacts-emailcontact.html#cfn-notificationscontacts-emailcontact-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EmailContactTypes
    {
        public class EmailContact : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveAddress, IHaveCreationTime, IHaveUpdateTime, IHaveArn, IHaveName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// CreationTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-creationtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationTime { get; set; }
            /// <summary>
            /// UpdateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-updatetime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTime { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-notificationscontacts-emailcontact-emailcontact.html#cfn-notificationscontacts-emailcontact-emailcontact-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}