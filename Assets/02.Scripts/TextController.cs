using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{

    public GameObject fence01;
    public GameObject fence02;
    public GameObject fence03;

    public GameObject message;
    public TMP_InputField text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTextSelect(){

    }
     void OnTextDeselect(){


    }

    public void onTextEnter(){
        string inputText = text.text;
        
            print("입력값 : "+inputText);
         if(inputText.Trim() == "643")
         {
            print("정답입니다.");
            text.text = "정답입니다.";
            Destroy(fence01);
            Destroy(fence02);
            Destroy(fence03);

            message.SetActive(true);
            
         }
         else
         {
            print("오답입니다.");
            text.text = "오답입니다.";
         }
    }
}
