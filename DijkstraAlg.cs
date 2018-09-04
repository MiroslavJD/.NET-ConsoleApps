using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiroslavD
{
    public class DijkstraAlg
    {
       public static List<int> DijkstraAlgorithm(int[,] graph, int sourceNode, int destinationNode)
       {
           var n = graph.GetLength(0);
           var distance = new int[n];
           for(int i = 0; i < n; i++)
           {
               distance[i] = int.MaxValue;
           }
           distance[sourceNode] = 0;
           var used = new bool[n];
           var previous = new int?[n];
           while(true)
           {
               var minDistance = int.MaxValue;
               var minNode = 0;
               for(int i = 0; i < n; i++)
               {
                   if(!used[i] && minDistance > distance[i])
                   {
                       minDistance = distance[i];
                       minNode = i;               
                   }
               }
               if(minDistance == int.MaxValue)
               {
                    break;
               }             
               used[minNode] = true;
               for(int i = 0; i < n; i++)
               {
                   if(graph[minNode,i] > 0)
                   {
                       var shortestToMinNode = distance[minNode];
                       var distanceToNextNode = graph[i, minNode];
                       var totalDistance = shortestToMinNode + distanceToNextNode;
                       if(totalDistance < distance[i])
                       {
                           distance[i] = totalDistance;
                           previous[i] = minNode;
                       }
                   }
               }                              
           }
           if(distance[destinationNode] == int.MaxValue)
           {
               return null;
           }
           var path = new LinkedList<int>();
           int? currentNode = destinationNode;
           while(currentNode != null)
           {
               path.AddFirst(currentNode.Value);
               currentNode = previous[currentNode.Value];
           }
           return path.ToList();
       }
       public static void PrintPath(int[,] graph, int sourceNode, int destionationNode)
       {
           Console.Write("Shortest path [{0} -> {1}]",sourceNode,destionationNode);
           var path = DijkstraAlg.DijkstraAlgorithm(graph, sourceNode, destionationNode);
           if(path == null)
           {
               Console.Write("no path");
           }
           else
           {
               var pathLength = 0;
               for(int i = 0; i < path.Count-1; i++)
               {
                   pathLength += graph[path[i], path[i+1]];
               }
               var formattedPath = string.Join("->", path);
               Console.WriteLine("{0} (length {1})", formattedPath, pathLength);
           }  
       }
       public static void Main()
       {
           var graph = new[,] 
           {
               {0,2,3,4,5,1},
               {3,2,1,4,5,2},
               {1,2,3,4,5,0},
               {2,1,2,2,3,3},
               {0,0,0,0,0,0},
               {5,5,5,5,5,5},
           };

           PrintPath(graph, 5, 4);
           PrintPath(graph, 2, 2);
           PrintPath(graph, 1, 1);
           PrintPath(graph, 0, 1);
           PrintPath(graph, 4, 4);
       }
    }
}     

