using System;
using UnityEngine;
using UnityEngine.UI;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Static;
using System.Collections.Generic;


namespace DungeonCrawl.Core
{
    /// <summary>
    ///     Loads the initial map and can be used for keeping some important game variables
    /// </summary>
    public class Inventory : MonoBehaviour
    {

        public static Inventory Singleton { get; private set; }

        public bool isPaused { get; set; }
        public List<Item> items { get; set; } = new List<Item>();
        public List<int> itemNumber { get; set; } = new List<int>();
        public GameObject[] slots;


       

        public void Awake()
        {
            if (Singleton != null)
            {
                Destroy(this);
                return;
            }

            Singleton = this;
        }
        

        public void DisplayItems()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                
                if (i < items.Count)
                {
                    slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                    slots[i].transform.GetChild(0).GetComponent<Image>().sprite =
                        ActorManager.Singleton.GetSprite(items[i].DefaultSpriteId);

                    slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                    slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumber[i].ToString();
                }
                else
                {
                    slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                    slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                    slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                    slots[i].transform.GetChild(1).GetComponent<Text>().text = null;
                }
            }
        }

        public void AddItem(Item _item)
        {
            if (!items.Contains(_item))
            {
                items.Add(_item);
                itemNumber.Add(1);
                Debug.Log("Item number added!");
            }
            else
            {
                Debug.Log("Item Exists!");
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].DefaultName == _item.DefaultName)
                    {
                        itemNumber[i] += 1;
                    }
                }
            }

            Singleton.DisplayItems();
        }

        public bool CkeckIfKey()
        {
            for (int i = 0; i <items.Count; i++)
            {
                if (items[i] is Key)
                {
                    return true;
                }
            }

            return false;
        }

        public Item ReturnKey()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] is Key)
                {
                    return items[i];
                }
            }

            return null;
        }

        public void RemoveItem(Item _item)
        {
            if (items.Contains(_item))
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].DefaultName == _item.DefaultName)
                    {
                        itemNumber[i]--;
                        if (itemNumber[i] == 0)
                        {
                            items.Remove(_item);
                            itemNumber.Remove(  itemNumber[i]);
                        }
                    }
                }
            }
            else
            {
                Debug.Log("There is not " + _item.DefaultName + " in my inventory");
            }

            Singleton.DisplayItems();
        }
    }
}
