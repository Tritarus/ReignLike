using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ImageManager : MonoBehaviour
{
    #region Public Members

    public Transform m_leftButton;
    public Transform m_rightButton;
    public Text m_storyPanel;
    public Text m_namePanel;

    public Image[] m_imagePack;
    public string[] m_story;
    public string[] m_name;
    public Image m_avatar;
    
    #endregion

    #region Public void

    public void GoLeft()
    {
        goLeft = true;
    }
    public void GoRight()
    {
        goRight= true;
    }

    #endregion

    #region System

    void Start()
    {
        m_selected = 0;
        m_imageTansform = m_avatar.GetComponent<Transform>();
        m_position = m_imageTansform.position;
        Myclass myObject = JsonUtility.FromJson<Myclass>(dataJson);

        Debug.Log(myObject.Name);
    }
	
	void Update()
    {
        if (goLeft)
        {
            MoveLeft();
        }
        if (goRight)
        {
            MoveRight();
        }
    }

    void MoveLeft()
    {
        m_imageTansform.position = m_imageTansform.position + Vector3.left * .5f;
        if (m_imageTansform.position.x < -10)
        {
            goLeft = false;
            m_selected = m_random.Next(0, 5);
            m_imageTansform.position = m_position;
            m_avatar.sprite = m_imagePack[m_selected].sprite;
            m_storyPanel.text = m_story[m_selected];
            m_namePanel.text = m_name[m_selected];
        }
    }

    void MoveRight()
    {
        m_imageTansform.position = m_imageTansform.position + Vector3.right * .5f;
        if (m_imageTansform.position.x > 10)
        {
            goRight = false;
            m_selected = m_random.Next(0, 5);
            m_imageTansform.position = m_position;
            m_avatar.sprite = m_imagePack[m_selected].sprite;
            SetMessage(m_story[m_selected]);
            m_namePanel.text = m_name[m_selected];
        }
    }

    void SetMessage(string _text)
    {
        m_storyPanel.text = _text;
    }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private an Protected Members

    private bool goLeft = false;
    private bool goRight = false;
    private int m_selected;
    private Transform m_imageTansform;
    private Vector3 m_position = new Vector3();
    private System.Random m_random = new System.Random();


    string dataJson = File.ReadAllText("C:/Users/student102/Documents/Reign like/Assets/data.json");
    //Myclass myObject = new Myclass();




    #endregion
}

public class Myclass
{
    public string Name = "";
    string Species = "";
    int Number = 0;
    string[] Eater;
}


