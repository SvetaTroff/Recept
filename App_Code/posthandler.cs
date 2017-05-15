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
        //throw new NotImplementedException();
        string nameValue = string.Empty;
        if (!string.IsNullOrEmpty(context.Request.Form["name"]))
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
        if (!string.IsNullOrEmpty(context.Request.Form["title_recept"]))
        {
            titleValue = context.Request.Form["title_recept"];
        }
        string messageValue = string.Empty;
        if (!string.IsNullOrEmpty(context.Request.Form["message"]))
        {
            messageValue = context.Request.Form["message"];
        }

        string message = "Рецепт успешно отправлен!";
        string error = "Ошибка! Не верны формат, поправте данные и попробуйте снова.";

        if ((nameValue != "") && (emailValue != "") && (telValue != "") && (titleValue != "") && (messageValue != ""))
        {
            //HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert("+ message + ")</SCRIPT>");
        }
        else
        {
            //HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert(" + error + ")</SCRIPT>");
        }
        //respo
    }
}