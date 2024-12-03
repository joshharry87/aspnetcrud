using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace NewApp.Controllers;

public class HelloWorldController: Controller
{

    public string Index()
    {
        return "default";
    }

    public string Welcome()
    {
        return "This is another one.";

    }


}