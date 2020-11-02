using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // 화면 좌측에 필요한 값
    // ex) 도감이동, 캐릭터 잠금여부, 중파여부, 호감도
    private bool    characterIsLock;                    // 캐릭터 잠김 여부
    private float   characterFavorability;              // 캐릭터 호감도

    // 캐릭터 이미지
    //private CharacterImage characterImage;            // 캐릭터 일러스트 정보를 담은 구조체 or 클래스

    // 화면 우측에 필요한 값
    private int     characterLevel;                     // 캐릭터 레벨
    private float   characterExp;                       // 캐릭터 경험치
    private float   characterExpToNextLevel;            // 캐릭터 필요 경험치
    private string  characterName;                      // 캐릭터 이름
    //private CharacterType characterType;              // 캐릭터 타입 구조체 or 클래스
    //private EssentialResources essentialResources;    // 자원( or 소모자원) 구조체 or 클래스
    //private CharacterRank characterRank;              // 캐릭터 랭크 구조체 or 클래스
    private float   characterAttackPower;               // 캐릭터 전투력
    private int     characterUpgradePoint;              // 캐릭터 스탯 포인트
    private float   characterFlameResistance;           // 캐릭터 화염저항
    private float   characterFreezingResistance;        // 캐릭터 빙결저항
    private float   characterElectricalResistance;      // 캐릭터 전기저항
    private float   characterHealthPointLevel;          // 캐릭터 체력 레벨
    private float   characterHealthPoint;               // 캐릭터 체력
    private float   characterAttackPointLevel;          // 캐릭터 공격력 레벨
    private float   characterAttackPoint;               // 캐릭터 공격력
    private float   characterDefensePointLevel;         // 캐릭터 방어력 레벨
    private float   characterDefensePoint;              // 캐릭터 방어력
    private float   characterAimingPointLevel;          // 캐릭터 적중률 레벨
    private float   characterAimingPoint;               // 캐릭터 적중률
    private float   characterEvasionPointLevel;         // 캐릭터 회피율 레벨
    private float   characterEvasionPoint;              // 캐릭터 회피율
    private float   characterCriticalPointLevel;        // 캐릭터 치명타 확률 레벨
    private float   characterCriticalPoint;             // 캐릭터 치명타 확률
    private float   characterActionPointRegen;          // 캐릭터 행동력
    //private Character characterCoreRink[5];           // 캐릭터 코어링크
    private float   characterCoreRinkFitness;           // 캐릭터 코어링크 적합도
    //private CoreRinkBonus characterCoreRinkBonus;     // 캐릭터 코어링크 보너스 구조체 or 클래스
    //private CharacterEquipment characterEquipment;    // 캐릭터 장착 장비

    // 인게임(전투)에서 추가로 필요한 값
    private float   characterActionPoint;               // 캐릭터AP
    //private List<Buff> characterBuffList;             // 캐릭터 상태정보

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
