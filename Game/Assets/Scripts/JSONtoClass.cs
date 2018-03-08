using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Company
{
    public string name;
    public string url;
}

public class Retention
{
    public string score;
    public string grade;
}
public class Meetings
{
    public string score;
    public string grade;
}
public class Team
{
    public string score;
    public string grade;
}
public class Manager
{
    public string score;
    public string grade;
}
public class Leadership
{
    public string score;
    public string grade;
}
public class Environment
{
    public string score;
    public string grade;
}
public class WorkCulture
{
    public string score;
    public string grade;
}
public class Compensation
{
    public string score;
    public string grade;
}
public class Happiness
{
    public string score;
    public string grade;
}
public class ExecutiveTeam
{
    public string score;
    public string grade;
}
public class Sentiment
{
    public string score;
    public string grade;
}

public class Culture
{
    public Retention retention;
    public Meetings meetings;
    public Team team;
    public Manager manager;
    public Leadership leadership;
    public Environment environment;
    public WorkCulture workCulture;
    public Compensation compensation;
    public Happiness happiness;
    public ExecutiveTeam executiveTeam;
    public Sentiment sentiment;
}

public class JSONtoClass  {
    public Company company;
    public Culture culture;
}
