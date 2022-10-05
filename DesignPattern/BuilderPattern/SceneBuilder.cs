using System;
namespace BuilderPattern
{
    public class SceneBuilder
    {
        private int sceneNumber { get; set; }
        private string sceneName { get; set; }
        private ICharacter firstLevelMinion { get; set; }
        private ICharacter secondLevelMinion { get; set; }
        private ICharacter thirdLevelMinion { get; set; }

        public SceneBuilder SceneNumber(int sceneNumber)
        {
            this.sceneNumber = sceneNumber;
            return this;
        }

        public SceneBuilder SceneName(string sceneName)
        {
            this.sceneName = sceneName;
            return this;
        }

        public SceneBuilder FirstLevelMinion(ICharacter firstLevelMinion)
        {
            this.firstLevelMinion = firstLevelMinion;
            return this;
        }

        public SceneBuilder SecondLevelMinion(ICharacter secondLevelMinion)
        {
            this.secondLevelMinion = secondLevelMinion;
            return this;
        }

        public SceneBuilder ThirdLevelMinion(ICharacter thirdLevelMinion)
        {
            this.thirdLevelMinion = thirdLevelMinion;
            return this;
        }

        public Scene Build()
        {
            return new Scene(sceneNumber, sceneName, firstLevelMinion, secondLevelMinion, thirdLevelMinion);
        }

    }
}

