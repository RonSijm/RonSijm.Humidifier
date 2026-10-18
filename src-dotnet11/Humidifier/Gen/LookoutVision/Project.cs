namespace Humidifier.LookoutVision
{
    using global::System.Collections.Generic;

    public class Project : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveProjectName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.LookoutVision.Project; }
        public Union<string, BaseFunction>? ProjectName { get => GivenName; set => GivenName = value; }
    }
}