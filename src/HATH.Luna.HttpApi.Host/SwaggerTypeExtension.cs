using System;
using System.Linq;
using System.Text;

namespace HATH.Luna;

public static class SwaggerTypeExtension
{
    public static string FriendlyId(this Type type,bool fullyQualified=false)
    {
        var typeName = fullyQualified
            ? type.FullNameSansTypeParameters().Replace("+", ".")
            : type.Name;

        if (type.IsGenericType)
        {
            var genericArgumentIds = type.GetGenericArguments()
                .Select(t => t.FriendlyId(fullyQualified))
                .ToArray();

            return new StringBuilder(typeName)
                .Replace($"`{genericArgumentIds.Count()}", string.Empty)
                .Append($"[{string.Join(",", genericArgumentIds).TrimEnd(',')}]")
                .ToString();
        }

        return typeName;
    }

    public static string FullNameSansTypeParameters(this Type type)
    {
        var fullName = type.FullName;

        if (string.IsNullOrEmpty(fullName))
        {
            fullName = type.Name;
        }

        var chopIndex = fullName.IndexOf("[[");
        return (chopIndex == -1) ? fullName : fullName.Substring(0, chopIndex);
    }
}