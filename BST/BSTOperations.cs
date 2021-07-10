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
        bool result = false;
        
        public BSTOperations (T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        int count=0;
        public void Insert(T data)
        {

            T current = this.data;
            if (current.CompareTo(data) > 0)
            {
                if(this.left == null)
                {
                    count++;
                    this.left = new BSTOperations<T>(data);
                }
                else {
                    count++;
                    this.left.Insert(data);
                }
            }
            else
            {
                if (this.right == null)
                {
                    count++;
                    this.right = new BSTOperations<T>(data);
                }
                else
                {
                    count++;
                    this.right.Insert(data);
                }

            }
        }
        public void SizeOfTree()
        {
            Console.WriteLine(" ");
            Console.WriteLine("The Size of BST is {0}",(count+1));
        }
        public bool Search(T key,BSTOperations<T> node)
        {
            if(node == null)
            {
                return false;
            }if(node.data.Equals(key))
            {
                Console.WriteLine("Found! "+node.data);
                result = true;
            }
            if (key.CompareTo(node.data) < 0)
            {
                Search(key,node.left);
            }
            if(key.CompareTo(node.data) > 0)
            {
                Search(key, node.right);
            }
           
            return result;
        }
        public void Display()
        {
            
            if (this.left != null)
            {
                //this.leftcount++;
                this.left.Display();
            }
            Console.Write(this.data.ToString()+" ");
            if (this.right != null)
            {
               // this.rightcount++;
                this.right.Display();
            }
          
        }
        
            

    }
}
