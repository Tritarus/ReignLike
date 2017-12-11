using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconManager : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Awake()
    {
        m_transform = gameObject.GetComponent<Transform>();

        foreach(Transform child in m_transform)
        {
            
        }
	}
	
	void Update()
    {
		
	}

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private an Protected Members

    private Transform m_transform;
    private Transform[] m_indicators;

    #endregion
}