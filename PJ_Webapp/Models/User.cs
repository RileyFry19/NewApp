using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace PJ_Webapp.Models;

public class User
{
    [Key]
    public Guid userID { get; set; }
    public string username { get; set; }
    public byte[] hashedPassword { get; set; }
    public byte[] salt { get; set; }
    public bool isAdmin { get; set; }

    public bool resetPassword { get; set; }
    public List<Soldier> soldiers { get; set; } = new List<Soldier>();

    public User()
    {
        
    }

    public User(string username, string passwordEntered)
    {
        this.username = username;

        salt = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        hashedPassword = HashPassword(passwordEntered);
        soldiers = new List<Soldier>();
    }

    private byte[] HashPassword(string plainTextPassword)
    {
        return KeyDerivation.Pbkdf2(
            password: plainTextPassword,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA512,
            iterationCount: 10000,
            numBytesRequested: 256 / 8);
    }

    public bool IsCorrectPassword(string plainTextPassword)
    {
        byte[] hashedEnteredPassword = HashPassword(plainTextPassword);
        return hashedEnteredPassword.SequenceEqual(hashedPassword);
    }

    public void SetNewPassword(string plainTextPassword)
    {
        hashedPassword = HashPassword(plainTextPassword);
    }
}