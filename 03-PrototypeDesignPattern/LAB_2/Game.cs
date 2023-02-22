namespace _03_PrototypeDesignPattern.LAB_2
{
    public class Game : ProtoTypeGame // Game sınıfına klonlama yeteneğini kazandırdık.
    {
        public int PlayerID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool IsActive { get; set; }
        public Game(int playerID, string gameName, string gameType, bool isActive)
        {
            this.PlayerID = playerID;
            this.GameName = gameName;
            this.GameType = gameType;
            this.IsActive = isActive;
        }
        public override ProtoTypeGame Clone()
        {
            return this.MemberwiseClone() as ProtoTypeGame;
            //MemberwiseClone() metodu, object tipinde değer geriye döndürür. Bu sebeple tip dönüşümü yapılmalıdır.
        }
    }
}
