using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenChainClient.Api.Helpers
{
  /// <summary>
  /// 
  /// </summary>
  public static class RegularExpressions
  {
    /// <summary>
    /// 
    /// </summary>
    public const string IsNumericValue = @"^\d+$|^\d*,\d+$";
    /// <summary>
    /// 
    /// </summary>
    public const string IsNormalCosts = "^[0-9]{0,3}([,.][0-9]{1,2})?$";
    /// <summary>
    /// 
    /// </summary>
    public const string IsDateTime = @"(^$)|(^\d{1,2}-\d{1,2}-\d{4} \d{2}:\d{2}(:\d{2}$)?)*";
    /// <summary>
    /// 
    /// </summary>
    public const string IsWholeNumber = "^[0-9]{1,3}$";
  }
}