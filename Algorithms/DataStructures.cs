using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        // Generic Node type to be used in Datastructres

        int iValue;         // The Value at this node
        Node pLeft;         // or pPrev
        Node pRight;        // or pNext        

        Node()
        {
            this.pLeft = null;
            this.pRight = null;
            this.iValue = 0;
        }        

        public Node(int iElem)
        {
            this.iValue = iElem;
            this.pLeft = null;
            this.pRight = null;
        }

        public void AddLeftNode(Node pLeft)
        {
            this.pLeft = pLeft;
        }

        public void AddRightNode(Node pRight)
        {
            this.pRight = pRight;
        }

        public Node GetLeft()
        {
            return this.pLeft;
        }

        public Node GetRight()
        {
            return this.pRight;
        }
    }

    public class Tree
    {
        Node pRoot;

        Tree()
        {
            this.pRoot = null;
        }

        Tree(int[] iaElems)
        {
            this.BuildTree(iaElems);
        }

        void BuildTree(int[] iaElems)
        {
            // If Tree is empty
            if (this.pRoot == null)
                pRoot = new Node(iaElems[0]);

        }

        void AddNode(Node pNew)
        {
        }

        void TraverseBFS()
        {
        }

        void TraverseDFS()
        { 
        }
    }    
}
