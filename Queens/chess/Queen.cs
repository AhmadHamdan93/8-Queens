using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    class Queen
    {
        List<Node> solution;
        Stack<Node> stack;

        public Queen()
        {
            this.solution = new List<Node>();
            this.stack = new Stack<Node>();
        }

        public void search()
        {
            
            this.solution = new List<Node>();
            this.stack = new Stack<Node>();

            // --------- initail ------------------
            Node init_sol = new Node();
            generation(init_sol);
            // -----------------------------------

            // -------- loop for search about solution in stack -----
            while (this.stack.Count != 0)
            {
                Node node = this.stack.Pop();
                if (isGoal(node))
                {
                    this.solution.Add(node);
                }
                else
                {
                    generation(node);
                }
            }
            // ------------------- end search ------------------- 
        }

        void generation(Node sol)
        {
            Node n1 = copyNode(sol);
            int idx = Array.IndexOf(n1.row, -1);
            for (int i = 0; i < 8; i++)
            {
                Node n = copyNode(sol);
                if (checkLine(n, i) && checkDownLine(n, idx, i) && checkUpLine(n, idx, i))
                {
                    n.storeSol(idx,i);
                    stack.Push(n);
                }
            }
        }

        Node copyNode(Node sol)
        {
            Node n = new Node();
            for (int i = 0; i < 8; i++)
            {
                n.row[i] = sol.row[i];
            }
            return n;
        }

        Boolean checkLine(Node node, int row)
        {
            int idx = Array.IndexOf(node.row, row);
            if (idx == -1)
                return true;
            else
                return false;
        }

        Boolean checkDownLine(Node node, int column, int row)
        {
            int j = row;
            for (int i = column; i >= 0; i--)
            {
                if (node.row[i] == j)
                    return false;
                j++;
                if (j == 8)
                {
                    return true;
                }
            }
            return true;
        }

        Boolean checkUpLine(Node node, int column, int row)
        {
            int j = row;
            for (int i = column; i >= 0; i--)
            {
                if (node.row[i] == j)
                    return false;
                j--;
                if (j == -1)
                {
                    return true;
                }
            }
            return true;
        }

        Boolean isGoal(Node sol)
        {
            int idx = Array.IndexOf(sol.row, -1);
            if (idx == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkAllSolution()
        {
            for (int i = 0; i < solution.Count - 1; i++)
            {
                for (int j = i + 1; j < solution.Count; j++)
                {
                    int num = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        if (solution[i].row[k] == solution[j].row[k])
                            num++;
                    }
                    if (num == 8)
                        return false;
                }
            }
            return true;
        }

        public List<Node> getSolution()
        {
            return this.solution;
        }

    }
}
