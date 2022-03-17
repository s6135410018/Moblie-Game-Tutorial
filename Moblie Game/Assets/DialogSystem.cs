using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text dialog, TextInButton;
    public int line = 0;
    public float TimeToType = 3.0f;
    //ความเร็วในการพิมพ์
    public bool endWord = false;
    //เมื่อจบประโยค endWord = true;
    public float textPercent = 0f;
    //เอาไว้ดูว่าครบประโยคยังถ้าครบ 100%
    public TextAsset textFile;
    void Start()
    {
        GetDialog(0); //เริ่มที่บรรทัด 0
    }

    void Update()
    {
        TextInButton.text = "Skip";
        GetDialog(line);
        if (Input.GetMouseButtonDown(0))
        {
            line += 1;
            textPercent = 0f;
            endWord = false;
        }
    }
    void GetDialog(int line)
    {
        string[] linesInFile;
        linesInFile = textFile.text.Split('\n');
        if (line < linesInFile.Length)
        {
            callTyping(linesInFile[line]);
        }
        else
        {
            dialog.text = "กด Play เพื่อเริ่มเกม";
            TextInButton.text = "Play";
        }
    }
    void callTyping(string textToType)
    {
        int numberOfLettestsToShow = (int)(textToType.Length * textPercent);
        dialog.text = textToType.Substring(0, numberOfLettestsToShow);
        textPercent += Time.deltaTime / TimeToType;
        textPercent = Mathf.Min(1.0f, textPercent);
        if (textPercent >= 1)
        {
            endWord = true;
        }
    }
}
