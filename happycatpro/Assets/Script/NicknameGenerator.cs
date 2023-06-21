using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NicknameGenerator : MonoBehaviour
{
    string[] adjectives = {"��ø��", "��������", "�����͸�", "���ߴ�", "�����", "�����ο�", "�밨��", "�Ŵ���", "Ȱ����", "�밨��", "�߻���" }; // ����� �迭
    string[] nouns = {"ȣ����","����ī","��","����","��ѱ�", "���", "�ܽ���", "�����", "���Ƹ�", "��" }; // ��� �迭

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

