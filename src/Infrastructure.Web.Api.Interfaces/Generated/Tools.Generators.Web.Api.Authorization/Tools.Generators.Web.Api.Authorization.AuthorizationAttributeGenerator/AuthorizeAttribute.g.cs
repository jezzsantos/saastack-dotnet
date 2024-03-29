﻿// <auto-generated/>
using Domain.Interfaces.Authorization;

namespace Infrastructure.Web.Api.Interfaces;

/// <summary>
///     Provides scopes for both Platform and Tenant
/// </summary>
public enum RoleAndFeatureScope
{
    Platform = 0,
    Tenant = 1
}

/// <summary>
///     Provides all roles for both Platform and Tenant
/// </summary>
[Flags]
public enum Roles
{
    Platform_ExternalWebhookService = 1 << 0,
    Platform_Operations = 1 << 1,
    Platform_ServiceAccount = 1 << 2,
    Platform_Standard = 1 << 3,
    Platform_TestingOnly = 1 << 4,
    Platform_TestingOnlySuperUser = 1 << 5,
    Tenant_BillingAdmin = 1 << 6,
    Tenant_Member = 1 << 7,
    Tenant_Owner = 1 << 8,
    Tenant_TestingOnly = 1 << 9
}

/// <summary>
///     Provides all features for both Platform and Tenant
/// </summary>
[Flags]
public enum Features
{
    Platform_Basic = 1 << 0,
    Platform_Paid2 = 1 << 1,
    Platform_Paid3 = 1 << 2,
    Platform_PaidTrial = 1 << 3,
    Platform_TestingOnly = 1 << 4,
    Platform_TestingOnlySuperUser = 1 << 5,
    Tenant_Basic = 1 << 6,
    Tenant_Paid2 = 1 << 7,
    Tenant_Paid3 = 1 << 8,
    Tenant_PaidTrial = 1 << 9,
    Tenant_TestingOnly = 1 << 10
}

/// <summary>
///     Provides conversions for both Platform and Tenant
/// </summary>
internal static class AuthorizationAttributeExtensions
{
    /// <summary>
    ///     Converts the <see cref="name" /> in the specified <see cref="scope" /> to the appropriate
    ///     <see cref="FeatureLevel" />
    /// </summary>
    public static FeatureLevel ToFeatureByName(this string name, RoleAndFeatureScope scope)
    {
        if (scope == RoleAndFeatureScope.Platform)
        {
            if (name == PlatformFeatures.Basic.Name)
            {
                return PlatformFeatures.Basic;
            }
            if (name == PlatformFeatures.Paid2.Name)
            {
                return PlatformFeatures.Paid2;
            }
            if (name == PlatformFeatures.Paid3.Name)
            {
                return PlatformFeatures.Paid3;
            }
            if (name == PlatformFeatures.PaidTrial.Name)
            {
                return PlatformFeatures.PaidTrial;
            }
            if (name == PlatformFeatures.TestingOnly.Name)
            {
                return PlatformFeatures.TestingOnly;
            }
            if (name == PlatformFeatures.TestingOnlySuperUser.Name)
            {
                return PlatformFeatures.TestingOnlySuperUser;
            }

            throw new ArgumentOutOfRangeException(nameof(name), name, null);
        }

        if (scope == RoleAndFeatureScope.Tenant)
        {
            if (name == TenantFeatures.Basic.Name)
            {
                return TenantFeatures.Basic;
            }
            if (name == TenantFeatures.Paid2.Name)
            {
                return TenantFeatures.Paid2;
            }
            if (name == TenantFeatures.Paid3.Name)
            {
                return TenantFeatures.Paid3;
            }
            if (name == TenantFeatures.PaidTrial.Name)
            {
                return TenantFeatures.PaidTrial;
            }
            if (name == TenantFeatures.TestingOnly.Name)
            {
                return TenantFeatures.TestingOnly;
            }

            throw new ArgumentOutOfRangeException(nameof(name), name, null);
        }

        throw new ArgumentOutOfRangeException(nameof(name), name, null);
    }

