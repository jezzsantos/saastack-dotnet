using System.IdentityModel.Tokens.Jwt;
using Application.Resources.Shared;
using Common.Configuration;
using Domain.Interfaces.Authorization;
using Domain.Services.Shared;
using FluentAssertions;
using IdentityInfrastructure.ApplicationServices;
using Infrastructure.Common.Extensions;
using Infrastructure.Interfaces;
using Moq;
using UnitTesting.Common.Validation;
using Xunit;

namespace IdentityInfrastructure.UnitTests.ApplicationServices;

[Trait("Category", "Unit")]
public class JWTTokensServiceSpec
{
    private readonly JWTTokensService _service;
    private readonly Mock<ITokensService> _tokensService;

    public JWTTokensServiceSpec()
    {
        var settings = new Mock<IConfigurationSettings>();
        settings.Setup(s => s.Platform.GetString(JWTTokensService.BaseUrlSettingName, null))
            .Returns("https://localhost");
        settings.Setup(s => s.Platform.GetString(JWTTokensService.SigningSecretSettingName, null))
            .Returns("asecretsigningkeyasecretsigningkeyasecretsigningkeyasecretsigningkey");
        settings.Setup(s => s.Platform.GetNumber(It.IsAny<string>(), It.IsAny<double>()))
            .Returns((string _, double defaultValue) => defaultValue);
        _tokensService = new Mock<ITokensService>();
        _tokensService.Setup(ts => ts.CreateJWTRefreshToken())
            .Returns("arefreshtoken");

        _service = new JWTTokensService(settings.Object, _tokensService.Object);
    }

    [Fact]
    public void WhenGenerateSigningKey_ThenReturnsKey()
    {
#if TESTINGONLY
        var result = JWTTokensService.GenerateSigningKey();

        result.Should().NotBeNullOrEmpty();
#endif
    }

    [Fact]
    public async Task WhenIssueTokensAsync_ThenReturnsTokens()
    {
        var user = new EndUserWithMemberships
        {
            Access = EndUserAccess.Enabled,
            Status = EndUserStatus.Unregistered,
            Id = "anid",
            Roles = [PlatformRoles.Standard.Name],
            Features = [PlatformFeatures.Basic.Name],
            Memberships =
            [
                new Membership
                {
                    Id = "amembershipid",
                    UserId = "auserid",
                    OrganizationId = "anorganizationid",
                    Roles = [TenantRoles.Member.Name],
                    Features = [TenantFeatures.Basic.Name]
                }
            ]
        };

        var result = await _service.IssueTokensAsync(user);

        result.Value.AccessToken.Should().NotBeEmpty();
        result.Value.RefreshToken.Should().Be("arefreshtoken");
        result.Value.AccessTokenExpiresOn.Should()
            .BeNear(DateTime.UtcNow.Add(AuthenticationConstants.Tokens.DefaultAccessTokenExpiry));

        var token = new JwtSecurityTokenHandler().ReadJwtToken(result.Value.AccessToken);

        token.Issuer.Should().Be("https://localhost");
        token.Audiences.Should().OnlyContain(aud => aud == "https://localhost");
        token.ValidTo.Should().BeNear(DateTime.UtcNow.Add(AuthenticationConstants.Tokens.DefaultAccessTokenExpiry),
            TimeSpan.FromMinutes(1));
        token.Claims.Count().Should().Be(8);
        token.Claims.Should()
            .Contain(claim => claim.Type == AuthenticationConstants.Claims.ForId && claim.Value == "anid");
        token.Claims.Should()
            .Contain(
                claim => claim.Type == AuthenticationConstants.Claims.ForRole
                         && claim.Value == $"Platform_{PlatformRoles.Standard.Name}");
        token.Claims.Should()
            .Contain(claim => claim.Type == AuthenticationConstants.Claims.ForRole
                              && claim.Value
                              == $"Tenant_{TenantRoles.Member.Name}{ClaimExtensions.TenantIdDelimiter}anorganizationid");
        token.Claims.Should()
            .Contain(claim => claim.Type == AuthenticationConstants.Claims.ForFeature
                              && claim.Value == $"Platform_{PlatformFeatures.Basic.Name}");
        token.Claims.Should()
            .Contain(claim => claim.Type == AuthenticationConstants.Claims.ForFeature
                              && claim.Value
                              == $"Tenant_{TenantFeatures.Basic.Name}{ClaimExtensions.TenantIdDelimiter}anorganizationid");
        _tokensService.Verify(ts => ts.CreateJWTRefreshToken());
    }
}