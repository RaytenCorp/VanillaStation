using Content.Server.Dragon;
using Content.Shared.Roles;

namespace Content.Server.Roles;

/// <summary>
///     Added to mind role entities to tag that they are a R1.
/// </summary>
[RegisterComponent, Access(typeof(DragonSystem))]
public sealed partial class R1RoleComponent : BaseMindRoleComponent
{
}
