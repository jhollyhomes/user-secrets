# user-secrets

## Demo on user secrets

This has been implemented in .Net core 2.0

https://docs.microsoft.com/en-us/aspnet/core/security/key-vault-configuration?tabs=aspnetcore2x

### Main points

(This does not seem to be a requirement in VS2017)

Edit Project File and add 

`<DotNetCliToolReference Include="Microsoft.Extensions.SecretManager.Tools" Version="2.0.0" />`

under 

`<DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />`

When a user secret is added an entry is put into the project file that specifies the guid file location in your windows user directory.

You can now right click on project and select manage user secrets.  These are either injected in authomatically if you inject the IConfiguration into the startup.cs or can be done manualy using the AddUserSecrets extension to the ConfigurationBuilder.
Once in the configration can be accessed as normal.
