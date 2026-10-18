namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using DataTableTypes;

    public class DataTable : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveValueLockLevel, IHaveTimeZone, IHaveDescription, IHaveInstanceArn, IHaveName
    {
        public class Attributes
        {
            public static string LockVersion =  "LockVersion" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
        }

        public override string AWSTypeName { get => AWS.Connect.DataTable; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-status
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// ValueLockLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-valuelocklevel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ValueLockLevel { get; set; }

        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-timezone
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TimeZone { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-datatable.html#cfn-connect-datatable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataTableTypes
    {
        public class LockVersion : Humidifier.Base.BaseSubResource, IHaveDataTable
        {
            /// <summary>
            /// DataTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-datatable-lockversion.html#cfn-connect-datatable-lockversion-datatable
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTable { get; set; }
        }
    }
}