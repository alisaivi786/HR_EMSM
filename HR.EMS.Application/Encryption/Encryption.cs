
namespace HR.EMS.Application.Encryption;

#region Encryption
/// <summary>
/// Provides methods for generating and verifying password hashes and salts.
/// </summary>
public static class Encryption
{
    #region GenerateSalt
    /// <summary>
    /// Generates a random salt.
    /// </summary>
    /// <returns>The generated salt.</returns>
    public static byte[] GenerateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[16]; // You can adjust the size of the salt
        rng.GetBytes(salt);
        return salt;
    }
    #endregion

    #region GeneratePasswordHash
    /// <summary>
    /// Generates a password hash using the provided password and salt.
    /// </summary>
    /// <param name="password">The password to hash.</param>
    /// <param name="salt">The salt to use for hashing.</param>
    /// <returns>The generated password hash.</returns>
    public static string GeneratePasswordHash(string password, byte[] salt)
    {
        using SHA256 sha256 = SHA256.Create();
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] combinedBytes = new byte[passwordBytes.Length + salt.Length];

        Buffer.BlockCopy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
        Buffer.BlockCopy(salt, 0, combinedBytes, passwordBytes.Length, salt.Length);

        byte[] hashBytes = sha256.ComputeHash(combinedBytes);
        return Convert.ToBase64String(hashBytes);
    }
    #endregion

    #region GeneratePasswordHash
    /// <summary>
    /// Generates a password hash using the provided password and optional salt.
    /// </summary>
    /// <param name="password">The password to hash.</param>
    /// <param name="salt">The optional salt to use for hashing.</param>
    /// <returns>The generated password hash.</returns>
    public static string GeneratePasswordHash(string? password, string salt = "EMS_HR_TEST")
    {
        if (password == null)
        {
            throw new ArgumentNullException(nameof(password), "Password cannot be null");
        }

        using SHA256 sha256 = SHA256.Create();
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
        byte[] combinedBytes = new byte[passwordBytes.Length + salt.Length];

        Buffer.BlockCopy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
        Buffer.BlockCopy(saltBytes, 0, combinedBytes, passwordBytes.Length, salt.Length);

        byte[] hashBytes = sha256.ComputeHash(combinedBytes);
        return Convert.ToBase64String(hashBytes);
    }
    #endregion

    #region VerifyPasswordHash
    /// <summary>
    /// Verifies a password hash against the provided password and stored hash.
    /// </summary>
    /// <param name="password">The password to verify.</param>
    /// <param name="hashPassword">The stored password hash.</param>
    /// <param name="storedSalt">The stored salt to use for hashing.</param>
    /// <returns>True if the password is valid, otherwise false.</returns>
    public static bool VerifyPasswordHash(string? password, string? hashPassword, string storedSalt = "EMS_HR_TEST")
    {
        try
        {
            if (password == null || hashPassword == null)
            {
                return false;
            }

            // Generate the password hash using the provided password and stored salt
            var generatedPasswordHash = Encryption.GeneratePasswordHash(password, storedSalt);

            // Compare the generated password hash with the stored hash
            return generatedPasswordHash == hashPassword;
        }
        catch (Exception)
        {
            // Handle the exception, log it, or return false depending on your requirements
            return false;
        }
    }
    #endregion
}
#endregion

