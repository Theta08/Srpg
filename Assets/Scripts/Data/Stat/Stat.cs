using UnityEngine;

public class Stat : MonoBehaviour
{
    [Header("Stat")]
    private int _index;
    [Space(10)] // 간격 추가
    [SerializeField]
    private string _chaname;
    [SerializeField]
    private int _hp;
    [SerializeField]
    private int _shield;
    [SerializeField]
    private int _moveSp;
    [SerializeField]
    private int _actspd;
    
    public int Index { get { return _index;} set{_index = value;} }
    public string Chaname { get { return _chaname;} set{_chaname = value;} }
    public int Hp { get { return _hp;} set{_hp = value;} }
    public int Shield { get { return _shield;} set{_shield = value;} }
    public int MoveSp { get { return _moveSp;} set{_moveSp = value;} }
    public int ActSpd { get { return _actspd;} set{_actspd = value;} }
    

    void Awake()
    {
        Init();
    }
    
    void Init()
    {
        // 테스트용으로 0번을 함
        CharacterStat characterStat = Managers.Data.CharacterStat[0];
        
        Index = characterStat.index;
        Chaname = characterStat.chaname;
        Hp = characterStat.hp;
        Shield = characterStat.shield;
        MoveSp = characterStat.movesp;
        ActSpd = characterStat.actspd;
        
        Debug.Log($"hp : {Hp}  actspd : {ActSpd}");
    }
}
