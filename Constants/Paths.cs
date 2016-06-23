using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public static class Paths
    {
        /// <summary>
        /// AuthorizationServer project should run on this URL
        /// </summary>
        public const string AuthorizationServerBaseAddress = "http://localhost:8001";

        /// <summary>
        /// ResourceServer project should run on this URL
        /// </summary>
        public const string ResourceServerBaseAddress = "http://localhost:8002";

        /// <summary>
        /// ImplicitGrant project should be running on this specific port '38515'
        /// </summary>
        public const string ImplicitGrantCallBackPath = "http://localhost:8003/Home/SignIn";

        /// <summary>
        /// AuthorizationCodeGrant project should be running on this URL.
        /// </summary>
        public const string AuthorizeCodeCallBackPath = "http://localhost:8004/";

        public const string AuthorizePath = "/OAuth/Authorize";
        public const string TokenPath = "/OAuth/Token";
        public const string LoginPath = "/Account/Login";
        public const string LogoutPath = "/Account/Logout";
        public const string MePath = "/api/Me";
    }
}