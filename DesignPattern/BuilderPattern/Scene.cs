using System;
namespace BuilderPattern
{
    public class Scene
    {
        public int sceneNumber { get; set; }
        public string sceneName { get; set; }
        public ICharacter firstLevelMinion { get; set; }
        public ICharacter secondLevelMinion { get; set; }
        public ICharacter thirdLevelMinion { get; set; }

        public Scene(int sceneNumber, string sceneName, ICharacter firstLevelMinion, ICharacter secondLevelMinion, ICharacter thirdLevelMinion)
        {
            this.sceneNumber = sceneNumber;
            this.sceneName = sceneName;
            this.firstLevelMinion = firstLevelMinion;
            this.secondLevelMinion = secondLevelMinion;
            this.thirdLevelMinion = thirdLevelMinion;
        }
    }
}

