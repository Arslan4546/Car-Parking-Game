using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
  
    [Header("MainMenu")]
    public GameObject  menupanel;
    public GameObject exitpanel;
    


    [Space(2)]
    [Header("LevelSelection")]
    public GameObject levelSelection;
   

    [Header("General")]
    public GameObject canvas;


    [Header("CarSelection")]
    public GameObject carselection;
    public GameObject[] CarLists;


   
   


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Exit()
    {
        exitpanel.SetActive(true);
        menupanel.SetActive(false);

    }
    public void Yes()
    {
        Application.Quit();

    }
    public void No()
    {
        exitpanel.SetActive(false);
        menupanel.SetActive(true);
        CarLists[1].SetActive(false);
        CarLists[2].SetActive(false);
        CarLists[3].SetActive(false);
        CarLists[4].SetActive(false);
        CarLists[5].SetActive(false);
        CarLists[6].SetActive(false);
        CarLists[7].SetActive(false);
        CarLists[8].SetActive(false);
        CarLists[9].SetActive(false);
        CarLists[0].SetActive(false);
       
    }
    public void BackSelection() 
    {
        carselection.SetActive(false);
        menupanel.SetActive(true);
        CarLists[1].SetActive(false);
        CarLists[2].SetActive(false);
        CarLists[3].SetActive(false);
        CarLists[4].SetActive(false);
        CarLists[5].SetActive(false);
        CarLists[6].SetActive(false);
        CarLists[7].SetActive(false);
        CarLists[8].SetActive(false);
        CarLists[9].SetActive(false);
        CarLists[0].SetActive(false);
    }
    public void Play() 
    {
        carselection.SetActive(true);
        menupanel.SetActive(false);
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
        CarLists[0].SetActive(true);
    }

   public void LoadMainMenu()
    {
        SceneManager.LoadScene("gamePlay"); // Replace "Starting" with the exact name of your target scene
    }

    int count = 0;

    public void NextCar() 
    {
        if (count!= CarLists.Length- 1)
        {
            count++;
        }
        else 
       
       {

            count = 0; 

        }
        foreach (var item in CarLists)
        {
            item.SetActive(false);

        }
        CarLists[count].SetActive(true);

    }

    public void PreviousCar()
    {
        if (count!= 0)
        {

            count--;
        }
        else 
        {
            count = CarLists.Length - 1;
        }
        foreach (var item in CarLists)
        {
            item.SetActive(false);
        }
        CarLists[count].SetActive(true);

    }
    public void toLevelSelection() {
        carselection.SetActive(false);
        levelSelection.SetActive(true);
        CarLists[1].SetActive(false);
        CarLists[2].SetActive(false);
        CarLists[3].SetActive(false);
        CarLists[4].SetActive(false);
        CarLists[5].SetActive(false); 
        CarLists[6].SetActive(false);
        CarLists[7].SetActive(false);
        CarLists[8].SetActive(false);
        CarLists[9].SetActive(false);
        CarLists[0].SetActive(false);



    }
    public void toCarSelection()
    {
        carselection.SetActive(true);
        levelSelection.SetActive(false);
        CarLists[0].SetActive(true);




    }
}
