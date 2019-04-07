using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.CPro.HW5.BusStationBinaryTree.Models
{
    class BusNodeBinaryTree
    {
        public Bus Data { get; set; }
        public BusNodeBinaryTree LeftChild { get; set; }
        public BusNodeBinaryTree RightChild { get; set; }
    }
}
