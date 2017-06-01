using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Summary description for posthandler
/// </summary>
public class posthandler : IHttpHandler
{

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    public void ProcessRequest(HttpContext context)
    {
        string patternNotNull = @".+";
        string nameValue = string.Empty;
        if (Regex.IsMatch(context.Request.Form["name"], patternNotNull, RegexOptions.IgnoreCase))
        {
            nameValue = context.Request.Form["name"];
        }
        string emailValue = string.Empty;
        string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
        if ((!string.IsNullOrEmpty(context.Request.Form["email"])) && (Regex.IsMatch(context.Request.Form["email"], pattern, RegexOptions.IgnoreCase)))
        {
            emailValue = context.Request.Form["email"];
        }
        string telValue = string.Empty;
        string patterntel = @"[0-9]{10}";
        if ((!string.IsNullOrEmpty(context.Request.Form["tel"])) && (Regex.IsMatch(context.Request.Form["tel"], patterntel, RegexOptions.IgnoreCase)))
        {
            telValue = context.Request.Form["tel"];
        }
        string titleValue = string.Empty;
        if (Regex.IsMatch(context.Request.Form["title_recept"], patternNotNull, RegexOptions.IgnoreCase))
        {
            titleValue = context.Request.Form["title_recept"];
        }
        string messageValue = string.Empty;
        if (Regex.IsMatch(context.Request.Form["message"], patternNotNull, RegexOptions.IgnoreCase))
        {
            messageValue = context.Request.Form["message"];
        }
        return;
    }
}