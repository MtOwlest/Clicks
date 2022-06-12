using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    //variables
    public GameObject Money = null;

    Quaternion rot;

    public Vector2 moneyMoveSpeed;

    public bool canClick;

    public Text clicks;

    public float numofclicks;
    public float timeTilKill;

    float multiplier;

    public Vector2 playerScale;

    public Transform player;

    bool canMultiply;

    public bool stage5;
    public bool stage6;

    public Transform GoBackHere;

    //first upgrades

    public GameObject Button1;
    public GameObject Image1;

    public bool Stage2;
    public GameObject Button2;
    public GameObject Image2;

    public GameObject Button3;
    public GameObject Image3;
    public bool stage3;

    public GameObject Accesory1;
    public GameObject Accesory2;
    public GameObject Accesory3;

    public Vector2 playerPos;

    public int Done;

    //2nd upgrades!

    public GameObject Button11;
    public GameObject Image11;

    public GameObject Button22;
    public GameObject Image22;

    public GameObject Button33;
    public GameObject Image33;

    public bool stage4 = false;

    public GameObject Accesory11;

    public GameObject Accesory22;

    public GameObject Accesory33;

    public float TimeToClick;

    public GameObject clicks50;
    public GameObject clicks100;
    public GameObject clicks1k;
    public GameObject clicks10k;
    public GameObject clicks100k;
    public GameObject clicks1m;
    void Start()
    {
        playerScale = new Vector3(4f, 4f, 0);
        player.localScale = playerScale;
        multiplier = 2;
        canClick = true;
        rot = Quaternion.Euler(0, 0, 0);
        canMultiply = false;
        stage3 = false;
        Accesory1.SetActive(false);
        Accesory2.SetActive(false);
        Accesory3.SetActive(false);
    }

    void Update()
    {

        //level change.
        if (Done == 3)
        {
            Image1.SetActive(false);
            Image2.SetActive(false);
            Image3.SetActive(false);

            clicks50.SetActive(false);
            clicks100.SetActive(false);
            clicks1k.SetActive(false);

            clicks10k.SetActive(true);
            clicks100k.SetActive(true);
            clicks1m.SetActive(true);

            Button11.SetActive(true);
            Button22.SetActive(true);
            Button33.SetActive(true);

            if(Done == 6)
            {
                Image11.SetActive(false);
                Image22.SetActive(false);
                Image33.SetActive(false);

                if(numofclicks > 100000000)
                {
                    SceneManager.LoadScene("EndScreen");
                }
                
            }

        }

        clicks.text = "CLICKS: " + numofclicks;

        player.transform.localScale = playerScale;

        if (canClick && Input.GetMouseButtonDown(0)) 
        {
                if (canMultiply)
                {
                    numofclicks++;
                    numofclicks++;
                    if (Stage2 && canMultiply)
                    {
                        numofclicks++;
                        numofclicks++;
                        numofclicks++;

                        if (stage3 && canMultiply)
                        {
                            // better way to do it: numofclicks *= 3; replace if u have time.
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            if (stage4)
                            {
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                            numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;

                                if (stage5)
                                {
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++; 
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                numofclicks++;
                                if (stage6)
                                {
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++; numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++; numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++; numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                    numofclicks++;
                                }
                                }
                            }
                        }
                    }

                }
                else
                {
                    numofclicks++;
                }

                //random range 
                var position = new Vector3(Random.Range(6, -6), -2, 0);

                //insatiante clone
                var clone = Instantiate(Money, position, rot);
                //addforce
                clone.GetComponent<Rigidbody2D>().AddForce(moneyMoveSpeed, ForceMode2D.Impulse);


                //destroy and set a timer til we can click again!
                Destroy(clone, timeTilKill);
                StartCoroutine(nameof(ClickReset));
        }
    }

    //added delay!
    public IEnumerator ClickReset()
    {
        canClick = false;
        yield return new WaitForSeconds(TimeToClick);
        canClick = true;
    }

    public void Advancement1()
    {
        if (numofclicks > 50)
        {
            numofclicks -= 50;
            canMultiply = true;
            Button1.SetActive(false);
            Image1.SetActive(true);
            Accesory1.SetActive(true);
            clicks50.SetActive(false);
            Done += 1;
            //Debug.Log(Done);
        }
        else
        {
            return;
        }
    }

    public void Advancement2()
    {
        if (numofclicks >= 100 && canMultiply)
        {
            numofclicks -= 100;
            Stage2 = true;
            Button2.SetActive(false);
            Image2.SetActive(true);
            Accesory2.SetActive(true);
            clicks100.SetActive(false);
            Done += 1;
            //Debug.Log(Done);
        }
        else
        {
            return;
        }

    }

    public void Advancement3()
    {
            if (numofclicks >= 1000 && Stage2)
            {
                numofclicks -= 1000;
                stage3 = true;
                Button3.SetActive(false);
                Image3.SetActive(true);
                Accesory3.SetActive(true);
                clicks1k.SetActive(false);
                player.transform.position = playerPos;
                Done += 1;
                //Debug.Log(Done);
            }
            else
            {
                return;
            }
    }

    public void Advancement11()
    {
        if (numofclicks > 10000)
        {
            numofclicks -= 10000;
            stage4 = true;
            Button11.SetActive(false);
            Image11.SetActive(true);
            Accesory11.SetActive(true);
            clicks10k.SetActive(false);
            Done += 1;
            //Debug.Log(Done);
        }
        else
        {
            return;
        }
    }

    public void Advancement22()
    {
        if (numofclicks > 100000)
        {
            numofclicks -= 100000;
            stage5 = true;
            Button22.SetActive(false);
            Image22.SetActive(true);
            Accesory22.SetActive(true);
            clicks100k.SetActive(false);
            Done += 1;
            //Debug.Log(Done);
        }
        else
        {
            return;
        }
    }

    public void Advancement33()
    {
        if (numofclicks > 1000000)
        {
            numofclicks -= 1000000;
            stage6 = true;
            Button33.SetActive(false);
            Image33.SetActive(true);
            Accesory33.SetActive(true);
            clicks1m.SetActive(false);
            Done += 1;
            //Debug.Log(Done);
        }
        else
        {
            return;
        }
    }
}
