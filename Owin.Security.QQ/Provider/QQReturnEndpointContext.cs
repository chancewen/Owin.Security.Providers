﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;

namespace Owin.Security.QQ
{
    /// <summary>
    /// Provides context information to middleware providers.
    /// </summary>
    public class QQReturnEndpointContext : ReturnEndpointContext
    {
        /// <summary>
        /// Initializes a new <see cref="QQReturnEndpointContext"/>.
        /// </summary>
        /// <param name="context">OWIN environment</param>
        /// <param name="ticket">The authentication ticket</param>
        public QQReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}
