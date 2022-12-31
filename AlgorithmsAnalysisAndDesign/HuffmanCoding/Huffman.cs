using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAnalysisAndDesign.HuffmanCoding
{
    public class Huffman
    {
        //here codes represent each char as the key of hashtable and value are the code
        public Hashtable Codes = new();
        private PriorityQueue<HeapNode, int> minHeap = new();
        private const char internalChar = (char)0;
        //message to coding
        public void EncodingMessage(string message)
        {
            //get frequency for each char
            Hashtable freqHash = new();
            for (int i = 0; i < message.Length; i++)
            {
                if (freqHash[message[i]] is null)
                    freqHash[message[i]] = 1;
                else
                    freqHash[message[i]] = (int)freqHash[message[i]]! + 1;
            }
            BuildTree(freqHash);
        }
        private void BuildTree(Hashtable freqHash)
        {
            //var freqKeysType= freqHash.Keys.GetType();

            //if  (freqKeysType != typeof(char))
            //    return;

            foreach (char k in freqHash.Keys)
            {
                HeapNode node = new(k, (int)freqHash[k]!);
                minHeap.Enqueue(node, (int)freqHash[k]!);
            }

            HeapNode top;
            HeapNode leftNode;
            HeapNode rightNode;
            while (minHeap.Count != 1)
            {
                leftNode = minHeap.Dequeue();
                rightNode = minHeap.Dequeue();
                top = new HeapNode(internalChar, (leftNode.Freq + rightNode.Freq));
                top.SetChaildNode(leftNode, rightNode);
                minHeap.Enqueue(top, (leftNode.Freq + rightNode.Freq));
            }
            GenerateNode(minHeap.Peek(), "");
        }
        private void GenerateNode(HeapNode node, string str)
        {
            if (node is null) return;
            if (node.Data != internalChar)
                Codes[node.Data] = str;
            GenerateNode(node.LeftNode!, str + "0");
            GenerateNode(node.RightNode!, str + "1");

        }
    }
}
