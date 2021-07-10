using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BSTOperations<T> where T : IComparable
    {
        public T data;
        public BSTOperations<T> left = null, right = null;
        public BSTOperations (T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        public void Insert(T data)
        {
            T current = this.data;
            if (current.CompareTo(data) > 0)
            {
                if(this.left == null)
                {
                    this.left = new BSTOperations<T>(data);
                }
                else {
                    this.left.Insert(data);
                }
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BSTOperations<T>(data);
                }
                else
                {
                    this.right.Insert(data);
                }

            }
        }
        public void Display()
        {
            
            if (this.left != null)
            {
                this.left.Display();
            }
            Console.Write(this.data.ToString()+" ");
            if (this.right != null)
            {
                this.right.Display();
            }
            
        }
        
            

    }
}
