using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.BusStationBinaryTree.Models
{
    class BusBinaryTree
    {
        private BusNodeBinaryTree root { get; set; }

        public BusNodeBinaryTree FindBusByRoute(int route)
        {
            BusNodeBinaryTree current = root; 
            while (current.Data.Route != route) 
            {
                if (route < current.Data.Route) 
                    current = current.LeftChild;
                else
                    current = current.RightChild; 
                if (current == null) 
                    return null; 
            }
            return current;
        }
        public void AddBusNode(Bus data)
        {
            BusNodeBinaryTree newNode = new BusNodeBinaryTree(); 
            newNode.Data = data; 
            if (root == null) 
                root = newNode;
            else 
            {
                BusNodeBinaryTree current = root; 
                BusNodeBinaryTree parent;
                while (true) 
                {
                    parent = current;
                    if (data.Id < current.Data.Id) 
                    {
                        current = current.LeftChild;
                        if (current == null) 
                        { 
                            parent.LeftChild = newNode;
                            return;
                        }
                    }
                    else 
                    {
                        current = current.RightChild;
                        if (current == null) 
                        { 
                            parent.RightChild = newNode;
                            return;
                        }
                    }
                }
            }
    }
        public void DeleteBusNode (Bus data)
        {
        }
    }
}
