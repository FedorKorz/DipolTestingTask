using System.Text.RegularExpressions;

namespace DipolTestTask.Utils;

public static class Utils
{
    public static bool IsValidColorCode(string? colorCode)
    {
        return !string.IsNullOrEmpty(colorCode) && Regex.IsMatch(colorCode, "^#[0-9A-Fa-f]{6}$");
    }
}