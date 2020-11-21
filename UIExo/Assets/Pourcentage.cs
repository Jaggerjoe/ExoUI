using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pourcentage : MonoBehaviour
{
    [SerializeField]
    private Slider m_Slide = null;
    [SerializeField]
    private Text m_SlideText = null;
  
    // Start is called before the first frame update
    void Start()
    {
        m_SlideText.text = Mathf.RoundToInt(m_Slide.value * 100).ToString() +"%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PourcentageSlider(float value)
    {
        m_SlideText.text = Mathf.RoundToInt(value * 100) + "%";

    }
}
