using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TEXT_GAME_MNGR : MonoBehaviour
{
    public int hpValue, staminaValue;
    public TextMeshProUGUI hpTextValue, staminaTextValue, startTextValue;
    public string startOfStory;
    public GameObject Lvl1_Choices;

    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        staminaValue = 10;
        startOfStory = "The birds are chirping! Wake up!";
    }

    // Update is called once per frame
    void Update()
    {
        hpTextValue.text = hpValue.ToString();
        staminaTextValue.text = staminaValue.ToString();
        startTextValue.text = startOfStory;
    }

    public void GoUpStairs()
    {
        hpValue -= 10;
        staminaValue -= 10;
        startOfStory = "YOU DIED. It's dark and you slipped on the floor.";
        Lvl1_Choices.SetActive(false);
    }

    public void GoToTheBathroom()
    {
        hpValue += 5;
        staminaValue += 10;
        startOfStory = "You entered the bathroom. You to brushed your teeth and washed your face.";
    }

    public void MakeBFast()
    {
        staminaValue -= 3;
        hpValue += 15;
        startOfStory = "You cooked egg and bacon.";
    }
}
