using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
namespace BrekkeDanceCenter.Classes.Authentication {
    public class AuthenticationFilter : IAuthorizationFilter {
        public void OnAuthorization(AuthorizationFilterContext context) {
            var httpContext = context.HttpContext;
            var request = httpContext.Request;
            var headers = request.Headers;
            var authorizationHeader = headers["Authorization"];
            var expectedUsername = Environment.GetEnvironmentVariable("SVC_USERNAME");
            var expectedPassword = Environment.GetEnvironmentVariable("SVC_PASSWORD");

            AuthenticationHeaderValue headerValue = null;
            AuthenticationHeaderValue.TryParse(authorizationHeader, out headerValue);

            var scheme = headerValue?.Scheme?.ToLower();
            var parameterBytes = Convert.FromBase64String(headerValue?.Parameter ?? "");
            var parameter = Encoding.UTF8.GetString(parameterBytes);

            var usernameLength = Math.Max(parameter.IndexOf(":"), 0);
            var username = parameter.Substring(0, usernameLength);
            var password = usernameLength > 0 ? parameter.Substring(usernameLength + 1) : "";

            if(username != expectedUsername || password != expectedPassword) {
                ReturnUnauthorized(context);
            }
        }

        public void ReturnUnauthorized(AuthorizationFilterContext context) {
            context.HttpContext.Response.Headers["WWW-Authenticate"] = @"Basic realm=""BDC""";
            context.Result = new UnauthorizedResult();
        }
    }
}