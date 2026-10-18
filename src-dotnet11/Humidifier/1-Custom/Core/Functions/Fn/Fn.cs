using System.Collections.Generic;

namespace Humidifier;

public static class Fn
{
    public static FnLiteral Literal(object value) => new(value);
    public static FnBase64 Base64(object valueToEncode) => new FnBase64(valueToEncode);
    public static FnJoin Join(string seperator, params object[] parameters) => new(seperator, parameters);
    /// <summary>Joins a typed list, including a CloudFormation expression that resolves to a list.</summary>
    public static FnJoin JoinList(string separator,
        Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? values)
        => new(separator, (object)values);
    public static FnRef Ref(string reference) => new(reference);
    public static FnGetAtt GetAtt(string logicalNameOfResource, string attributeName) => new(logicalNameOfResource, attributeName);
    public static FnSub Sub(string input, Dictionary<string, object> variables = null) => new(input, variables);
    public static FnImportValue ImportValue(object sharedValueToImport) => new FnImportValue(sharedValueToImport);
    public static FnSplit Split(string delimiter, object sourceString) => new FnSplit(delimiter, sourceString);
    public static FnSelect Select(string index, object listOfObjects) => new FnSelect(index, listOfObjects);
    public static FnGetAZs GetAZs(object region) => new FnGetAZs(region);
    public static FnFindInMap FindInMap(string mapName, object topLevelKey, object secondLevelKey) => new FnFindInMap(mapName, topLevelKey, secondLevelKey);

    public static FnAnd And(params object[] conditions) => new(conditions);
    public static FnIf If(string conditionName, object valueIfTrue, object valueIfFalse) => new FnIf(conditionName, valueIfTrue, valueIfFalse);
    public new static FnEquals Equals(object value1, object value2) => new FnEquals(value1, value2);
    public static FnNot Not(object condition) => new FnNot(condition);
    public static FnOr Or(params object[] conditions) => new(conditions);
    public static FnCidr Cidr(object ipBlock, object count, object sizeMask) => new FnCidr(ipBlock, count, sizeMask);
}
