using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections;
using System.Collections.Generic;

namespace MedicalStatistician.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>()
        {
            new ApiScope("RepositoriesAPI", "Web API"),
        };

        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>()
        {
            new ApiResource("RepositoriesAPI"),
        };

        public static IEnumerable<Client> Clients => new List<Client>()
        {
            new Client
            {
                ClientId = "BlazorWebApp",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = { "RepositoriesAPI" }
            },
            new Client
            {
                ClientId = "swagger",
                ClientSecrets = { new Secret("swagger_secret".Sha256()) },
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                AllowedScopes =
                {
                    "RepositoriesAPI",
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                }
            }
        };

        public static IEnumerable<IdentityResource> IdentityResources => new List<IdentityResource>()
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
        };

        public static List<TestUser> TestUsers => new List<TestUser>()
        {
            new TestUser() {Password = "123", Username = "user"},
        };
    }
}
