
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]
public class CreateNewTeam : MonoBehaviour
{
    public static CreateNewTeam instance;
    public GameObject NewTeam;
   
    public Transform NewTeamPos;

    [SerializeField] public GameObject NewTeamDir;

    public int _teams;

      
    static int i = 0;
   
   public   List<GameObject> listOfTeams = new List<GameObject>();

    
    private void Start()
    {
        
        while (i < ValuesFromChangeImage._teamValueInt)
        {
            i++;
           GameObject team= Instantiate(NewTeam, NewTeamPos.position, Quaternion.identity);
            team.transform.SetParent(NewTeamDir.transform,false);
            listOfTeams.Add(team);

            NewTeamPos.position +=NewTeamPos.right*5 ;
        }
        Debug.Log("start");
    }

   

    

}
