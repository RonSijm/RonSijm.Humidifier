namespace Humidifier.MemoryDB
{
    using global::System.Collections.Generic;

    public class MultiRegionParameterGroup : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string MultiRegionParameterGroupName =  "MultiRegionParameterGroupName" ;
            public static string Description =  "Description" ;
            public static string Family =  "Family" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MemoryDB.MultiRegionParameterGroup; }
    }
}