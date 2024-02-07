﻿using UnityEngine;
using UnityEngine.UI;

public class GameOverInformation : MonoBehaviour
{
    [SerializeField] Text m_scoreText, m_timeText, m_deliveredText;
    [SerializeField] ScriptableInt m_scoreVariable;
    [SerializeField] ScriptableFloat m_timeVariable, m_totalTeaVariable;

    private void OnEnable()
    {
        m_scoreText.text = m_scoreVariable.m_Value.ToString();
        m_deliveredText.text = m_totalTeaVariable.m_Value.ToString();

        int mins = (int)(m_timeVariable.m_Value / 60f);
        int secs = (int)m_timeVariable.m_Value - (mins * 60);
        m_timeText.text = (/*mins*/ mins.ToString("D2") + ":" /*secs*/ + secs.ToString("D2"));
    }
}
