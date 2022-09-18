using UnityEngine;

namespace VXAtoUnity.Database
{
    public enum SkillType
    {
        Skill,
        Ultimate
    }

    public enum SkillScope
    {
        None,
        OneTarget,
        AllTargets,
        OneAlly,
        OneEnemy,
        AllAlly,
        AllyEnemies,
        OneDeadAlly,
        AllDeadAllies,
        Self,
        RandomTarget,
    }

    public enum SkillOccasion
    {
        Never,
        Always,
        BattleOnly,
        MenuOnly
    }

    public enum SkillHitType
    {
        Guaranteed,
        PhysicalHit,
        MagicalHit
    }

    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Sprite Icon { get; set; }

        public int HealthCost { get; set; }
        public int ManaCost { get; set; }
        public short TPCost { get; set; }
    }
}
