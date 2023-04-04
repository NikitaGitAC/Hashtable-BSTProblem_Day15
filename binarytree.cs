using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtreeprogram
{
    class binarytree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public binarytree<T> LeftTree { get; set; }
        public binarytree<T> RightTree { get; set; }
        public binarytree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;

        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Add(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new binarytree<T>(item);
                else
                    this.LeftTree.Add(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new binarytree<T>(item);
                else
                    this.RightTree.Add(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (7 * (this.leftCount + this.rightCount) - 1));
        }


    }
}