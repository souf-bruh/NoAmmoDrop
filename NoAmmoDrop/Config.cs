using System.ComponentModel;
using Exiled.API.Interfaces;

namespace NoAmmoDrop
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("Drop ammo on dying?")]
        public bool IsAmmoDropOnDying { get; set; } = false;
        
        [Description("Drop items on dying?")]
        public bool IsItemsDropOnDying { get; set; } = true;
        
        [Description("Drop ammo on change role?")]
        public bool IsAmmoDropOnChangeRole { get; set; } = false;
    }
}