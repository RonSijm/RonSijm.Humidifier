namespace Humidifier.LookoutVision
{
    using System.Collections.Generic;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::LookoutVision::Project";
            }
        }

        public dynamic ProjectName { get => GivenName; set => GivenName = value; }
    }
}