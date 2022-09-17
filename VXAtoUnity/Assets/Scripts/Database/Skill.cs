using UnityEngine;

namespace VXAtoUnity.Database
{
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
