using System.Collections.Generic;

namespace Game.Editor
{
     public class DiGraph
    {
        private int m_V;
        private int m_E;
        private List<int>[] m_Adj;
        public DiGraph(int V)
        {
            m_V = V;
            m_E = 0;
            m_Adj = new List<int>[V];
            for (int v = 0; v < V; v++)
            {
                m_Adj[v] = new List<int>();
            }
        }
        public int V() { return m_V; }
        public int E() { return m_E; }
        public void addEdge(int v, int w)
        {
            m_Adj[v].Add(w);
            m_E++;
        }
        public List<int> Adj(int v) { return m_Adj[v]; }
        public DiGraph reverse()
        {
            DiGraph R = new DiGraph(m_V);
            for (int v = 0; v < m_V; v++)
            {
                foreach (int w in Adj(v))
                {
                    R.addEdge(w, v);
                }
            }
            return R;
        }
        public int inDegree(int index, out int value)
        {
            int num = 0;
            int result = -1;
            for (int i = 0; i < m_V; i++)
            {
                for (int j = 0; j < m_Adj[i].Count; j++)
                {
                    if (index == m_Adj[i][j])
                    {
                        num++;
                        result = i;
                    }
                }
                
            }
            value = result;
            return num;
        }

        public int outDegree(int index)
        {
            return m_Adj[index].Count;
        }
    }
    public class DirectedDFS//可达性
    {
        private bool[] m_Marked;
        public DirectedDFS(DiGraph g, int s)
        {
            m_Marked = new bool[g.V()];
            dfs(g, s);
        }

        public DirectedDFS(DiGraph g, List<int> sources)
        {

            m_Marked = new bool[g.V()];
            foreach (int s in sources)
            {
                if (!m_Marked[s])
                {
                    dfs(g, s);
                }
            }
        }

        private void dfs(DiGraph g, int v)
        {
            m_Marked[v] = true;
            foreach (int w in g.Adj(v))
            {
                if (!m_Marked[w])
                {
                    dfs(g, w);
                }
            }
        }

        public bool marked(int v)
        {
            return m_Marked[v];
        }
    }

    public class DirectedCycle
    {
        private bool[] m_Marked;
        private int[] m_EdgeTo;
        private Stack<int> m_Cycle;//有向环中的所有顶点
        private bool[] m_OnStack;//递归调用的栈上的所有顶点

        public DirectedCycle(DiGraph g)
        {
            m_OnStack = new bool[g.V()];
            m_EdgeTo = new int[g.V()];
            m_Marked = new bool[g.V()];
            for (int v = 0; v < g.V(); v++)
            {
                if (!m_Marked[v])
                {
                    dfs(g, v);
                }
            }
        }

        private void dfs(DiGraph g, int v)
        {
            m_OnStack[v] = true;
            m_Marked[v] = true;
            foreach (int w in g.Adj(v))
            {
                if (this.hasCycle())
                    return;
                else if (!m_Marked[w])
                {
                    m_EdgeTo[w] = v;
                    dfs(g, w);
                }
                else if (m_OnStack[w])
                {
                    m_Cycle = new Stack<int>();
                    for (int i = v; i != w; i = m_EdgeTo[i])
                    {
                        m_Cycle.Push(i);
                    }
                    m_Cycle.Push(w);
                    m_Cycle.Push(v);
                }
            }
            m_OnStack[v] = false;
        }

        public bool hasCycle()
        {
            return m_Cycle != null;
        }

        public List<int> cycle()
        {
            return new List<int>(m_Cycle.ToArray());
        }
    }
    public class DepthFirstOrder
    {
        private bool[] m_Marked;
        private Queue<int> m_Pre;//所有顶点的前序排列
        private Queue<int> m_Post;//所有顶点的后序排列
        private Stack<int> m_ReversePost;//所有顶点的逆后序排列

        public DepthFirstOrder(DiGraph g)
        {
            m_Pre = new Queue<int>();
            m_Post = new Queue<int>();
            m_ReversePost = new Stack<int>();
            m_Marked = new bool[g.V()];

            for (int v = 0; v < g.V(); v++)
            {
                if (!m_Marked[v])
                {
                    dfs(g, v);
                }
            }
        }

        private void dfs(DiGraph g, int v)
        {
            m_Pre.Enqueue(v);
            m_Marked[v] = true;
            foreach (int w in g.Adj(v))
            {
                if (!m_Marked[w])
                {
                    dfs(g, w);
                }
            }
            m_Post.Enqueue(v);
            m_ReversePost.Push(v);
        }
        public List<int> pre()
        {
            return new List<int>(m_Pre.ToArray());
        }

        public List<int> post()
        {
            return new List<int>(m_Post.ToArray());
        }

        public List<int> reversePost()
        {
            return new List<int>(m_ReversePost.ToArray());
        }
    }

    public class Topolgical
    {
        private List<int> m_Order;//顶点的拓扑排序
        public Topolgical(DiGraph g)
        {
            DirectedCycle cycle = new DirectedCycle(g);
            if (!cycle.hasCycle())
            {
                DepthFirstOrder dfs = new DepthFirstOrder(g);
                m_Order = dfs.reversePost();
            }
        }
        public List<int> order()
        {
            return m_Order;
        }
        public bool isDAG()//是否有向无环图
        {
            return m_Order != null;
        }
    }
    //符号图
    public class SymbolDiGraph
    {
        private Dictionary<string, int> m_dict;
        private string[] m_keys;
        private DiGraph m_g;

        public SymbolDiGraph(List<List<string>> lists)
        {
            m_dict = new Dictionary<string, int>();
            foreach (List<string> list in lists)
            {
                foreach (string key in list)
                {
                    if (!m_dict.ContainsKey(key))
                    {
                        m_dict.Add(key, m_dict.Count);
                    }

                }
            }

            m_keys = new string[m_dict.Count];
            foreach (string name in m_dict.Keys)
            {
                m_keys[m_dict[name]] = name;
            }
            m_g = new DiGraph(m_dict.Count);
            foreach (List<string> list in lists)
            {
                int v = m_dict[list[0]];
                for (int i = 1; i < list.Count; i++)
                {
                    int w = m_dict[list[i]];
                    m_g.addEdge(v, w);
                }
            }
        }
        public string name(int v)
        {
            return m_keys[v];
        }

        public DiGraph G()
        {
            return m_g;
        }

    }
}
