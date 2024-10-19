using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
using UnityEngine;
using TMPro; // Importing TextMeshPro namespace

[RequireComponent(typeof(BoundsCheck))]
public class PowerUp : MonoBehaviour
{
    [Header("Inscribed")]
    public Vector2 rotMinMax = new Vector2(15, 90);
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(BoundsCheck))]
public class PowerUp : MonoBehaviour{
    [Header("Inscribed")]
    [Tooltip("x holds a min val and y a maxc val for a randomrang call")]

    public Vector2 rotMinMax = new Vector2(15, 90);
    [Tooltip("x holds a min val and y a msame as above")]
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    public Vector2 driftMinMax = new Vector2(.25f, 2);
    public float lifeTime = 10;
    public float fadeTime = 4;

    [Header("Dynamic")]
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    private eWeaponType _type; // Backing field for the type property
    
    public GameObject cube; // Reference to the PowerCube child
    public TextMeshPro letter; // Change to TextMeshPro
    public Vector3 rotPerSecond; // Euler rotation speed for PowerCube
    public float birthTime; // The Time.time this was instantiated
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
    public eWeaponType _type; //changed from type in the book
    public GameObject cube;
    public TextMesh letter;
    public Vector3 rotPerSecond;
    public float birthTime;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59

    private Rigidbody rigid;
    private BoundsCheck bndCheck;
    private Material cubeMat;

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    void Awake()
    {
        // Find the Cube reference (there's only a single child)
        cube = transform.GetChild(0).gameObject;
        // Find the TextMeshPro and other components
        letter = GetComponent<TextMeshPro>(); // Updated to TextMeshPro
        rigid = GetComponent<Rigidbody>();
        bndCheck = GetComponent<BoundsCheck>();
        cubeMat = cube.GetComponent<Renderer>().material;

        // Set a random velocity
        Vector3 vel = Random.onUnitSphere; // Get random xyz vel
        vel.z = 0; // Flatten the vel to the xy plane
        vel.Normalize();
        vel *= Random.Range(driftMinMax.x, driftMinMax.y);
        rigid.velocity = vel;

        // Set the rotation of this PowerUp to R:[0,0,0]
        transform.rotation = Quaternion.identity;

        // Randomize rotPerSeconds for PowerCube using rotMinMax x & y
        rotPerSecond = new Vector3(
            Random.Range(rotMinMax.x, rotMinMax.y),
            Random.Range(rotMinMax.x, rotMinMax.y),
            Random.Range(rotMinMax.x, rotMinMax.y)
        );
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Awake()
    {
        cube = transform.GetChild(0).gameObject;

        letter = GetComponent<TextMesh>();
        rigid = GetComponent<Rigidbody>();
        bndCheck = GetComponent<BoundsCheck>();
        cubeMat = GetComponent<Renderer>().material;

        Vector3 vel = Random.onUnitSphere;
        vel.z = 0;
        vel.Normalize();

        vel *= Random.Range(driftMinMax.x, driftMinMax.y);
        rigid.velocity = vel;

        transform.rotation = Quaternion.identity;

        rotPerSecond = new Vector3(Random.Range(rotMinMax[0], rotMinMax[1]),
                                   Random.Range(rotMinMax[0], rotMinMax[1]),
                                   Random.Range(rotMinMax[0], rotMinMax[1]));
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59

        birthTime = Time.time;
    }

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
=======
    // Update is called once per frame
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
=======
    // Update is called once per frame
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    void Update()
    {
        cube.transform.rotation = Quaternion.Euler(rotPerSecond * Time.time);

        float u = (Time.time - (birthTime + lifeTime)) / fadeTime;
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes

        if (u >= 1)
=======
        if(u>=1)
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
<<<<<<< Updated upstream
=======
=======
        if(u>=1)
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        {
            Destroy(this.gameObject);
            return;
        }

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        if (u > 0)
=======
        if(u>0)
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
<<<<<<< Updated upstream
=======
=======
        if(u>0)
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        {
            Color c = cubeMat.color;
            c.a = 1f - u;
            cubeMat.color = c;
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
            c = letter.color;
            c.a = 1f - (u * 0.5f);
=======

            c = letter.color;
            c.a = 1f - (u * .5f);
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
<<<<<<< Updated upstream
=======
=======

            c = letter.color;
            c.a = 1f - (u * .5f);
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
            letter.color = c;
        }

        if (!bndCheck.isOnScreen)
        {
            Destroy(gameObject);
        }
    }

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
    // Property that ensures SetType() is called whenever type is set
    public eWeaponType type
    {
        get { return _type; }
        set { SetType(value); }
    }
=======
    public eWeaponType type { get { return _type; } set { SetType(value); } }
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
<<<<<<< Updated upstream
=======
=======
    public eWeaponType type { get { return _type; } set { SetType(value); } }
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes

    public void SetType(eWeaponType wt)
    {
        WeaponDefinition def = Main.GET_WEAPON_DEFINITION(wt);
<<<<<<< HEAD
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> Stashed changes
        cubeMat.color = def.powerUpCube; // Use powerUpCube instead of powerUpColor
        letter.text = def.letter; // This will set the text using TextMeshPro
        _type = wt; // Assign to the backing field
=======
<<<<<<< Updated upstream
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes
        cubeMat.color = def.powerUpColor; 
        letter.text = def.letter;
        _type = wt;  /// changed from _type

<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
    }

    public void AbsorbedBy(GameObject target)
    {
<<<<<<< HEAD
<<<<<<< Updated upstream
        Destroy(this.gameObject);
    }
=======
=======
<<<<<<< HEAD
        Destroy(this.gameObject);
    }
=======
=======
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
>>>>>>> Stashed changes

        Destroy ( this.gameObject );

    }



































<<<<<<< Updated upstream
=======
<<<<<<< HEAD
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
=======
>>>>>>> Stashed changes
>>>>>>> cb7e64d7f7ba45b40f4e2f67b9c79ae9128e3e59
}
