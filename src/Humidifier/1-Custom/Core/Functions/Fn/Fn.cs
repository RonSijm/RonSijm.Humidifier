using System.Collections.Generic;

namespace Humidifier;

public static class Fn
{
    public static FnBase64 Base64(dynamic valueToEncode) => new FnBase64(valueToEncode);
    public static FnJoin Join(string seperator, params dynamic[] parameters) => new(seperator, parameters);
    public static FnRef Ref(string reference) => new(reference);
    public static FnGetAtt GetAtt(string logicalNameOfResource, string attributeName) => new(logicalNameOfResource, attributeName);
    public static FnSub Sub(string input, Dictionary<string, dynamic> variables = null) => new(input, variables);
    public static FnImportValue ImportValue(dynamic sharedValueToImport) => new FnImportValue(sharedValueToImport);
    public static FnSplit Split(string delimiter, dynamic sourceString) => new FnSplit(delimiter, sourceString);
    public static FnSelect Select(string index, dynamic listOfObjects) => new FnSelect(index, listOfObjects);
    public static FnGetAZs GetAZs(dynamic region) => new FnGetAZs(region);
    public static FnFindInMap FindInMap(string mapName, dynamic topLevelKey, dynamic secondLevelKey) => new FnFindInMap(mapName, topLevelKey, secondLevelKey);

    public static FnAnd And(params dynamic[] conditions) => new(conditions);
    public static FnIf If(string conditionName, dynamic valueIfTrue, dynamic valueIfFalse) => new FnIf(conditionName, valueIfTrue, valueIfFalse);
    public new static FnEquals Equals(dynamic value1, dynamic value2) => new FnEquals(value1, value2);
    public static FnNot Not(dynamic condition) => new FnNot(condition);
    public static FnOr Or(params dynamic[] conditions) => new(conditions);
    public static FnCidr Cidr(dynamic ipBlock, dynamic count, dynamic sizeMask) => new FnCidr(ipBlock, count, sizeMask);
}