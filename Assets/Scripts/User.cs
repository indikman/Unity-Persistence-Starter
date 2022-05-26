using UnityEngine;

[System.Serializable]
public class User
{
    public string name;
    public int score;
    //public Vector3 spawnPoint;
    //public Outfit outfit;
}

[System.Serializable]
public class Outfit
{
    public string shirt;
    public string pants;
    public string hat;
    public Watch watch;
}

[System.Serializable]
public class Watch
{
    public string make;
    public int year;
    public float price;
}

[System.Serializable]
public class UserList
{
    public User[] users;
}