using Robust.Shared.Configuration;
using Robust.Shared;

namespace Content.Shared.Vanilla.CCVars;

[CVarDefs]
public sealed class CCVarsVanilla
{

    /// <summary>
    /// URL вебхука, используемого для отправки сообщений о банах на Discord сервер.
    /// </summary>
    public static readonly CVarDef<string> DiscordServerBansWebhook = CVarDef.Create("discord.server_bans_webhook", "", CVar.SERVERONLY);

    /// <summary>
    ///     Controls if the connections queue is enabled. If enabled stop kicking new players after `SoftMaxPlayers` cap and instead add them to queue.
    /// </summary>
    public static readonly CVarDef<bool> QueueEnabled = CVarDef.Create("queue.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     Enabled Discord linking, show linking button and modal window
    /// </summary>
    public static readonly CVarDef<bool> DiscordAuthEnabled = CVarDef.Create("discord_auth.enabled", false, CVar.SERVERONLY);

    /// <summary>
    ///     URL of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiUrl = CVarDef.Create("discord_auth.api_url", "", CVar.SERVERONLY);

    /// <summary>
    ///     Secret key of the Discord auth server API
    /// </summary>
    public static readonly CVarDef<string> DiscordAuthApiKey = CVarDef.Create("discord_auth.api_key", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);    

    public static readonly CVarDef<int> GameAlertLevelDownDelay = CVarDef.Create("game.alert_level_down_delay", 1200, CVar.SERVERONLY);
}