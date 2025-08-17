using UnityEngine;

public class InformationData : ScriptableObject
{
    public enum InformationType { None, Evidence, Motive, Knowledge, Opportunity }
    public InformationType actualType;
    public InformationType chosenType;
    public Sprite icon;
    public string InformationString;
}
