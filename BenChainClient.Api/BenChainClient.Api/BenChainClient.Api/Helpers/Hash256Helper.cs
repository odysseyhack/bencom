using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BenChainClient.Api.Helpers
{
  /// <summary>
  /// 
  /// </summary>
  public class Hash256Tool
  {

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string Md5HashString(string inputString)
    {
      var hash = new StringBuilder();
      var md5Provider = new MD5CryptoServiceProvider();
      var bytes = md5Provider.ComputeHash(new UTF8Encoding().GetBytes(inputString));
      foreach (var t in bytes)
      {
        hash.Append(t.ToString("x2"));
      }
      return hash.ToString();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputString"></param>
    /// <returns></returns>
    public static string Sha256HashString(string inputString)
    {
      using (var sha256 = SHA256Managed.Create())
      {
        var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputString));

        var builder = new StringBuilder();
        foreach (var t in bytes)
        {
          builder.Append(t.ToString("x2"));
        }
        return builder.ToString();
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="inputFilePath"></param>
    /// <returns></returns>
    public static string Sha256File(string inputFilePath)
    {
      using (var sha256 = SHA256Managed.Create())
      {
        using (var fileStream = File.OpenRead(inputFilePath))
          return Convert.ToBase64String(sha256.ComputeHash(fileStream));
      }
    }
  }
}