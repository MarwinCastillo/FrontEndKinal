using System;
using ApiKalumNotas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ApiKalumNotas.Utilities
{
    public class ErrorFilterException : ExceptionFilterAttribute
    {
        private ApiResponse response = null;
        //private readonly ILogger<ErrorFilterException> logger;
        public ErrorFilterException()
        {

        }
        public override void OnException(ExceptionContext context)
        {
            if(context.HttpContext.Response.StatusCode == 400){
                response = new ApiResponse() {TipoError = "Error de negocio", HttpStatusCode = "400", Mensaje = context.Exception.Message};
                context.HttpContext.Response.StatusCode = 400;
            }else{
                response = new ApiResponse() {TipoError = "Error de servicio", HttpStatusCode = "503", Mensaje = context.Exception.Message};
                context.HttpContext.Response.StatusCode = 503;
            }
            //logger.LogError(context.Exception.Message);
            context.Result = new JsonResult(response);
            base.OnException(context);
        }
    }
}