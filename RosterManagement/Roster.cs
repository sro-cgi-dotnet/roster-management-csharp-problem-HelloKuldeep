using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        public void Add(string cadet, int wave){
            if(!_roster.ContainsKey(wave)){ //To check given key is not present
                _roster.Add(wave,new List<string>());   //Add new item
            }
            _roster[wave].Add(cadet);   //Add given string to already present wave
        }

        public List<string> Grade(int wave){
            List<String> list = new List<string>();
            if(_roster.ContainsKey(wave)){  //If key is present, pick corresponding list
                list = _roster[wave];
            }
            list.Sort();
            return list;
        }

        public List<string> Roster(){
            List<String> cadets = new List<string>();
            List<int> list = _roster.Keys.ToList(); //Creating list to sort key elements
            list.Sort();
            foreach (int i in list){ 
                _roster[i].Sort();  //Sorting values of List for every key
                cadets.AddRange(_roster[i]);    //Final list of all sorted values
            }
            return cadets;
        }
    }
}
