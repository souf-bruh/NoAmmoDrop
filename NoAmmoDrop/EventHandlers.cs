using Exiled.Events.EventArgs;

namespace NoAmmoDrop
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        internal void OnPlayerDying(DyingEventArgs ev)
        {
            if (!plugin.Config.IsAmmoDropOnDying) ev.Target.Ammo.Clear();
            if (!plugin.Config.IsItemsDropOnDying) ev.ItemsToDrop.Clear();
        }
        internal void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (!plugin.Config.IsAmmoDropOnChangeRole) ev.Player.Ammo.Clear();
        }
    }
}