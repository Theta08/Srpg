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
    public string hp;
    /// <summary>
    /// 쉴드
    /// </summary>
    public string shield;
    /// <summary>
    /// 마나
    /// </summary>
    public string mp;
    /// <summary>
    /// 마나젠  : 턴 시작 시 회복
    /// </summary>
    public string mpreg;
    public string armor;
    public string aparmor;
    public string sharmor;
    /// <summary>
    /// 이동력
    /// </summary>
    public string movesp;
    /// <summary>
    ///  행동력
    /// </summary>
    public string actspd;
}
