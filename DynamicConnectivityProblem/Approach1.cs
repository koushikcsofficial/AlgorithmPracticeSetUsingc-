using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicConnectivityProblem
{
    public class Approach1
    {
        int[] arr;
        public Approach1(int lengthOftheArray)
        {
            int[] arr = new int[lengthOftheArray];
            //initializing the values in the array
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }
        //method to create a route
        public void Connected(int fromPoint, int toPoint)
        {
            if (IsValidNode(fromPoint) && IsValidNode(toPoint))
            {
                //Initializing the same value to both of the points
                if (CountThePresenceofElement(fromPoint) > 1)
                {
                    //Whenever it will encounter fromPoint in the i'th index of the arr
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == fromPoint)
                        {
                            //Replace the fromPoint with toPoint
                            arr[i] = toPoint;
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == toPoint)
                        {
                            arr[i] = fromPoint;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You have tried to create a path between two invalid node");
            }
        }

        //Find two points if they are connected
        public void Find(int fromPoint, int toPoint)
        {
            if (IsValidNode(fromPoint) && IsValidNode(toPoint))
            {
                if (arr[fromPoint] == arr[toPoint])
                {
                    Console.WriteLine("A connection found between two nodes you entered");
                }
                else
                {
                    Console.WriteLine("There is no such connection found between the nodes you entered");
                }
            }
            else
            {
                Console.WriteLine("You are trying to find a route between two invalid node");
            }
        }
        //Checking if a node is valid
        public bool IsValidNode(int node)
        {
            if (node <= arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Count how many times a value is present in the array
        public int CountThePresenceofElement(int element)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    count = count + 1;
                }
                else
                {
                    count = count + 0;
                }
            }

            return count;
        }
    }
}
