using System;
using Microsoft.AspNetCore.Mvc;

namespace BrekkeDanceCenter.Classes.Authentication {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthenticateAttribute : TypeFilterAttribute {
        public AuthenticateAttribute() : base(typeof(AuthenticationFilter)) {}
    }
}