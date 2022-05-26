using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        /* PlayerPrefs.SetString("name", "Indika");*/

        /*User user1 = new User();
        user1.name = "Indika";
        user1.score = 10;
        user1.spawnPoint = new Vector3(2, 3, 6);

        User user2 = new User();
        user2.name = "David";
        user2.score = 11;


        string jsonUser1 = JsonUtility.ToJson(user1);
        Debug.Log(jsonUser1);
        PlayerPrefs.SetString("user1", jsonUser1);*/

       // User user1 = new User();
        /*user1.name = "Indika";
        user1.score = 10;
        user1.spawnPoint = new Vector3(2, 3, 6);
        user1.outfit = new Outfit();
        user1.outfit.shirt = "ralph-lauren";
        user1.outfit.pants = "lewis";
        user1.outfit.hat = "supreme";*/

        /*List<User> users = new List<User>();
        UserList userList = new UserList();

        for (int i = 0; i < 10; i++)
        {
            User user = new User();
            user.name = "user" + i;
            user.score = Random.Range(10, 100);
            users.Add(user);
        }

        userList.users = users.ToArray();


        string jsonUsers = JsonUtility.ToJson(userList);

        Debug.Log(jsonUsers);
         
        PlayerPrefs.SetString("users", jsonUsers);*/


        string json = PlayerPrefs.GetString("users");
        Debug.Log(json);

        UserList users;
        users = JsonUtility.FromJson<UserList>(json);

        for (int i = 0; i < users.users.Length; i++)
        {
            Debug.Log(i + " : " + users.users[i].name + " - " + users.users[i].score);
        }

        //transform.position = user1.spawnPoint;
    }

    
}
