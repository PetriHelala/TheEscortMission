using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public PlayerHealth _playerhealth;
    public Image fillImage;
    private Slider _slider;

    // Start is called before the first frame update
    void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_slider.value <= _slider.minValue) {
            fillImage.enabled = false;
        }

        if (_slider.value > _slider.minValue && !fillImage.enabled) {
            fillImage.enabled = true;
        }

        float fillValue1 = _playerhealth.health / _playerhealth.maxHealth;
        _slider.value = fillValue1;

    }
}
