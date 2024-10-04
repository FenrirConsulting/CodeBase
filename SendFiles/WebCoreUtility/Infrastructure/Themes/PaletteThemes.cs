using MudBlazor;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Themes
{
    /// <summary>
    /// Provides pre-defined color palettes for use with MudBlazor themes.
    /// </summary>
    public static class PaletteThemes
    {
        #region Light CVS Theme

        /// <summary>
        /// Light CVS Color Palette, Primary Light Theme
        /// </summary>
        public static MudTheme LightCVSTheme => new MudTheme()
        {
            Palette = new PaletteLight()
            {
                Primary = "#CC0000",         // CVS Red
                Secondary = "#2B88D8",       // Blue
                Background = "#FFFFFF",      // White
                Surface = "#D9D9D9",         // Light Gray
                AppbarBackground = "#525252",// Dark Gray
                DrawerBackground = "#D9D9D9",// Light Gray
                DrawerText = "#212121",      // Dark Gray
                DrawerIcon = "#212121",      // Dark Gray
                TextPrimary = "#212121",     // Dark Gray
                TextSecondary = "#5C5C5C",   // Medium Gray
                Tertiary = "#FFFFFF"         // White
            }
        };

        #endregion

        #region Dark Modern Theme

        /// <summary>
        /// Dark Modern Theme Palette, Primary Dark Theme
        /// </summary>
        public static MudTheme DarkModernTheme => new MudTheme()
        {
            Palette = new PaletteLight()
            {
                Primary = "#569CD6",         // Light Blue
                Secondary = "#D7BA7D",       // Beige
                Background = "#1E1E1E",      // Dark Gray
                Surface = "#252526",         // Darker Gray
                AppbarBackground = "#1F1F1F",// Slightly Darker Gray
                DrawerBackground = "#333333",// Dark Gray
                DrawerText = "#D4D4D4",      // Light Gray
                DrawerIcon = "#D4D4D4",      // Light Gray
                TextPrimary = "#D4D4D4",     // Light Gray
                TextSecondary = "#808080",   // Muted Gray
                Tertiary = "#252526"         // Darker Gray
            }
        };

        #endregion
    }
}