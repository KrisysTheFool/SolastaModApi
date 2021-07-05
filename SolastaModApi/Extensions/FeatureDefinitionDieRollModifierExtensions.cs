using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionDieRollModifier))]
    public static partial class FeatureDefinitionDieRollModifierExtensions
    {
        public static T SetForcedMinimalHalfDamageOnDice<T>(this T entity, bool value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("forcedMinimalHalfDamageOnDice", value);
            return entity;
        }

        public static T SetMaxRollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("maxRollValue", value);
            return entity;
        }

        public static T SetMinRerollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("minRerollValue", value);
            return entity;
        }

        public static T SetMinRollValue<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("minRollValue", value);
            return entity;
        }

        public static T SetRerollCount<T>(this T entity, int value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("rerollCount", value);
            return entity;
        }

        public static T SetRerollLocalizationKey<T>(this T entity, string value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("rerollLocalizationKey", value);
            return entity;
        }

        public static T SetValidityContext<T>(this T entity, RollContext value)
            where T : FeatureDefinitionDieRollModifier
        {
            entity.SetField("validityContext", value);
            return entity;
        }
    }
}