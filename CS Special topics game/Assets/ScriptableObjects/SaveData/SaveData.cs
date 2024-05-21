
public class SaveData 
{
    public SaveData() {
        currentSavePoint = 0;
        currentOverworldScene = GameConstants.overworldStageNames["StageOne"];
        nextFightId = 0;
        maxHp = 5;
    }
    public int currentSavePoint;
    public string currentOverworldScene;
    public int nextFightId;
    public int maxHp;
}