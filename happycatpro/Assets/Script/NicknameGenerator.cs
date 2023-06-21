using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NicknameGenerator : MonoBehaviour
{
    string[] adjectives = {"민첩한", "수다쟁이", "빈털터리", "춤추는", "우울한", "자유로운", "용감한", "거대한", "활발한", "용감한", "야생의" }; // 형용사 배열
    string[] nouns = {"호랑이","알파카","매","참새","비둘기", "펭귄", "햄스터", "고양이", "병아리", "라마" }; // 명사 배열

    void Start()
    {
        GenerateNickname();
    }

    void GenerateNickname()
    {
        
        string randomAdjective = adjectives[Random.Range(0, adjectives.Length)];
        string randomNoun = nouns[Random.Range(0, nouns.Length)];

        
        string nickname = randomAdjective + " " + randomNoun;

        
        Debug.Log("Generated Nickname: " + nickname);
    }
}

