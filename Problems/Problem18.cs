using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problems
{
    public class Problem18
    {
        class GraphNode
        {
            public int value;
            public List<GraphNode> neighbours;
        }

        public static string Answer()
        {
            var instance = new Problem18();
            return instance.Answer2();
        }

        public string Answer2()
        {
            GraphNode root = BuildGraph();
            TraverseNode(root, 0);

            return biggestSum.ToString();
        }

        string[][] strings = new string[][]
        {
            new string[]{"75"},
            new string[]{"95", "64"},
            new string[]{"17", "47", "82"},
            new string[]{"18", "35", "87", "10"},
            new string[]{"20", "04", "82", "47", "65"},
            new string[]{"19", "01", "23", "75", "03", "34"},
            new string[]{"88", "02", "77", "73", "07", "63", "67"},
            new string[]{"99", "65", "04", "28", "06", "16", "70", "92"},
            new string[]{"41", "41", "26", "56", "83", "40", "80", "70", "33"},
            new string[]{"41", "48", "72", "33", "47", "32", "37", "16", "94", "29"},
            new string[]{"53", "71", "44", "65", "25", "43", "91", "52", "97", "51", "14"},
            new string[]{"70", "11", "33", "28", "77", "73", "17", "78", "39", "68", "17", "57"},
            new string[]{"91", "71", "52", "38", "17", "14", "91", "43", "58", "50", "27", "29", "48"},
            new string[]{"63", "66", "04", "68", "89", "53", "67", "30", "73", "16", "69", "87", "40", "31"},
            new string[]{"04", "62", "98", "27", "23", "09", "70", "98", "73", "93", "38", "53", "60", "04", "23"}
        };

        Dictionary<long, GraphNode> graphLookup = new Dictionary<long, GraphNode>();

        GraphNode BuildGraph()
        {
            BuildGraph(0);
            return graphLookup[(0 << 32) + 0];
        }

        void BuildGraph(int level)
        {
            if (level < 15)
            {
                for (int i = 0; i < strings[level].Length; i++)
                {
                    GraphNode gn = new GraphNode();
                    gn.value = int.Parse(strings[level][i]);

                    graphLookupInsertAt(level, i, gn);

                    if (level > 0)
                    {
                        //get parent(s)
                        int parentLevel = level - 1;
                        if (i > 0)
                        {
                            GraphNode p1 = graphLookupGetAt(parentLevel, i - 1);

                            if (p1.neighbours == null)
                            {
                                p1.neighbours = new List<GraphNode>();
                            }

                            p1.neighbours.Add(gn);
                        }

                        if (i < strings[parentLevel].Count())
                        {
                            GraphNode p2 = graphLookupGetAt(parentLevel, i);

                            if (p2.neighbours == null)
                            {
                                p2.neighbours = new List<GraphNode>();
                            }

                            p2.neighbours.Add(gn);
                        }
                    }
                }

                BuildGraph(level + 1);
            }
        }

        void graphLookupInsertAt(int row, int col, GraphNode obj)
        {
            long pos = ((long)row << 32) + (long) col;

            Trace.WriteLine("inserting object: " + obj.ToString() + " at pos: " + pos.ToString());

            graphLookup[pos] = obj;
        }

        GraphNode graphLookupGetAt(int row, int col)
        {
            long pos = ((long)row << 32) + (long)col;

            return graphLookup[pos];
        }


        int biggestSum = 0;

        void TraverseNode(GraphNode node, int accumulatedSum)
        {
            accumulatedSum += node.value;

            //leaf node?
            if (node.neighbours == null)
            {
                if (accumulatedSum > biggestSum)
                {
                    biggestSum = accumulatedSum;
                }
            }
            else
            {
                TraverseNode(node.neighbours[0], accumulatedSum);
                TraverseNode(node.neighbours[1], accumulatedSum);
            }
        }
    }
}
