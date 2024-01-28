using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code
{
    public sealed class HealthBar : MonoBehaviour
    {
        public Vector2Int MinAndMaxHealth;
         public Slider Slider;
         public TMP_Text Text;
         public int MaxHealth = 100;
         public float CurrentHealth;
         private int _minHealth = 0;
         private float _currentHealth;

         private void Start()
         {
             Slider.maxValue = MaxHealth; // MinAndMaxHealth.y;
             Slider.minValue = _minHealth; // MinAndMaxHealth.x;
         }

         private void Update()
         {
             float currentHealth = Mathf.Clamp(CurrentHealth, _minHealth, MaxHealth);
             _currentHealth = Mathf.Lerp(_currentHealth, currentHealth, Time.deltaTime * 10f);
             Slider.value = _currentHealth;
             Text.text = $"{_currentHealth:#}";
         }
    }
}
