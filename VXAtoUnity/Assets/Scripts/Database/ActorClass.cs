using VXAtoUnity.Database.Utils;
using System.Collections.Generic;

namespace VXAtoUnity.Database
{
    public class ActorClass
    {
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }

        public QuadraticFunction ExperienceCurve { get; set; }
        public QuadraticFunction MaxHealthCurve { get; set; }
        public QuadraticFunction MaxManaCurve { get; set; }
        public QuadraticFunction MaxStrengthCurve { get; set; }
        public QuadraticFunction MaxDefenseCurve { get; set; }
        public QuadraticFunction MaxMagicCurve { get; set; }
        public QuadraticFunction MaxMagicalDefenseCurve { get; set; }
        public QuadraticFunction MaxAgilityCurve { get; set; }
        public QuadraticFunction MaxLuckCurve { get; set; }

        public ActorClass(string name)
        {
            Name = name;
            Skills = new List<Skill>();
        }

    }
}
