namespace AlgorithmsAnalysisAndDesign.HuffmanCoding
{
    public class HeapNode
    {
        public char Data { get;private set; }
        public int Freq { get;private set; }
        public HeapNode? LeftNode { get; private set; }
        public HeapNode? RightNode { get;private set; }
        private HeapNode() { }
        public HeapNode(char data , int freq)
        {
            Data = data;
            Freq = freq; 
        }
        public void SetChaildNode(HeapNode leftNode, HeapNode rightNode)
        {
            this.LeftNode = leftNode;
           this.RightNode = rightNode;
        }

    }
}
