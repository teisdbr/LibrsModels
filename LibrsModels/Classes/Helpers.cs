namespace LibrsModels.Classes
{
    public static class Helpers
    {
        public static string PadL(this string property, int length, char paddingCharacter = ' ')
        {
            property = property ?? "";
            return property.PadLeft(length, paddingCharacter);
        }
        public static string PadR(this string property, int length, char paddingCharacter = ' ')
        {
            property = property ?? "";
            return property.PadRight(length, paddingCharacter);
        }
    }
}