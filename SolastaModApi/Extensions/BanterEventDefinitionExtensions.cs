using SolastaModApi.Infrastructure;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class BanterEventDefinitionExtensions
    {
        public static T SetCanUseWhileCautious<T>(this T entity, bool value)
            where T : BanterEventDefinition
        {
            entity.SetField("canUseWhileCautious", value);
            return entity;
        }

        public static T SetEventProbability<T>(this T entity, float value)
            where T : BanterEventDefinition
        {
            entity.SetField("eventProbability", value);
            return entity;
        }

        public static T SetEventTrigger<T>(this T entity, string value)
            where T : BanterEventDefinition
        {
            entity.SetField("eventTrigger", value);
            return entity;
        }

        public static T SetPlaybackDelay<T>(this T entity, float value)
            where T : BanterEventDefinition
        {
            entity.SetField("playbackDelay", value);
            return entity;
        }

        public static T SetSearchKey<T>(this T entity, string value)
            where T : BanterEventDefinition
        {
            entity.SetField("searchKey", value);
            return entity;
        }

        public static T SetSelfProbability<T>(this T entity, float value)
            where T : BanterEventDefinition
        {
            entity.SetField("selfProbability", value);
            return entity;
        }
    }
}