    /// <summary>
    ///     Converts an individual <see cref="feature" /> flag to its respective <see cref="FeatureLevel" />
    /// </summary>
    public static FeatureLevel ToFeatureLevel(this Features feature)
    {
        return feature switch
        {
            Features.Platform_Basic => PlatformFeatures.Basic,
            Features.Platform_Paid2 => PlatformFeatures.Paid2,
            Features.Platform_Paid3 => PlatformFeatures.Paid3,
            Features.Platform_PaidTrial => PlatformFeatures.PaidTrial,
            Features.Platform_TestingOnly => PlatformFeatures.TestingOnly,
            Features.Platform_TestingOnlySuperUser => PlatformFeatures.TestingOnlySuperUser,
            Features.Tenant_Basic => TenantFeatures.Basic,
            Features.Tenant_Paid2 => TenantFeatures.Paid2,
            Features.Tenant_Paid3 => TenantFeatures.Paid3,
            Features.Tenant_PaidTrial => TenantFeatures.PaidTrial,
            Features.Tenant_TestingOnly => TenantFeatures.TestingOnly,
            _ => throw new ArgumentOutOfRangeException(nameof(feature), feature, null)
        };
    }

    /// <summary>
    ///     Converts the <see cref="name" /> in the specified <see cref="scope" /> to the appropriate <see cref="RoleLevel" />
    /// </summary>
    public static RoleLevel ToRoleByName(this string name, RoleAndFeatureScope scope)
    {
        if (scope == RoleAndFeatureScope.Platform)
        {
            if (name == PlatformRoles.ExternalWebhookService.Name)
            {
                return PlatformRoles.ExternalWebhookService;
            }
            if (name == PlatformRoles.Operations.Name)
            {
                return PlatformRoles.Operations;
            }
            if (name == PlatformRoles.ServiceAccount.Name)
            {
                return PlatformRoles.ServiceAccount;
            }
            if (name == PlatformRoles.Standard.Name)
            {
                return PlatformRoles.Standard;
            }
            if (name == PlatformRoles.TestingOnly.Name)
            {
                return PlatformRoles.TestingOnly;
            }
            if (name == PlatformRoles.TestingOnlySuperUser.Name)
            {
                return PlatformRoles.TestingOnlySuperUser;
            }

            throw new ArgumentOutOfRangeException(nameof(name), name, null);
        }

        if (scope == RoleAndFeatureScope.Tenant)
        {
            if (name == TenantRoles.BillingAdmin.Name)
            {
                return TenantRoles.BillingAdmin;
            }
            if (name == TenantRoles.Member.Name)
            {
                return TenantRoles.Member;
            }
            if (name == TenantRoles.Owner.Name)
            {
                return TenantRoles.Owner;
            }
            if (name == TenantRoles.TestingOnly.Name)
            {
                return TenantRoles.TestingOnly;
            }

            throw new ArgumentOutOfRangeException(nameof(name), name, null);
        }

        throw new ArgumentOutOfRangeException(nameof(name), name, null);
    }

    /// <summary>
    ///     Converts an individual <see cref="role" /> flag to its respective <see cref="RoleLevel" />
    /// </summary>
    public static RoleLevel ToRoleLevel(this Roles role)
    {
        return role switch
        {
            Roles.Platform_ExternalWebhookService => PlatformRoles.ExternalWebhookService,
            Roles.Platform_Operations => PlatformRoles.Operations,
            Roles.Platform_ServiceAccount => PlatformRoles.ServiceAccount,
            Roles.Platform_Standard => PlatformRoles.Standard,
            Roles.Platform_TestingOnly => PlatformRoles.TestingOnly,
            Roles.Platform_TestingOnlySuperUser => PlatformRoles.TestingOnlySuperUser,
            Roles.Tenant_BillingAdmin => TenantRoles.BillingAdmin,
            Roles.Tenant_Member => TenantRoles.Member,
            Roles.Tenant_Owner => TenantRoles.Owner,
            Roles.Tenant_TestingOnly => TenantRoles.TestingOnly,
            _ => throw new ArgumentOutOfRangeException(nameof(role), role, null)
        };
    }
}