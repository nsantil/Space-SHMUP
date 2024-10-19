using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    static private Main S;
    static private Dictionary<eWeaponType, WeaponDefinition> WEAP_DICT;

    [Header("Inscribed")]
    public bool spawnEnemies = true;
    public GameObject[] prefabEnemies;
    public float enemySpawnPerSecond = 0.5f;
    public float enemyInsetDefault = 1.5f;
    public float gameRestartDelay = 2;
    public GameObject prefabPowerUp;
    public WeaponDefinition[] weaponDefinitions;
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public eWeaponType[] powerUpFrequency = new eWeaponType[] {
        eWeaponType.blaster, eWeaponType.blaster, eWeaponType.spread, eWeaponType.shield
    };
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
    public eWeaponType[] powerUpFrequency = new eWeaponType[]{
                             eWeaponType.blaster, eWeaponType.blaster ,
                             eWeaponType.spread, eWeaponType.sheild };

>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    private BoundsCheck bndCheck;

    // New variable for pausing
    private bool isPaused = false;

    private void Awake()
    {
        S = this;

        bndCheck = GetComponent<BoundsCheck>();

        Invoke(nameof(SpawnEnemy), 1f / enemySpawnPerSecond);

        // A generic dictionary with eWeaponType as the key
        WEAP_DICT = new Dictionary<eWeaponType, WeaponDefinition>();
        foreach (WeaponDefinition def in weaponDefinitions)
        {
            WEAP_DICT[def.type] = def;
        }
    }

    void Update()
    {
        // Check for the "P" key press to toggle pause
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }

        // Other game logic only if not paused
        if (!isPaused)
        {
            // Call your enemy spawning logic or any other updates
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1; // Stop or resume time
    }

    public void SpawnEnemy()
    {
        if (!spawnEnemies)
        {
            Invoke(nameof(SpawnEnemy), 1f / enemySpawnPerSecond);
            return;
        }

        int ndx = Random.Range(0, prefabEnemies.Length);

        GameObject go = Instantiate<GameObject>(prefabEnemies[ndx]);

        float enemyInset = enemyInsetDefault;
        if (go.GetComponent<BoundsCheck>() != null)
        {
            enemyInset = Mathf.Abs(go.GetComponent<BoundsCheck>().radius);
        }

        Vector3 pos = Vector3.zero;
        float xMin = -bndCheck.camWidth + enemyInset;
        float xMax = bndCheck.camWidth - enemyInset;
        pos.x = Random.Range(xMin, xMax);
        pos.y = bndCheck.camHeight + enemyInset;
        go.transform.position = pos;

        Invoke(nameof(SpawnEnemy), 1f / enemySpawnPerSecond);
    }

    void DelayedRestart()
    {
        Invoke(nameof(Restart), gameRestartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene("__Scene_0");
    }

    static public void HERO_DIED()
    {
        S.DelayedRestart();
    }

    static public WeaponDefinition GET_WEAPON_DEFINITION(eWeaponType wt)
    {
        if (WEAP_DICT.ContainsKey(wt))
        {
            return (WEAP_DICT[wt]);
        }
        return (new WeaponDefinition());
    }

    static public void SHIP_DESTROYED(Enemy e)
    {
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        if (Random.value <= e.powerUpDropChance)
        {
            int ndx = Random.Range(0, S.powerUpFrequency.Length);
            eWeaponType pUpType = S.powerUpFrequency[ndx];
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        if(Random.value <= e.powerUpDropChance)
        {
            int ndx = Random.Range(0, S.powerUpFrequency.Length);
            eWeaponType pUpType = S.powerUpFrequency[ndx];
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======
>>>>>>> Stashed changes

            GameObject go = Instantiate<GameObject>(S.prefabPowerUp);
            PowerUp pUp = go.GetComponent<PowerUp>();

            pUp.SetType(pUpType);

            pUp.transform.position = e.transform.position;
        }
    }

>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59

            GameObject go = Instantiate<GameObject>(S.prefabPowerUp);
            PowerUp pUp = go.GetComponent<PowerUp>();
<<<<<<< Updated upstream
            pUp.SetType(pUpType);

=======

            pUp.SetType(pUpType);

            pUp.transform.position = e.transform.position;
        }
    }

>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59

            GameObject go = Instantiate<GameObject>(S.prefabPowerUp);
            PowerUp pUp = go.GetComponent<PowerUp>();
            pUp.SetType(pUpType);

>>>>>>> Stashed changes
            pUp.transform.position = e.transform.position;
        }
    }
}
