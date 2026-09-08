using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            //string[] playerName = new string[20];
            LinkedList<string> linkedlist = new LinkedList<string>();


            linkedlist.AddLast("Node 1");


            linkedlist.AddLast("Node 2");


            linkedlist.AddFirst("Node 0");

            LinkedListNode<string> FirstNode = linkedlist.First;
            Debug.Log("first: " + FirstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.First;
            Debug.Log("Last: " + lastNode.Value);


            Debug.Log("firstNode.Next: " + FirstNode.Next.Value);
            Debug.Log("firstNode.Next.Next: " + FirstNode.Next.Next.Value);

            Debug.Log("lastNode.Previous: " + lastNode.Previous.Value);
            Debug.Log("lastNode.Previous.Previous: " + lastNode.Previous.Previous.Value);

            if (FirstNode.Previous == null) Debug.Log("firstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next == null");

            linkedlist.AddAfter(FirstNode, "Node 0.5");

            linkedlist.AddAfter(lastNode, "Node 1.5");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");

            linkedlist.Remove("Node 1");
            linkedlist.Remove(node1);
            linkedlist.RemoveLast();
            linkedlist.RemoveFirst();

            linkedlist.Clear();

            throw new System.NotImplementedException();
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>();
            var inv2 = new Dictionary<string, int>();


            inv.Add("Potion", 1);

            inv.Add("Apple", 10);

            inv.Add("Banana", 5);


            inv["Potion"] = 10;

            var pickupitem = "Sword";
            inv[pickupitem] = 1;

            foreach(var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);

            inv.Remove("Apple");

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} value: {value}");
            }

            throw new System.NotImplementedException();
        }

        #endregion
    }
}
