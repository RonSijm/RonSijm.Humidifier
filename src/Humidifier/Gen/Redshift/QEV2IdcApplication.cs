namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class QEV2IdcApplication : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string IdcOnboardStatus =  "IdcOnboardStatus" ;
            public static string IdcManagedApplicationArn =  "IdcManagedApplicationArn" ;
            public static string Qev2IdcApplicationArn =  "Qev2IdcApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.QEV2IdcApplication; }

        /// <summary>
        /// IdcDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-qev2idcapplication.html#cfn-redshift-qev2idcapplication-idcdisplayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdcDisplayName { get; set; }

        /// <summary>
        /// Qev2IdcApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-qev2idcapplication.html#cfn-redshift-qev2idcapplication-qev2idcapplicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Qev2IdcApplicationName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-qev2idcapplication.html#cfn-redshift-qev2idcapplication-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// IdcInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-qev2idcapplication.html#cfn-redshift-qev2idcapplication-idcinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IdcInstanceArn { get; set; }
    }
}