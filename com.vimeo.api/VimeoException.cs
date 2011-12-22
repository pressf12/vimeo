using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.vimeo.api
{
    public sealed class VimeoException : Exception 
    {
        /*
        Error Codes

        1: User not found
        The user id or name was either not valid or not provided.
        96: Invalid signature
        The api_sig passed was not valid.
        97: Missing signature
        A signature was not passed.
        98: Login failed / Invalid auth token
        The login details or auth token passed were invalid.
        99: Insufficient permissions
        The user does not have permission to do that.
        100: Invalid API Key
        The API key passed was not valid.
        105: Service currently unavailable
        The requested service is temporarily unavailable.
        111: Format not found
        The requested response format was not found.
        112: Method not found
        The requested method was not found.
        301: Invalid consumer key
        The consumer key passed was not valid.
        302: Invalid / expired token
        The oauth_token passed was either not valid or has expired.
        303: Invalid signature
        The oauth_signature passed was not valid.
        304: Invalid nonce
        The oauth_nonce passed has already been used.
        305: Invalid signature
        The oauth_signature passed was not valid.
        306: Unsupported signature method
        We do not support that signature method.
        307: Missing required parameter
        A required parameter was missing.
        308: Duplicate parameter
        An OAuth protocol parameter was duplicated.
        999: Rate limit exceeded
        Please wait a few minutes before trying again.
        */
    }
}
