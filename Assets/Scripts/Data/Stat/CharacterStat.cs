using System;

[Serializable]
public class CharacterStat
{
    public int index;
    /// <summary>
    /// 캐릭터 이름
    /// </summary>
    public string chaname;
    /// <summary>
    /// 체력
    /// </summary>
    public int hp;
    /// <summary>
    /// 쉴드
    /// </summary>
    public int shield;
    /// <summary>
    /// 마나
    /// </summary>
    public int mp;
    /// <summary>
    /// 마나젠  : 턴 시작 시 회복
    /// </summary>
    public float mpreg;
    public int armor;
    public int aparmor;
    public int sharmor;
    /// <summary>
    /// 이동력
    /// </summary>
    public int movesp;
    /// <summary>
    ///  행동력
    /// </summary>
    public int actspd;
}
