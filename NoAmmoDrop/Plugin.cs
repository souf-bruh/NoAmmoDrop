using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using Version = System.Version;

namespace NoAmmoDrop
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "NoAmmoDrop";
        public override string Author => "soufi#9707";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(5, 2, 1);
        public static Plugin Singleton = new Plugin();
        internal EventHandlers EventHandler;
        public override void OnEnabled()
        {
            Singleton = this;
            EventHandler = new EventHandlers(this);
            Player.Dying += EventHandler.OnPlayerDying;
            Player.ChangingRole += EventHandler.OnPlayerChangeRole;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Dying -= EventHandler.OnPlayerDying;
            Player.ChangingRole -= EventHandler.OnPlayerChangeRole;
            EventHandler = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}