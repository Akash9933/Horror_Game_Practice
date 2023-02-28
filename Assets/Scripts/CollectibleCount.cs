﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    private void Start() => UpdateCount();


    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;


    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"{count} / {Collectible.total}";
    }

}
