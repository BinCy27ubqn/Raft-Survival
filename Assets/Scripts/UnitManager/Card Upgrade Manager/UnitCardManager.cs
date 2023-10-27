using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCardManager : MonoBehaviour
{
    [SerializeField]
    private UnitCardSO[] _unitCardSOs;
    [SerializeField]
    private UnitCardTemplate[] _unitCardTemplates;
    
    private void Start()
    {
        LoadPanel();
    }

    public void LoadPanel()
    {
        for (int i = 0; i < _unitCardTemplates.Length; i++){
            _unitCardTemplates[i].title.text = _unitCardSOs[i].title;
            _unitCardTemplates[i].description.text = _unitCardSOs[i].description;
            _unitCardTemplates[i].unitImg.sprite = _unitCardSOs[i].sprite;
        }
    }
}
