using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Company
{
    public string name;
    public string url;
    public Location location;
}
[System.Serializable]
public class Location
{
    public string city;
    public string country;
    public string state;
}
[System.Serializable]
public class Retention
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Meetings
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Team
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Manager
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Leadership
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Environment
{
    public string score;
    public string grade;
}
[System.Serializable]
public class WorkCulture
{

    public string score;
    public string grade;
}
[System.Serializable]
public class Compensation
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Happiness
{
    public string score;
    public string grade;
}
[System.Serializable]
public class ExecutiveTeam
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Sentiment
{
    public string score;
    public string grade;
}
[System.Serializable]
public class CEORating
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Diversity
{
    public string score;
    public string grade;
}
[System.Serializable]
public class OverallCulture
{
    public string score;
    public string grade;
}
[System.Serializable]
public class ProfessionalDevelopment
{
    public string score;
    public string grade;
}
[System.Serializable]
public class PerkAndBenefits
{
    public string score;
    public string grade;
}
[System.Serializable]
public class Gender
{
    public string score;
    public string grade;
}
[System.Serializable]
public class eNPS
{
    public string score;
    public string grade;
}
[System.Serializable]
public class OfficeCulture
{
    public string score;
    public string grade;
}
[System.Serializable]

public class Culture
{
    public Happiness happiness;
    public CEORating ceoRating;
    public Environment environment;
    public ExecutiveTeam executiveTeam;
    public WorkCulture workCulture;
    public Diversity diversity;
    public OverallCulture overallCulture;
    public ProfessionalDevelopment professionalDevelopment;
    public Compensation compensation;
    public PerkAndBenefits perkAndBenefits;
    public Team team;
    public Leadership leadership;
    public Meetings meetings;
    public Gender gender;
    public Retention retention;
    public Manager manager;
    public eNPS enps;
    public OfficeCulture officeCulture;
    public Sentiment sentiment;
}

public class JSONtoClass  {
    public Company company;
    public Culture culture;
    
}
