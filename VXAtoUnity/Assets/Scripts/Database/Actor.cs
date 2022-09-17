namespace VXAtoUnity.Database
{
    public class Actor
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
        public byte InitialLevel { get; set; }
        public byte MaxLevel { get; set; }
        public ActorClass Class { get; set; }

        public Actor(string name, string nickName, string description, byte initialLevel, byte maxLevel)
        {
            Name = name;
            NickName = nickName;
            Description = description;
            InitialLevel = initialLevel;
            MaxLevel = maxLevel;
        }
    }
}
