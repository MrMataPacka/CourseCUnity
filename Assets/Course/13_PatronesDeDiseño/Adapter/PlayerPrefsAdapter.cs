using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño
{
    public class PlayerPrefsAdapter :  MonoBehaviour, IDataSaver
    {
        
        public void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }
        public string GetString(string key, string defaultValue)
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        public void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }

        public int GetInt(string key, int defaultValue)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }



    }
}
