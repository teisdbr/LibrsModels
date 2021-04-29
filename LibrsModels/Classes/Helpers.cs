using System;
using TeUtil.Extensions;

namespace LibrsModels.Classes
{
    public static class Helpers
    {
        public static string PadL(this string property, int length, char paddingCharacter = ' ', char defaultChar = ' ')
        {
            if (int.TryParse(property, out var numeric))
            {
                return numeric.ToString().PadLeft(length, paddingCharacter);
            }
            return property.IsNullBlankOrEmpty() ? property.PadLeft(length, defaultChar) : property.PadLeft(length, paddingCharacter);
        }
        public static string PadR(this string property, int length, char paddingCharacter = ' ')
        {
            property = property ?? "";
            return property.PadRight(length, paddingCharacter);
        }
    }
}