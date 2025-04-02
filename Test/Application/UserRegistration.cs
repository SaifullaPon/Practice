using System.Text.RegularExpressions;

namespace Application;

public static class UserRegistration
{
    public static PasswordStrength GetPasswordStrength(string password)
    {
        PasswordStrength passwordStrength = PasswordStrength.None;

        password = password.Trim();


        if (password.Length > 7)
            passwordStrength = StrenghtUp(passwordStrength);

        if (Regex.Match(password, "[a-z]").Success)
            passwordStrength = StrenghtUp(passwordStrength);

        if (Regex.Match(password, "[0-9]").Success)
            passwordStrength = StrenghtUp(passwordStrength);

        if (Regex.Match(password,
                  "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
            passwordStrength = StrenghtUp(passwordStrength);


        return passwordStrength;
    }

    public static PasswordStrength StrenghtUp(PasswordStrength passwordStrength)
    {
        return passwordStrength switch
        {
            PasswordStrength.None => PasswordStrength.Easy,
            PasswordStrength.Easy => PasswordStrength.Medium,
            PasswordStrength.Medium => PasswordStrength.Hard,
            PasswordStrength.Hard => PasswordStrength.Secure,
            _ => PasswordStrength.Secure,
        };
    }

    public enum PasswordStrength
    {
        None,
        Easy,
        Medium,
        Hard,
        Secure
    }
}
