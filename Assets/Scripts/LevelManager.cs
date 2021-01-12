using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
    public static LevelManager instance;

    //public Level CurrentLevel { get { return (LevelData.Levels[LevelIndex]); } }

    /// <summary>
    /// Kaçıncı levelde olduğumuzu gösterir. İlk level numarası 1 olmalıdır.
    /// </summary>
    public int LevelNumber = 1;

    public GameObject CreatedSandvicParent;

    public List<GameObject> IcMalzeme = new List<GameObject>();
    public List<GameObject> LevelMalzeme = new List<GameObject>();
    public List<GameObject> GameSandvic = new List<GameObject>();


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        LevelNumber = PlayerPrefs.GetInt("LevelNo", 1);

        //Eğer levelnumber bozuk gelirse levelnumber 1 olarak düzeltilir. 

        if(LevelNumber < 1)
        {
            LevelNumber = 1;
            PlayerPrefs.SetInt("LevelNo", LevelNumber); 
        }
        SandvicMaker();
    }

    void Start()
    {
       
            

    }

    void Update()
    {
        
    }

    public void SandvicMaker()
    {
        Debug.Log("sandviç oluşturuyor");
        LevelMalzeme.Add(IcMalzeme[0]); // Ekmek 0. index olarak eklendi ve iç malzeme 0' da ekmek vardır.

        int MalzemeNumber = (int)(LevelNumber / 3) + 1;

        for (int i = 0; i < MalzemeNumber; i++)
        {
            LevelMalzeme.Add(IcMalzeme[Random.Range(1, IcMalzeme.Count-1)]);
        }

        LevelMalzeme.Add(IcMalzeme[0]);

        ShowCreatedSandvic();
    }

    void ShowCreatedSandvic()
    {
        
        for(int i = 0; i < LevelMalzeme.Count; i++)
        {
            if(i == 1)
            {
                var obj = Instantiate(LevelMalzeme[i], CreatedSandvicParent.transform.position +
                new Vector3(0, LevelMalzeme[i].transform.localScale.y / 2, 0) * i, Quaternion.identity,
                CreatedSandvicParent.transform);

                obj.GetComponent<Rigidbody>().useGravity = false;
                obj.GetComponent<Rigidbody>().isKinematic = true;
            }

            else
            {
                var obj = Instantiate(LevelMalzeme[i], CreatedSandvicParent.transform.position +
                new Vector3(0, LevelMalzeme[i].transform.localScale.y, 0) * i, Quaternion.identity,
                CreatedSandvicParent.transform);

                obj.GetComponent<Rigidbody>().useGravity = false;
                obj.GetComponent<Rigidbody>().isKinematic = true;
            }

           
        }
    }
}
