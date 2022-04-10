using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextTest : MonoBehaviour
{
    //UI Elements
    public TextMeshProUGUI gameStatus;
    public TextMeshProUGUI dialogueBox;
    public TMP_InputField farmerBuyBox;
    public Button buyFarmerButton;
    public Button dayPassButton;
    public GameObject box;
    public TextMeshProUGUI boxMessage;
    public TextMeshProUGUI dayCounter;

    //Variables
    public int apples = 0;
    public int farmers = 1;
    public int days = 1;

    // Start is called before the first frame update
    void Start()
    {
        //buyFarmerButton.text = "Buy Farmer";
        //dayPassButton.text = "Pass Day";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        //box.transform.position = mousePos;

        gameStatus.text = "Apples: " + apples.ToString() + "\nFarmers: " + farmers.ToString();
        dayCounter.text = "Day: " + days.ToString();
    }

    public void BuyFarmers()
    {
        try
        {
            int num = int.Parse(farmerBuyBox.text);
            //myInput.color = new Color(255, 255, 255, 255);
            if(num <= apples && num > 0)
            {
                apples -= num;
                farmers += num;
                dialogueBox.text = "You just bought " + num + " farmers!";
            }
            if (num > 0)
            {
                dialogueBox.text = "You can't buy negative farmers...";
            }
            else
            {
                dialogueBox.text = "You don't have enough apples!";
            }
        }
        catch
        {
            //myInput.colors = new Color(255,0,0,255);
        }

    }

    public void PassDay()
    {
        dialogueBox.text = "One day passed and your farmers got you " + farmers + " apples!";
        apples += farmers;
        days++;
    }

    public void switchPlaces(GameObject one, GameObject two)
    {
        Vector3 swap = one.transform.position;
        one.transform.position = two.transform.position;
        two.transform.position = swap;
    }

}
