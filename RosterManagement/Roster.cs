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
            if(!_roster.ContainsKey(wave)){
                _roster.Add(wave,new List<string>());
            }
            _roster[wave].Add(cadet);
        }

        public List<string> Grade(int wave){
            List<String> list = new List<string>();
            if(_roster.ContainsKey(wave)){
                list = _roster[wave];
            }
            list.Sort();
            return list;
        }

        public List<string> Roster(){
            List<String> cadets = new List<string>();
            List<int> list = _roster.Keys.ToList();
            list.Sort();
            foreach (int i in list)  { 
                _roster[i].Sort();
                foreach(string temp in _roster[i]){
                    cadets.Add(temp);
                }
            }
            return cadets;
        }
    }
}
