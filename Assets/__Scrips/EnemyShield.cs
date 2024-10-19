using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes

[DisallowMultipleComponent]
[RequireComponent(typeof(BlinkColorOnHit))]
public class EnemyShield : MonoBehaviour
{
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
[DisallowMultipleComponent]
[RequireComponent(typeof(BlinkColorOnHit))]


public class EnemyShield : MonoBehaviour{

<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    [Header("Inscribed")]
    public float health = 10;

    private List<EnemyShield> protectors = new List<EnemyShield>();
    private BlinkColorOnHit blinker;

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======

>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
=======

>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    // Start is called before the first frame update
    void Start()
    {
        blinker = GetComponent<BlinkColorOnHit>();
        blinker.ignoreOnCollisionEnter = true;

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        if(transform.parent == null) return;
        EnemyShield shieldParent = transform.parent.GetComponent<EnemyShield>();
        if(shieldParent != null){
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        if (transform.parent == null) return;
        EnemyShield shieldParent = transform.parent.GetComponent<EnemyShield>();
        if(shieldParent!= null)
        {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
            shieldParent.AddProtector(this);
        }
    }

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    public void AddProtector(EnemyShield shieldChild){
        protectors.Add(shieldChild);
    }

    public bool isActive{
        get{return gameObject.activeInHierarchy;}
        private set {gameObject.SetActive(value);}
    }

    public float TakeDamage(float dmg){
        foreach(EnemyShield es in protectors){
            if(es.isActive){
                dmg = es.TakeDamage(dmg);
                if (dmg==0) return 0;
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
    public void AddProtector(EnemyShield shieldChild)
    {
        protectors.Add(shieldChild);
    }

    public bool isActive
    {
        get { return gameObject.activeInHierarchy; }
        private set { gameObject.SetActive(value); }
    }

    public float TakeDamage(float dmg)
    {
        foreach(EnemyShield es in protectors)
        {
            if (es.isActive)
            {
                dmg = es.TakeDamage(dmg);

                if (dmg == 0) return 0;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
            }
        }

        blinker.SetColors();

        health -= dmg;
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        if(health <=0){
            isActive = false;
            return -health;
        }

        return 0;
    }

=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        if(health <= 0)
        {
            isActive = false;

            return -health;
        }
        return 0;
    }


<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    // Update is called once per frame
    void Update()
    {
        
    }
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
=======
<<<<<<< HEAD
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes














<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
}
