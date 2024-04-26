using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ActiveEnemyData enemySpawnData;
    private List<Object> ememies;
    public static int numOfEnemies = 0;
    public SaveData saveData;
    void Start()
    {
        
        numOfEnemies = enemySpawnData.enemySpawnInformation.Length;
        print(numOfEnemies);
        for(int i = 0; i < numOfEnemies; i++) {
            EnemySpawnInfo curr = enemySpawnData.enemySpawnInformation[i];
            print(curr);
            var prefabPath = GameConstants.enemyTypeToPath[curr.enemyType];
            print(prefabPath);
            print(Resources.Load<GameObject>(prefabPath));
            var currEnemy = Instantiate(Resources.Load<GameObject>(prefabPath),curr.position, Quaternion.identity);
           // numOfEnemies.add((TestEnemy1Behavior)Activator.CreateInstance)
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if(numOfEnemies == 0) {
            print("EVERYON DIAD");
            SceneController.LoadData(saveData);
            SceneController.LoadScene();
        }
    }
}
