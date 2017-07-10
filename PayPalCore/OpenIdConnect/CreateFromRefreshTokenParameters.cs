using System.Collections.Generic;

namespace PayPal.Api
{
    /// <summary>
    /// Parameters for getting an access token using a refresh token.
    /// </summary>
    public class CreateFromRefreshTokenParameters : ClientCredentials
    {
        /// <summary>
        /// Initializes a new <seealso cref="CreateFromRefreshTokenParameters"/> object and sets the grant type to 'refresh_token'.
        /// </summary>
        public CreateFromRefreshTokenParameters()
        {
            this.ContainerMap = new Dictionary<string, string>();
            this.SetGrantType("refresh_token");
        }

        /// <summary>
        /// Backing map
        /// </summary>
        public Dictionary<string, string> ContainerMap { get; set; }

        /// <summary>
        /// Set the scope
        /// </summary>
        /// <param name="scope"></param>
        public void SetScope(string scope)
        {
            ContainerMap["scope"] = scope;
        }

        /// <summary>
        /// Set the Grant Type
        /// </summary>
        /// <param name="grantType"></param>
        public void SetGrantType(string grantType)
        {
            ContainerMap["grant_type"] = grantType;
        }

        /// <summary>
        /// Set the Refresh Token
        /// </summary>
        /// <param name="refreshToken"></param>
        public void SetRefreshToken(string refreshToken)
        {
            ContainerMap["refresh_token"] =  refreshToken;
        }
    }
}
