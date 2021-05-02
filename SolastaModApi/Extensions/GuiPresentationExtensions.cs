using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// It's not guaranteed to work against any other version of Solasta.
    /// If you find an issue please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class GuiPresentationExtensions
    {
        public static T SetColor<T>(this T entity, Color value)
            where T : GuiPresentation
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetHidden<T>(this T entity, bool value)
            where T : GuiPresentation
        {
            entity.SetField("hidden", value);
            return entity;
        }

        public static T SetSortOrder<T>(this T entity, int value)
            where T : GuiPresentation
        {
            entity.SetField("sortOrder", value);
            return entity;
        }

        public static T SetSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : GuiPresentation
        {
            entity.SetField("spriteReference", value);
            return entity;
        }
    }
}